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

namespace MvcCarManagerment.Views.CarService
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CarService/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<MvcCarManagerment.Areas.Admin.Models.ServerListListViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\CarService\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"yc_container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"yc_about_title\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 227), Tuple.Create("\"", 263)
, Tuple.Create(Tuple.Create("", 233), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/carserver.png")
, 233), false)
);

WriteLiteral(" />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"yc_about_content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"yc_about_content_nav\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"yc_about_content_home\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 430), Tuple.Create("\"", 461)
, Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/home.png")
, 436), false)
);

WriteLiteral(" class=\"yc_about_home_img\"");

WriteLiteral(" /><i");

WriteLiteral(" class=\"yc_about_current\"");

WriteLiteral(">当前位置：</i>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 548), Tuple.Create("\"", 583)
            
            #line 14 "..\..\Views\CarService\Index.cshtml"
, Tuple.Create(Tuple.Create("", 555), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Home")
            
            #line default
            #line hidden
, 555), false)
);

WriteLiteral(">首页</a>\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 613), Tuple.Create("\"", 650)
, Tuple.Create(Tuple.Create("", 619), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/list_arrow.png")
, 619), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 16 "..\..\Views\CarService\Index.cshtml"
           Write(Html.ActionLink("服务范围", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 727), Tuple.Create("\"", 764)
, Tuple.Create(Tuple.Create("", 733), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/list_arrow.png")
, 733), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\CarService\Index.cshtml"
           Write(Html.ActionLink("高端汽车服务", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"yc_news\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"yc_news_left yc_pledge_left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"yc_news_right_title\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 24 "..\..\Views\CarService\Index.cshtml"
               Write(Html.ActionLink("高端汽车服务", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"yc_news_right_child\"");

WriteLiteral(">\r\n");

            
            #line 27 "..\..\Views\CarService\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\CarService\Index.cshtml"
                     foreach (var item in Model.ServiceListInfo)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"yc_news_right_2\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"i_nomal\"");

WriteLiteral(">></i><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1326), Tuple.Create("\"", 1405)
            
            #line 30 "..\..\Views\CarService\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1333), Tuple.Create<System.Object, System.Int32>(Url.Action("CarServiceDetails", "CarService", new { id = item.ListID })
            
            #line default
            #line hidden
, 1333), false)
);

WriteLiteral(">");

            
            #line 30 "..\..\Views\CarService\Index.cshtml"
                                                                                                                                  Write(item.ListName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n");

            
            #line 32 "..\..\Views\CarService\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"yc_news_right yc_pledge_right\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"yc_car_right_body\"");

WriteLiteral(">\r\n                    <ul>\r\n");

            
            #line 38 "..\..\Views\CarService\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\CarService\Index.cshtml"
                         foreach (var news in Model.ServiceListInfo)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <div");

WriteLiteral(" class=\"yc_wed_container\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"yc_car_body\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"yc_wed_img\"");

WriteLiteral(">\r\n");

            
            #line 44 "..\..\Views\CarService\Index.cshtml"
                                            
            
            #line default
            #line hidden
            
            #line 44 "..\..\Views\CarService\Index.cshtml"
                                             if (!string.IsNullOrEmpty(news.ImageUrl))
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2167), Tuple.Create("\"", 2232)
            
            #line 46 "..\..\Views\CarService\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(Url.Action("CarServiceDetails", new { id = news.ListID })
            
            #line default
            #line hidden
, 2174), false)
);

WriteLiteral(">\r\n                                                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2292), Tuple.Create("\"", 2325)
            
            #line 47 "..\..\Views\CarService\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2298), Tuple.Create<System.Object, System.Int32>(Url.Content(news.ImageUrl)
            
            #line default
            #line hidden
, 2298), false)
);

WriteLiteral(" style=\"width:178px;height:138px;\"");

WriteLiteral(" /></a>\r\n");

            
            #line 48 "..\..\Views\CarService\Index.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a>此处无图片</a> \r\n");

            
            #line 52 "..\..\Views\CarService\Index.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </div>\r\n                                 " +
"       <div");

WriteLiteral(" class=\"yc_wed_content\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"yc_car_content_title\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 56 "..\..\Views\CarService\Index.cshtml"
                                           Write(Html.ActionLink(news.ListName, "CarServiceDetails", new { id = news.ListID }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"             </div>\r\n                                    </div>\r\n               " +
"                 </div>\r\n                            </li>\r\n");

            
            #line 62 "..\..\Views\CarService\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"yc_about_clear\"");

WriteLiteral(">\r\n                    .</div>\r\n                <div");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 68 "..\..\Views\CarService\Index.cshtml"
               Write(Html.PageLinks(Model.NewsInfo, x => Url.Action("Index", new { page = x })));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r" +
"\n");

        }
    }
}
#pragma warning restore 1591
