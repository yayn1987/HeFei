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

namespace MvcCarManagerment.Areas.Admin.Views.CarServiceManager
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/CarServiceManager/CreateType.cshtml")]
    public partial class CreateType : System.Web.Mvc.WebViewPage<MvcCarManagerment.Areas.Admin.Models.ServerListModel>
    {
        public CreateType()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
  
    ViewBag.Title = "创建类别";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>\r\n    创建服务类别</h2>\r\n");

            
            #line 8 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
 using (Html.BeginForm("CreateType", "CarServiceManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
                                 

            
            #line default
            #line hidden
WriteLiteral("    <table>\r\n        <tr>\r\n            <td");

WriteLiteral(" width=\"25%\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(" valign=\"middle\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
           Write(Html.LabelFor(entity => entity.ListName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 17 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
           Write(Html.TextBoxFor(entity => entity.ListName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span");

WriteLiteral(" style=\"color: Red;\"");

WriteLiteral(">*</span>\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
           Write(Html.ValidationMessageFor(entity => entity.ListName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td");

WriteLiteral(" width=\"25%\"");

WriteLiteral(" align=\"center\"");

WriteLiteral(" valign=\"middle\"");

WriteLiteral(">\r\n                图片路径\r\n            </td>\r\n            <td>\r\n                <in" +
"put");

WriteLiteral(" type=\"file\"");

WriteLiteral(" id=\"fileName\"");

WriteLiteral(" name=\"fileName\"");

WriteLiteral(" style=\"width: 300px;\"");

WriteLiteral(" />\r\n                &nbsp; <span");

WriteLiteral(" style=\"color: Red; line-height: 27px; height: 27px;\"");

WriteLiteral(">添加图片</span>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");

WriteLiteral("    <p>\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"保存\"");

WriteLiteral(" class=\"btn btn_edit_submit\"");

WriteLiteral(" />\r\n    </p>\r\n");

            
            #line 35 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"

}

            
            #line default
            #line hidden
WriteLiteral("<div>\r\n");

WriteLiteral("    ");

            
            #line 38 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
Write(Html.ActionLink("返回主界面", "IndexList"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 41 "..\..\Areas\Admin\Views\CarServiceManager\CreateType.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
