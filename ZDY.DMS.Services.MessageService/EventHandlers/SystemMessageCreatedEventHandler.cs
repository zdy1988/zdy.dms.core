﻿using System;
using System.Collections.Generic;
using System.Text;
using ZDY.DMS.Repositories;
using ZDY.DMS.Services.Common.Events;
using ZDY.DMS.Services.MessageService.Enums;
using ZDY.DMS.Services.MessageService.ServiceContracts;

namespace ZDY.DMS.Services.MessageService.EventHandlers
{
    public class SystemMessageCreatedEventHandler : MessageCreatedEventHandler<SystemMessageCreatedEvent>
    {
        public SystemMessageCreatedEventHandler(Func<Type, IRepositoryContext> repositoryContextFactory, IMessageInboxService messageInboxService)
            : base(repositoryContextFactory, messageInboxService, MessageKinds.System)
        {

        }
    }
}
