﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZDY.DMS.Services.Shared.Events
{
    public class GlobalMessageCreatedEvent : MessageCreatedEvent
    {
        public GlobalMessageCreatedEvent(string title, string content, int level, params Guid[] receiver)
            : base(title, content, level, Guid.Parse("00000000-0000-0000-0000-000000000003"), "系统管理员", receiver)
        {

        }
    }
}
