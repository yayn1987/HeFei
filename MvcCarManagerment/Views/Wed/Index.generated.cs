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

namespace MvcCarManagerment.Views.Wed
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Wed/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<MvcCarManagerment.Areas.Admin.Models.NewsListViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Wed\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutWed.cshtml";
    var list = Model.News.ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"yc_container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"yc_about_title\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 263), Tuple.Create("\"", 297)
, Tuple.Create(Tuple.Create("", 269), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/title_w.png")
, 269), false)
);

WriteLiteral("/>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"yc_about_content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"yc_about_content_nav\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"yc_about_content_home\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 463), Tuple.Create("\"", 494)
, Tuple.Create(Tuple.Create("", 469), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/home.png")
, 469), false)
);

WriteLiteral(" class=\"yc_about_home_img\"");

WriteLiteral(" /><i");

WriteLiteral(" class=\"yc_about_current\"");

WriteLiteral(">当前位置：</i>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 581), Tuple.Create("\"", 615)
            
            #line 16 "..\..\Views\Wed\Index.cshtml"
, Tuple.Create(Tuple.Create("", 588), Tuple.Create<System.Object, System.Int32>(Url.Action("Index","Home")
            
            #line default
            #line hidden
, 588), false)
);

WriteLiteral(">首页</a>\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 645), Tuple.Create("\"", 682)
, Tuple.Create(Tuple.Create("", 651), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/list_arrow.png")
, 651), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\Wed\Index.cshtml"
           Write(Html.ActionLink("服务范围","Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 758), Tuple.Create("\"", 795)
, Tuple.Create(Tuple.Create("", 764), Tuple.Create<System.Object, System.Int32>(Href("~/Content/images/list_arrow.png")
, 764), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Wed\Index.cshtml"
           Write(Html.ActionLink("高端婚庆策划","Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"yc_news\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"yc_news_left yc_wed_left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"yc_news_right_title\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Wed\Index.cshtml"
               Write(Html.ActionLink("高端婚庆策划","Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"yc_news_right_child\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Wed\Index.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Wed\Index.cshtml"
                     foreach (var item in Model.News)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"yc_news_right_2\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"i_nomal\"");

WriteLiteral(">></i><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1341), Tuple.Create("\"", 1397)
            
            #line 32 "..\..\Views\Wed\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", "Wed", new { id = item.ID})
            
            #line default
            #line hidden
, 1348), false)
);

WriteLiteral(">");

            
            #line 32 "..\..\Views\Wed\Index.cshtml"
                                                                                                           Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n");

            
            #line 34 "..\..\Views\Wed\Index.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"yc_news_right yc_wed_right\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"yc_news_right_body\"");

WriteLiteral(">\r\n                    <ul>\r\n");

            
            #line 40 "..\..\Views\Wed\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Wed\Index.cshtml"
                         for (var i = 0; i < list.Count;i++)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <div");

WriteLiteral(" class=\"yc_wed_container\"");

WriteLiteral(">\r\n                                    <div");

WriteLiteral(" class=\"yc_wed_body\"");

WriteLiteral(">\r\n                                        <div");

WriteLiteral(" class=\"yc_wed_img\"");

WriteLiteral(">\r\n                                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2007), Tuple.Create("\"", 2037)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create("/Wed/Detail/", 2014), true)
            
            #line 46 "..\..\Views\Wed\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create<System.Object, System.Int32>(list[i].ID
            
            #line default
            #line hidden
, 2026), false)
);

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 2043), Tuple.Create("\"", 2079)
            
            #line 46 "..\..\Views\Wed\Index.cshtml"
        , Tuple.Create(Tuple.Create("", 2049), Tuple.Create<System.Object, System.Int32>(Url.Content(list[i].ImageUrl)
            
            #line default
            #line hidden
, 2049), false)
);

WriteLiteral(" style=\"width:274px;height:190px;\"");

WriteLiteral(" /></a>\r\n                                        </div>\r\n                        " +
"                <div");

WriteLiteral(" class=\"yc_wed_content\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"yc_wed_content_title\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 50 "..\..\Views\Wed\Index.cshtml"
                                           Write(Html.ActionLink(list[i].Title, "Detail", new { id = list[i].ID, @class = "yc_wed_content_title" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                \r\n                             " +
"               </div>\r\n                                            <div");

WriteLiteral(" class=\"yc_wed_content_body\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 54 "..\..\Views\Wed\Index.cshtml"
                                           Write(Html.DisplayTextFor(entiy => list[i].NewsComment));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"                 <div");

WriteLiteral(" class=\"yc_wed_content_detail\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 57 "..\..\Views\Wed\Index.cshtml"
                                           Write(Html.ActionLink(">> 点击查看套餐详细", "Detail", new { id = list[i].ID,@class="yc_wed_detail_link"}));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </div>\r\n                           " +
"             </div>\r\n                                    </div>\r\n               " +
"                 </div>\r\n                            </li>\r\n");

            
            #line 63 "..\..\Views\Wed\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 68 "..\..\Views\Wed\Index.cshtml"
               Write(Html.PageLinks(Model.NewsInfo, x => Url.Action("Index", new { page = x })));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"yc_about_clear\"");

WriteLiteral(">.</div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
