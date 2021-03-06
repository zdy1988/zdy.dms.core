﻿using System;
using System.Collections.Generic;
using System.Text;
using ZDY.DMS.Repositories;
using ZDY.DMS.Services.Shared.Events;
using ZDY.DMS.Services.MessageService.Enums;
using ZDY.DMS.Services.MessageService.ServiceContracts;

namespace ZDY.DMS.Services.MessageService.EventHandlers
{
    public class PrivateMessageCreatedEventHandler : MessageCreatedEventHandler<PrivateMessageCreatedEvent>
    {
        public PrivateMessageCreatedEventHandler(IMessageInboxService messageInboxService)
            : base(messageInboxService, MessageKinds.Private)
        {

        }
    }
}
