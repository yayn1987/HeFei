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

namespace MvcCarManagerment.Areas.Admin.Views.BusinessManager
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
    
    #line 2 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
    using MvcCarManagerment.Service;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/BusinessManager/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<MvcCarManagerment.Models.ManagerModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
  
    ViewBag.Title = "后台信息发布";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>\r\n    添加商务礼仪</h2>\r\n");

            
            #line 9 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
 using (Html.BeginForm("Edit", "BusinessManager", FormMethod.Post, new { enctype = "multipart/form-data" }))
{  
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Html.HiddenFor(entity => entity.ID));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
                                        
    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Html.HiddenFor(entity => entity.TypeID));

            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
                                            
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Html.HiddenFor(entity => entity.ImageUrl));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
                                              ;

            
            #line default
            #line hidden
WriteLiteral("    <table>\r\n        <tr>\r\n            <td");

WriteLiteral(" width=\"15%\"");

WriteLiteral(" valign=\"middle\"");

WriteLiteral(">\r\n                文章标题 <span");

WriteLiteral(" style=\"color: Red; margin: 0,0,-10px,0;\"");

WriteLiteral(">*</span>\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
           Write(Html.TextBoxFor(entity => entity.Title, new { @class = "acticle_header" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
           Write(Html.ValidationMessageFor(entity => entity.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td");

WriteLiteral(" width=\"15%\"");

WriteLiteral(" valign=\"middle\"");

WriteLiteral(">\r\n                图片路径\r\n            </td>\r\n            <td>\r\n                <in" +
"put");

WriteLiteral(" type=\"file\"");

WriteLiteral(" id=\"fileName\"");

WriteLiteral(" name=\"fileName\"");

WriteLiteral(" style=\"width: 300px;\"");

WriteLiteral(" />\r\n                &nbsp; <span");

WriteLiteral(" style=\"color: Red; line-height: 27px; height: 27px;\"");

WriteLiteral(">添加商务礼仪封面图片</span>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");

            
            #line 35 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
  
    
            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Html.TextAreaFor(entity => entity.NewsComment));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
                                                   
      
        

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"btn_edit\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" class=\"btn btn_edit_submit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"保存\"");

WriteLiteral(" id=\"save\"");

WriteLiteral(" />\r\n");

WriteLiteral("        ");

            
            #line 41 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
   Write(Html.ActionLink("返回", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 43 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
}

            
            #line default
            #line hidden
DefineSection("scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 45 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Scripts.Render("~/Areas/Admin/Scripts/ueditor/ueditor.all.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 46 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Scripts.Render("~/Areas/Admin/Scripts/ueditor/ueditor.all.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 47 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Scripts.Render("~/Areas/Admin/Scripts/ueditor/ueditor.config.js"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 48 "..\..\Areas\Admin\Views\BusinessManager\Edit.cshtml"
Write(Styles.Render("~/Areas/Admin/Scripts/ueditor/themes/iframe.css"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

        $(function () {
            var editor = new baidu.editor.ui.Editor({
                UEDITOR_HOME_URL: '/Areas/Admin/Scripts/ueditor/', //配置编辑器路径
                iframeCssUrl: '/Areas/Admin/Scripts/ueditor/themes/iframe.css', //样式路径
                initialContent: '', //初始化编辑器内容
                autoHeightEnabled: false, //高度自动增长
                minFrameHeight: 500, //最小高度
                initialFrameHeight: 380//初始化编辑器高度
            });
            editor.render('NewsComment');
        });

    </script>
");

});

        }
    }
}
#pragma warning restore 1591
