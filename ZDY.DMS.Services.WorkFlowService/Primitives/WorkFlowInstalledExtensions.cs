﻿using System;
using System.Collections.Generic;
using System.Linq;
using ZDY.DMS.Services.WorkFlowService.DataObjects;

namespace ZDY.DMS.Services.WorkFlowService
{
    public static class WorkFlowInstalledExtensions
    {
        public static WorkFlowStep GetStep(this WorkFlowDefinition workFlowInstalled, Guid stepId)
        {
            return workFlowInstalled.Steps.Find(t => t.StepId == stepId);
        }

        public static List<WorkFlowStep> GetPrevSteps(this WorkFlowDefinition workFlowInstalled, Guid stepId)
        {
            List<WorkFlowStep> stepList = new List<WorkFlowStep>();
            var transits = workFlowInstalled.Transits.FindAll(p => p.ToStepId == stepId);
            if (transits.Count() > 0)
            {
                var fromStepIdArray = transits.Select(t => t.FromStepId).ToArray();
                stepList = workFlowInstalled.Steps.Where(p => fromStepIdArray.Contains(p.StepId)).ToList();
            }
            return stepList;
        }

        public static List<WorkFlowStep> GetNextSteps(this WorkFlowDefinition workFlowInstalled, Guid stepId)
        {
            List<WorkFlowStep> stepList = new List<WorkFlowStep>();
            var transits = workFlowInstalled.Transits.Where(p => p.FromStepId == stepId);
            if (transits.Count() > 0)
            {
                var toStepIdArray = transits.Select(t => t.ToStepId).ToArray();
                stepList = workFlowInstalled.Steps.Where(p => toStepIdArray.Contains(p.StepId)).ToList();
            }
            return stepList;
        }

        public static WorkFlowStep GetFirstStep(this WorkFlowDefinition workFlowInstalled)
        {
            return workFlowInstalled.Steps.Find(t => t.StepId == WorkFlowConstant.StartStepId);
        }

        public static WorkFlowStep GetLastStep(this WorkFlowDefinition workFlowInstalled)
        {
            return workFlowInstalled.Steps.Find(t => t.StepId == WorkFlowConstant.EndStepId);
        }

        public static WrokFlowTransit GetTransit(this WorkFlowDefinition workFlowInstalled, Guid transitId)
        {
            return workFlowInstalled.Transits.Find(t => t.TransitId == transitId);
        }

        public static WrokFlowTransit GetTransit(this WorkFlowDefinition workFlowInstalled, Guid formStepId, Guid toStepId)
        {
            return workFlowInstalled.Transits.Find(t => t.FromStepId == formStepId && t.ToStepId == toStepId);
        }
    }
}