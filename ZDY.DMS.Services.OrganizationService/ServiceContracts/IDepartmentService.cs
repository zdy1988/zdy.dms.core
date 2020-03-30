﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZDY.DMS.Services.Common.Models;

namespace ZDY.DMS.Services.OrganizationService.ServiceContracts
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllDepartmentAsync(Guid companyID);
    }
}
