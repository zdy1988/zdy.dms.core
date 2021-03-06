﻿using System;
using ZDY.DMS.Services.Shared.Models;

namespace ZDY.DMS.Services.OrganizationService.Models
{
    public class Department : BaseEntity
    {
        public Guid CompanyId { get; set; }
        public Guid ParentId { get; set; }
        public string DepartmentName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Note { get; set; }
        public int Order { get; set; } = 0;
    }
}
