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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Login.cshtml")]
    public partial class Login : System.Web.Mvc.WebViewPage<MvcCarManagerment.Models.LoginModel>
    {
        public Login()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\Login.cshtml"
  
    ViewBag.Title = "登录";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>");

            
            #line 8 "..\..\Views\Account\Login.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n</hgroup>\r\n\r\n<section");

WriteLiteral(" id=\"loginForm\"");

WriteLiteral(">\r\n<h2>使用本地帐户登录。</h2>\r\n");

            
            #line 13 "..\..\Views\Account\Login.cshtml"
 using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl })) {
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Account\Login.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Account\Login.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Login.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Account\Login.cshtml"
                                 


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>“登录”表单</legend>\r\n        <ol>\r\n            <li>\r\n" +
"");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Account\Login.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Views\Account\Login.cshtml"
           Write(Html.CheckBoxFor(m => m.RememberMe));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.RememberMe, new { @class = "checkbox" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"登录\"");

WriteLiteral(" />\r\n    </fieldset>\r\n");

WriteLiteral("    <p>\r\n");

WriteLiteral("        ");

            
            #line 38 "..\..\Views\Account\Login.cshtml"
   Write(Html.ActionLink("Register", "Register"));

            
            #line default
            #line hidden
WriteLiteral(" (如果你没有帐户)。\r\n    </p>\r\n");

            
            #line 40 "..\..\Views\Account\Login.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</section>\r\n\r\n<section");

WriteLiteral(" class=\"social\"");

WriteLiteral(" id=\"socialLoginForm\"");

WriteLiteral(">\r\n    <h2>使用其他服务登录。</h2>\r\n");

WriteLiteral("    ");

            
            #line 45 "..\..\Views\Account\Login.cshtml"
Write(Html.Action("ExternalLoginsList", new { ReturnUrl = ViewBag.ReturnUrl }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</section>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 49 "..\..\Views\Account\Login.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
