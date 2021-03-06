﻿using ZDY.DMS.Events;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDY.DMS.Messaging.RabbitMQ
{
    public class RabbitEventBus : RabbitMessageBus, IEventBus
    {
        public RabbitEventBus(string uri, 
            IMessageSerializer messageSerializer,
            IMessageHandlerExecutionContext messageHandlerExecutionContext,
            string exchangeName, 
            string exchangeType = ExchangeType.Fanout, 
            string queueName = null,
            bool autoAck = false)
            : base(uri, messageSerializer, messageHandlerExecutionContext, exchangeName, exchangeType, queueName, autoAck)
        { }

        public RabbitEventBus(IConnectionFactory connectionFactory, 
            IMessageSerializer messageSerializer,
            IMessageHandlerExecutionContext messageHandlerExecutionContext,
            string exchangeName, 
            string exchangeType = ExchangeType.Fanout, 
            string queueName = null,
            bool autoAck = false)
            : base(connectionFactory, messageSerializer, messageHandlerExecutionContext, exchangeName, exchangeType, queueName, autoAck)
        { }
    }
}
