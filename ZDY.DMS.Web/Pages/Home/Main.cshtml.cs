﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZDY.DMS.AspNetCore.Auth;
using ZDY.DMS.Services.AdminService.DataTransferObjects;
using ZDY.DMS.Services.AdminService.ServiceContracts;
using ZDY.DMS.Services.PermissionService.ServiceContracts;
using ZDY.Metronic.UI;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace ZDY.DMS.Web.Pages.Home
{
    public class MainModel : PageModel
    {
        private readonly IPageService pageService;
        private readonly IPagePermissionService pagePermissionService;
        private readonly IMetronic metronic;

        public MainModel(IPageService pageService,
            IPagePermissionService pagePermissionService,
            IMetronic metronic)
        {
            this.pageService = pageService;
            this.pagePermissionService = pagePermissionService;

            this.metronic = metronic;
        }

        public IEnumerable<MultiLevelPageDTO> Pages { get; set; }

        public async Task OnGetAsync()
        {
            var identity = this.HttpContext.GetUserIdentity();

            if (identity.IsAdministrator)
            {
                Pages = await this.pageService.GetMultiLevelPagesAsync();
            }
            else
            {
                var pagePermissions = await this.pagePermissionService.GetUserPagePermissionAsync(identity.Id);

                Pages = await this.pageService.GetMultiLevelPagesAsync(pagePermissions, identity.CompanyId);
            }
        }

        public TagBuilder RenderMenu(IEnumerable<MultiLevelPageDTO> pages, bool isSubMenu = false)
        {
            var menu = new TagBuilder("div");

            if (!isSubMenu)
            {
                menu.AddCssClass("kt-aside-menu");
                menu.Attributes.Add("id", "kt_aside_menu");
                menu.Attributes.Add("data-ktmenu-vertical", "1");
                menu.Attributes.Add("data-ktmenu-scroll", "1");
                menu.Attributes.Add("data-ktmenu-dropdown-timeout", "500");
            }
            else
            {
                menu.AddCssClass("kt-menu__submenu");

                menu.InnerHtml.AppendHtml("<span class='kt-menu__arrow'></span>");
            }

            var nav = new TagBuilder("ul");

            if (!isSubMenu)
            {
                nav.AddCssClass("kt-menu__nav");
            }
            else
            {
                nav.AddCssClass("kt-menu__subnav");
            }

            foreach (var page in pages)
            {
                var item = new TagBuilder("li");

                if (!page.IsInMenu)
                {
                    item.AddCssClass("kt-hidden");
                }

                //if (page.IsSection)
                //{
                //    item.AddCssClass("kt-menu__section");

                //    item.InnerHtml.AppendHtml($"<h4 class='kt-menu__section-text'>{page.MenuName}</h4>");
                //}
                //else
                //{
                var isBuildSubMenu = page.ChildLevelPages != null && page.ChildLevelPages.Any();

                item.AddCssClass("kt-menu__item");

                if (isBuildSubMenu)
                {
                    item.AddCssClass("kt-menu__item--submenu");
                }

                var link = new TagBuilder("a");

                link.AddCssClass("kt-menu__link");

                link.Attributes.Add("id", page.Id.ToString());

                if (isSubMenu)
                {
                    var bulletClass = isBuildSubMenu ? "kt-menu__link-bullet--line" : "kt-menu__link-bullet--dot";

                    link.InnerHtml.AppendHtml($"<i class='kt-menu__link-bullet {bulletClass}'><span></span></i>");
                }
                else
                {
                    if (Enum.TryParse<SvgIcon>(page.Icon, out SvgIcon icon))
                    {
                        var iconContent = metronic.GetIconContent(icon);

                        link.InnerHtml.AppendHtml($"<span class='kt-menu__link-icon'>{iconContent}</span>");
                    }
                }

                link.InnerHtml.AppendHtml($"<span class='kt-menu__link-text'>{page.MenuName}</span>");

                if (isBuildSubMenu)
                {
                    link.Attributes.Add("href", "javascript:;");

                    link.AddCssClass("kt-menu__toggle");

                    link.InnerHtml.AppendHtml("<i class='kt-menu__ver-arrow la la-angle-right'></i>");

                    item.InnerHtml.AppendHtml(link);

                    item.InnerHtml.AppendHtml(RenderMenu(page.ChildLevelPages, true));
                }
                else
                {
                    var data = new
                    {
                        PageId = page.Id,
                        PageSrc = $"/{page.Src}",
                        MenuName = page.MenuName
                    };

                    link.Attributes.Add("data-page", JsonConvert.SerializeObject(data));

                    link.Attributes.Add("href", $"/{page.Src}");

                    item.InnerHtml.AppendHtml(link);
                }
                //}

                nav.InnerHtml.AppendHtml(item);
            }

            menu.InnerHtml.AppendHtml(nav);

            return menu;
        }
    }
}