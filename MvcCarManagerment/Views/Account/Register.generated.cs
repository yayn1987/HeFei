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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class Register : System.Web.Mvc.WebViewPage<MvcCarManagerment.Models.RegisterModel>
    {
        public Register()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Register.cshtml"
  
    ViewBag.Title = "注册";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>");

            
            #line 7 "..\..\Views\Account\Register.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n    <h2>创建新帐户。</h2>\r\n</hgroup>\r\n\r\n");

            
            #line 11 "..\..\Views\Account\Register.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Account\Register.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\Register.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\Register.cshtml"
                             


            
            #line default
            #line hidden
WriteLiteral("    <fieldset>\r\n        <legend>注册表单</legend>\r\n        <ol>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.UserName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 24 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.Password));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n            <li>\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </li>\r\n        </ol>\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"注册\"");

WriteLiteral(" />\r\n    </fieldset>\r\n");

            
            #line 33 "..\..\Views\Account\Register.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 36 "..\..\Views\Account\Register.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
