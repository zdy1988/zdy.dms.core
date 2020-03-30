﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZDY.DMS.Services.Common.DataTransferObjects;
using ZDY.DMS.Services.Common.ServiceContracts;

namespace ZDY.DMS.Web.Pages.WorkFlow
{
    public class WorkFlowTaskExecutedModel : PageModel
    {
        private readonly IDictionaryService dictionaryService;

        public WorkFlowTaskExecutedModel(IDictionaryService dictionaryService)
        {
            this.dictionaryService = dictionaryService;
        }

        public Dictionary<string, IEnumerable<DictionaryItemDTO>> Dictionary { get; set; }

        public IEnumerable<KeyValuePair<string, string>> WorkFlowTaskState { get; set; }

        public void OnGet()
        {
            Dictionary = this.dictionaryService.GetDictionary("WorkFlowTaskState");

            WorkFlowTaskState = Dictionary["WorkFlowTaskState"].Select(t => new KeyValuePair<string, string>(t.Value, t.Name));
        }
    }
}