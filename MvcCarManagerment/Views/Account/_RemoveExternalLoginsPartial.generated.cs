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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/_RemoveExternalLoginsPartial.cshtml")]
    public partial class RemoveExternalLoginsPartial : System.Web.Mvc.WebViewPage<ICollection<MvcCarManagerment.Models.ExternalLogin>>
    {
        public RemoveExternalLoginsPartial()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
 if (Model.Count > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <h3>已注册外部登录</h3>\r\n");

WriteLiteral("    <table>\r\n        <tbody>\r\n");

            
            #line 8 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
         foreach (MvcCarManagerment.Models.ExternalLogin externalLogin in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 11 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
               Write(externalLogin.ProviderDisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>\r\n");

            
            #line 13 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                     if (ViewBag.ShowRemoveButton)
                    {
                        using (Html.BeginForm("Disassociate", "Account"))
                        {
                            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                                                    

            
            #line default
            #line hidden
WriteLiteral("                            <fieldset>\r\n");

WriteLiteral("                                ");

            
            #line 19 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                           Write(Html.Hidden("provider", externalLogin.Provider));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                                ");

            
            #line 20 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                           Write(Html.Hidden("providerUserId", externalLogin.ProviderUserId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"删除\"");

WriteAttribute("title", Tuple.Create(" title=\"", 844), Tuple.Create("\"", 899)
, Tuple.Create(Tuple.Create("", 852), Tuple.Create("从你的帐户中删除此", 852), true)
            
            #line 21 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
 , Tuple.Create(Tuple.Create(" ", 861), Tuple.Create<System.Object, System.Int32>(externalLogin.ProviderDisplayName
            
            #line default
            #line hidden
, 862), false)
, Tuple.Create(Tuple.Create(" ", 896), Tuple.Create("凭据", 897), true)
);

WriteLiteral(" />\r\n                            </fieldset>\r\n");

            
            #line 23 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                        }
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral(" &nbsp;\r\n");

            
            #line 28 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 31 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");

            
            #line 34 "..\..\Views\Account\_RemoveExternalLoginsPartial.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
