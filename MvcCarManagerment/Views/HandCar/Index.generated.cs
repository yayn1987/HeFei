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

namespace MvcCarManagerment.Views.HandCar
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/HandCar/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<MvcCarManagerment.Areas.Admin.Models.NewsListViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\HandCar\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"yc_container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"yc_about_title\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 223), Tuple.Create("\"", 260)
, Tuple.Create(Tuple.Create("", 229), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/news_title.png")
, 229), false)
);

WriteLiteral("/>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"yc_about_content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"yc_about_content_nav\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"yc_about_content_home\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 426), Tuple.Create("\"", 457)
, Tuple.Create(Tuple.Create("", 432), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/home.png")
, 432), false)
);

WriteLiteral(" class=\"yc_about_home_img\"");

WriteLiteral(" /><i");

WriteLiteral(" class=\"yc_about_current\"");

WriteLiteral(">当前位置：</i>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 544), Tuple.Create("\"", 578)
            
            #line 15 "..\..\Views\HandCar\Index.cshtml"
, Tuple.Create(Tuple.Create("", 551), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","Home")
            
            #line default
            #line hidden
, 551), false)
);

WriteLiteral(">首页</a>\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 608), Tuple.Create("\"", 645)
, Tuple.Create(Tuple.Create("", 614), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/list_arrow.png")
, 614), false)
);

WriteLiteral(" />\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 669), Tuple.Create("\"", 702)
            
            #line 17 "..\..\Views\HandCar\Index.cshtml"
, Tuple.Create(Tuple.Create("", 676), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","Wed")
            
            #line default
            #line hidden
, 676), false)
);

WriteLiteral(">服务范围</a>\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 734), Tuple.Create("\"", 771)
, Tuple.Create(Tuple.Create("", 740), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/list_arrow.png")
, 740), false)
);

WriteLiteral(" />\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 795), Tuple.Create("\"", 832)
            
            #line 19 "..\..\Views\HandCar\Index.cshtml"
, Tuple.Create(Tuple.Create("", 802), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","HandCar")
            
            #line default
            #line hidden
, 802), false)
);

WriteLiteral(">二手车交易、评估</a>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"yc_news\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"yc_news_left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"yc_carorder_right_title\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 25 "..\..\Views\HandCar\Index.cshtml"
               Write(Html.ActionLink("二手车交易、评估","Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"yc_news_right_child\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"yc_carorder_right_2\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"i_nomal\"");

WriteLiteral(">></i><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1248), Tuple.Create("\"", 1286)
            
            #line 29 "..\..\Views\HandCar\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1255), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","CarOrder")
            
            #line default
            #line hidden
, 1255), false)
);

WriteLiteral(">车辆订购、按揭</a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"yc_carorder_right_2\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"i_nomal\"");

WriteLiteral(">></i><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1434), Tuple.Create("\"", 1470)
            
            #line 32 "..\..\Views\HandCar\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1441), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","Pledge")
            
            #line default
            #line hidden
, 1441), false)
);

WriteLiteral(">车辆抵押</a>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"yc_carorder_right_1\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"i_selected\"");

WriteLiteral(">></i>");

            
            #line 35 "..\..\Views\HandCar\Index.cshtml"
                                              Write(Html.ActionLink("二手车交易、评估","Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n       " +
"     <div");

WriteLiteral(" class=\"yc_news_right\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"yc_news_right_body\"");

WriteLiteral(">\r\n                    <ul>\r\n");

            
            #line 42 "..\..\Views\HandCar\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Views\HandCar\Index.cshtml"
                         foreach (var news in Model.News)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1997), Tuple.Create("\"", 2057)
            
            #line 45 "..\..\Views\HandCar\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2004), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", "HandCar", new {id = news.ID })
            
            #line default
            #line hidden
, 2004), false)
);

WriteLiteral(">\r\n                                    <i>");

            
            #line 46 "..\..\Views\HandCar\Index.cshtml"
                                  Write(news.Title);

            
            #line default
            #line hidden
WriteLiteral("</i>\r\n                                    <i");

WriteLiteral(" style=\"float:right;padding-right:20px;\"");

WriteLiteral(">");

            
            #line 47 "..\..\Views\HandCar\Index.cshtml"
                                                                          Write(news.Time.Value.ToString("yyyy年MM月dd日"));

            
            #line default
            #line hidden
WriteLiteral("</i>\r\n                                </a> \r\n                            </li>\r\n");

            
            #line 50 "..\..\Views\HandCar\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Views\HandCar\Index.cshtml"
               Write(Html.PageLinks(Model.NewsInfo, x => Url.Action("Index", new { page = x })));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"yc_about_clear\"");

WriteLiteral(">.</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
