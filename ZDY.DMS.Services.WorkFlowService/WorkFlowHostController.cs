﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZDY.DMS.AspNetCore.Mvc;
using ZDY.DMS.Repositories;
using ZDY.DMS.Services.WorkFlowService.DataObjects;
using ZDY.DMS.Services.WorkFlowService.Enums;
using ZDY.DMS.Services.WorkFlowService.Models;
using ZDY.DMS.Services.WorkFlowService.ServiceContracts;

namespace ZDY.DMS.Services.WorkFlowService
{
    public class WorkFlowHostController : ApiController
    {
        private readonly IRepositoryContext repositoryContext;
        private readonly IWorkFlowHostService workFlowHostService;

        public WorkFlowHostController(IRepositoryContext repositoryContext,
            IWorkFlowHostService workFlowHostService)
        {
            this.repositoryContext = repositoryContext;
            this.workFlowHostService = workFlowHostService;
        }

        [HttpPost]
        public async Task StartUp(WorkFlowInstance instance)
        {
            var userIdentity = this.UserIdentity;

            instance.CompanyId = userIdentity.CompanyId;
            instance.CreaterId = userIdentity.Id;
            instance.CreaterName = userIdentity.Name;

            await workFlowHostService.StartUp(instance);
        }

        [HttpPost]
        public async Task Excute(WorkFlowExecution execute)
        {
            if (execute.InstanceId == default
                || execute.InstanceId == null
                || execute.GroupId == default
                || execute.GroupId == null
                || execute.StepId == default
                || execute.StepId == null
                || execute.FlowId == default
                || execute.FlowId == null
                || execute.TaskId == default
                || execute.TaskId == null)
            {
                throw new InvalidOperationException("流程参数有误");
            }

            //获取当前用户信息
            var userIdentity = this.UserIdentity;
            execute.CompanyId = userIdentity.CompanyId;
            execute.Sender = new WorkFlowUser
            {
                Id = userIdentity.Id,
                Name = userIdentity.Name,
                CompanyId = userIdentity.CompanyId
            };

            //处理步骤
            await workFlowHostService.Execute(execute);
        }

        [HttpPost]
        public async Task ExcuteSubmit(WorkFlowExecution execute)
        {
            execute.ExecuteType = WorkFlowExecuteKinds.Submit;
            await Excute(execute);
        }

        [HttpPost]
        public async Task ExcuteBack(WorkFlowExecution execute)
        {
            execute.ExecuteType = WorkFlowExecuteKinds.Back;
            await Excute(execute);
        }

        [HttpPost]
        public async Task ExcuteRedirect(WorkFlowExecution execute)
        {
            execute.ExecuteType = WorkFlowExecuteKinds.Redirect;
            await Excute(execute);
        }
    }
}