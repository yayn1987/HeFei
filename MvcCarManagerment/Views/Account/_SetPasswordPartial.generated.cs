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

namespace MvcCarManagerment.Views.Account
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_SetPasswordPartial.cshtml")]
    public partial class SetPasswordPartial : System.Web.Mvc.WebViewPage<MvcCarManagerment.Models.LocalPasswordModel>
    {
        public SetPasswordPartial()
        {
        }
        public override void Execute()
        {
WriteLiteral("<p>\r\n    你没有此站点的本地密码。请添加一个本地\r\n                密码，这样，无需外部登录便可以登录了。\r\n</p>\r\n\r\n");

            
            #line 8 "..\..\Views\Account\_SetPasswordPartial.cshtml"
 using (Html.BeginForm("Manage", "Account")) {
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Account\_SetPasswordPartial.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Account\_SetPasswordPartial.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Account\_SetPasswordPartial.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Account\_SetPasswordPartial.cshtml"
                             


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>“设置密码”表单</legend>\r\n        <ol>\r\n            <li>" +
"\r\n");

WriteLiteral("                ");

            
            #line 16 "..\..\Views\Account\_SetPasswordPartial.cshtml"
           Write(Html.LabelFor(m => m.NewPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 17 "..\..\Views\Account\_SetPasswordPartial.cshtml"
           Write(Html.PasswordFor(m => m.NewPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Account\_SetPasswordPartial.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Account\_SetPasswordPartial.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"设置密码\"");

WriteLiteral(" />\r\n    </fieldset>\r\n");

            
            #line 26 "..\..\Views\Account\_SetPasswordPartial.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
