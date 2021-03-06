﻿using System;
using System.Linq;
using ZDY.DMS.Services.Shared.ServiceContracts;
using ZDY.DMS.Services.WorkFlowService.Core.Enums;
using ZDY.DMS.Services.WorkFlowService.Models;

namespace ZDY.DMS.Services.WorkFlowService.Core.Extensions
{
    public static class WorkFlowTaskExtensions
    {
        public static bool IsFirstStep(this WorkFlowTask task)
        {
            return task.StepId == WorkFlowConstant.StartStepId;
        }

        public static bool IsLastStep(this WorkFlowTask task)
        {
            return task.StepId == WorkFlowConstant.EndStepId;
        }

        public static bool IsStart(this WorkFlowTask task)
        {
            return task.StepId == WorkFlowConstant.StartStepId;
        }

        public static bool IsEnd(this WorkFlowTask task)
        {
            return task.StepId == WorkFlowConstant.EndStepId;
        }

        public static bool IsExecute(this WorkFlowTask task)
        {
            return ((WorkFlowTaskState)task.State).IsExecute();
        }

        public static bool IsNotExecute(this WorkFlowTask task)
        {
            return !task.IsExecute();
        }

        public static bool IsCopy(this WorkFlowTask task)
        {
            return task.Is(WorkFlowTaskKinds.Copy);
        }

        public static bool IsNotCopy(this WorkFlowTask task)
        {
            return !task.IsCopy();
        }

        public static bool Is(this WorkFlowTask task, params WorkFlowTaskKinds[] types)
        {
            return types.Contains((WorkFlowTaskKinds)task.Type);
        }

        public static bool IsNot(this WorkFlowTask task, params WorkFlowTaskKinds[] types)
        {
            return !types.Contains((WorkFlowTaskKinds)task.Type);
        }

        public static bool Is(this WorkFlowTask task, params WorkFlowTaskState[] state)
        {
            return state.Contains((WorkFlowTaskState)task.State);
        }

        public static bool IsNot(this WorkFlowTask task, params WorkFlowTaskState[] state)
        {
            return !state.Contains((WorkFlowTaskState)task.State);
        }

        private static bool IsExecute(this WorkFlowTaskState state)
        {
            return state == WorkFlowTaskState.Handled || state == WorkFlowTaskState.Returned || state == WorkFlowTaskState.HandledByOthers || state == WorkFlowTaskState.ReturnedByOthers;
        }

        private static bool IsNotExecute(this WorkFlowTaskState state)
        {
            return !state.IsExecute();
        }

        public static string GetTaskStateName(this WorkFlowTask task)
        {
            return ServiceLocator.GetService<IDictionaryService>().GetDictionaryName("WorkFlowTaskState", task.State.ToString());
        }
    }
}
