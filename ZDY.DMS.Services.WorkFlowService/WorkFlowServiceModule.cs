﻿using System;
using System.Collections.Generic;
using System.Text;
using ZDY.DMS.AspNetCore.Dictionary;
using ZDY.DMS.AspNetCore.Module;
using ZDY.DMS.Services.WorkFlowService.Enums;

namespace ZDY.DMS.Services.WorkFlowService
{
    public class WorkFlowServiceModule: ServiceModule
    {
        public WorkFlowServiceModule(IDictionaryRegister dictionaryRegister)
            : base(dictionaryRegister)
        {

        }

        protected override void DictionaryInitializer()
        {
            this.DictionaryRegister.RegisterEnum<WorkFlowBackKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowBackTacticKinds>("WorkFlowBackTactic");
            this.DictionaryRegister.RegisterEnum<WorkFlowControlKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowCountersignatureTacticKinds>("WorkFlowCountersignatureTactic");
            this.DictionaryRegister.RegisterEnum<WorkFlowExecuteKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowFormKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowFormState>();
            this.DictionaryRegister.RegisterEnum<WorkFlowHandlerKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowHandleTacticKinds>("WorkFlowHandleTactic");
            this.DictionaryRegister.RegisterEnum<WorkFlowInstanceState>();
            this.DictionaryRegister.RegisterEnum<WorkFlowKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowSignatureKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowState>();
            this.DictionaryRegister.RegisterEnum<WorkFlowStepKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowSubFlowTacticKinds>("WorkFlowSubFlowTactic");
            this.DictionaryRegister.RegisterEnum<WorkFlowTaskKinds>();
            this.DictionaryRegister.RegisterEnum<WorkFlowTaskState>();
            this.DictionaryRegister.RegisterEnum<WorkFlowTransitConditionKinds>();
        }
    }
}