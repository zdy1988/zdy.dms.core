﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZDY.DMS.AspNetCore.Dictionary;
using ZDY.DMS.Services.Common.DataTransferObjects;
using ZDY.DMS.Services.Common.ServiceContracts;

namespace ZDY.DMS.Web.Pages.WorkFlow
{
    public class WorkFlowInstanceManagerModel : PageModel
    {
        private readonly IDictionaryService dictionaryService;
        private readonly SelectOptionsFactory selectOptionsFactory;

        public WorkFlowInstanceManagerModel(IDictionaryService dictionaryService,
            SelectOptionsFactory selectOptionsFactory)
        {
            this.dictionaryService = dictionaryService;
            this.selectOptionsFactory = selectOptionsFactory;
        }

        public Dictionary<string, IEnumerable<KeyValuePaired>> Dictionary { get; set; }

        public IEnumerable<KeyValuePair<string, string>> WorkFlowInstanceState { get; set; }

        public void OnGet()
        {
            Dictionary = dictionaryService.GetDictionary("WorkFlowInstanceState");

            WorkFlowInstanceState = this.selectOptionsFactory.GetSelectOptionsByDictionary("WorkFlowInstanceState");
        }
    }
}