﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using ZDY.DMS.Services.Shared.Models;

namespace ZDY.DMS.Services.AdminService.Models
{    
    [Table("Dictionary_Key")]
    public class DictionaryKey : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public int Order { get; set; } = 0;
    }
}
