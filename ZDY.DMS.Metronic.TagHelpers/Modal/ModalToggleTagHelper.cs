﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZDY.DMS.Metronic.TagHelpers.Modal
{
    [HtmlTargetElement(Attributes = ModalTargetAttributeName)]
    public class ModalToggleTagHelper : TagHelper
    {
        public const string ModalTargetAttributeName = "bs-toggle-modal";

        [HtmlAttributeName(ModalTargetAttributeName)]
        public string ToggleModal { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("data-toggle", "modal");
            output.Attributes.SetAttribute("data-target", $"#{ToggleModal}");
        }
    }
}
