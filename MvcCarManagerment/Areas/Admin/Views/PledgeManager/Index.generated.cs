﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18449
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCarManagerment.Areas.Admin.Views.PledgeManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using MvcCarManagerment.Areas.Admin.HTMLHelpers;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/PledgeManager/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<MvcCarManagerment.Areas.Admin.Models.NewsListViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2");

WriteLiteral(" class=\"page-title\"");

WriteLiteral(">车辆抵押</h2>\r\n<div");

WriteLiteral(" class=\"btn-toolbar\"");

WriteLiteral(">\r\n    <button");

WriteLiteral(" class=\"btn btn-primary\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 260), Tuple.Create("\"", 321)
, Tuple.Create(Tuple.Create("", 270), Tuple.Create("location.href=\'", 270), true)
            
            #line 8 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
, Tuple.Create(Tuple.Create("", 285), Tuple.Create<System.Object, System.Int32>(Url.Action("Add", "PledgeManager")
            
            #line default
            #line hidden
, 285), false)
, Tuple.Create(Tuple.Create("", 320), Tuple.Create("\'", 320), true)
);

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"icon-plus\"");

WriteLiteral("></i>添加车辆抵押\r\n    </button>\r\n</div>\r\n<div");

WriteLiteral(" class=\"well\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    车" +
"辆抵押标题\r\n                </th>\r\n                <th>\r\n                    发布日期\r\n  " +
"              </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");

            
            #line 25 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
             foreach (var item in Model.News)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 29 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 32 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
                   Write(item.Time.Value.ToString("yyyy年MM月dd日"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
                   Write(Html.ActionLink("编辑", "Edit", new { ID = item.ID }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 36 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
                   Write(Html.ActionLink("删除", "Delete", new { ID = item.ID }, new { onclick = "return confirm('请确认是否要删除这条信息?');" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 39 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 44 "..\..\Areas\Admin\Views\PledgeManager\Index.cshtml"
Write(Html.PageLinks(Model.NewsInfo, x => Url.Action("Index", new { page = x })));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
