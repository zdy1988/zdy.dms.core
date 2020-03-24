﻿using System;
using System.Collections.Generic;
using System.Text;
using ZDY.DMS.Models;

namespace ZDY.DMS.Services.WorkFlowService.Events
{
    public class SubFlowFinishedEventArgs : WorkFlowCustomEventArgs
    {
        /// <summary>
        /// 子流程实例
        /// </summary>
        public WorkFlowInstance SubFlowInstance { get; set; }
    }
}
