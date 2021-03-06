﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ZDY.DMS.Messaging.Simple
{
    internal sealed class MessageQueue
    {
        private readonly ConcurrentQueue<ValueTuple<IMessage,int>> queue = new ConcurrentQueue<ValueTuple<IMessage, int>>();
        private static Task backgroundTask;
        private Action<IMessage> Consumer;

        private static MessageQueue instance;

        private static readonly object syncRoot = new object();

        public static MessageQueue GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new MessageQueue();
                    }
                }
            }
            return instance;
        }

        public MessageQueue()
        {
            backgroundTask = new Task(MessageHandler);

            backgroundTask.Start();
        }

        public int Count
        {
            get
            {
                return this.queue.Count;
            }
        }

        public void PushMessage(IMessage message)
        {
            PushMessage(message, 0);
        }

        private void PushMessage(IMessage message, int tryCount)
        {
            queue.Enqueue(new ValueTuple<IMessage, int>(message, tryCount));
        }

        private ValueTuple<IMessage, int> PopMessage()
        {
            var succeeded = queue.TryDequeue(out ValueTuple<IMessage, int> message);
            return succeeded ? message : default;
        }

        private Action MessageHandler => () =>
        {
            while (true)
            {
                if (queue.IsEmpty)
                {
                    Thread.Sleep(3000);
                }
                else
                {
                    var message = PopMessage();

                    if (message.Item1 != null)
                    {
                        try
                        {
                            this.Consumer.Invoke(message.Item1);
                        }
                        catch
                        //catch (Exception e)
                        {
                            message.Item2++;

                            if (message.Item2 < 3)
                            {
                                this.PushMessage(message.Item1);
                            }
                        }
                    }
                }
            }
        };

        public void Consume(Action<IMessage> consumer)
        {
            Consumer = consumer;
        }
    }
}
