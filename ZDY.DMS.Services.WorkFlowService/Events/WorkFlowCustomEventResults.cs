﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZDY.DMS.Services.WorkFlowService.Events
{
    public class WorkFlowCustomEventResults
    {
        public bool IsError { get; set; } = false;
        public string ErrorMessage { get; set; } = "";
    }
}
