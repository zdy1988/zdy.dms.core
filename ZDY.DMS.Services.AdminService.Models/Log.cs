﻿using System;
using ZDY.DMS.Services.Shared.Models;

namespace ZDY.DMS.Services.AdminService.Models
{
    public class Log : BaseEntity
    {
        public string Message { get; set; }
        public int Type { get; set; }
    }
}
