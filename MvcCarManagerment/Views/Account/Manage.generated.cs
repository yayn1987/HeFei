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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Manage.cshtml")]
    public partial class Manage : System.Web.Mvc.WebViewPage<MvcCarManagerment.Models.LocalPasswordModel>
    {
        public Manage()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Account\Manage.cshtml"
  
    ViewBag.Title = "管理帐户";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<hgroup");

WriteLiteral(" class=\"title\"");

WriteLiteral(">\r\n    <h1>");

            
            #line 7 "..\..\Views\Account\Manage.cshtml"
   Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(".</h1>\r\n</hgroup>\r\n\r\n<p");

WriteLiteral(" class=\"message-success\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Account\Manage.cshtml"
                      Write(ViewBag.StatusMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n<p>你已使用 <strong>");

            
            #line 12 "..\..\Views\Account\Manage.cshtml"
           Write(User.Identity.Name);

            
            #line default
            #line hidden
WriteLiteral("</strong>. 身份登录。</p>\r\n\r\n");

            
            #line 14 "..\..\Views\Account\Manage.cshtml"
 if (ViewBag.HasLocalPassword)
{
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Manage.cshtml"
Write(Html.Partial("_ChangePasswordPartial"));

            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Account\Manage.cshtml"
                                           
}
else
{ 
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\Manage.cshtml"
Write(Html.Partial("_SetPasswordPartial"));

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Account\Manage.cshtml"
                                        
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<section");

WriteLiteral(" id=\"externalLogins\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 24 "..\..\Views\Account\Manage.cshtml"
Write(Html.Action("RemoveExternalLogins"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <h3>添加外部登录</h3>\r\n");

WriteLiteral("    ");

            
            #line 27 "..\..\Views\Account\Manage.cshtml"
Write(Html.Action("ExternalLoginsList", new { ReturnUrl = ViewBag.ReturnUrl }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</section>\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 31 "..\..\Views\Account\Manage.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
