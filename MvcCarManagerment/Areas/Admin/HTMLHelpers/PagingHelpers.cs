using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.HTMLHelpers
{
    public static class PagingHelper
    {
        /// <summary>
        /// 生成分页的扩展工具
        /// </summary>
        /// <param name="newsInfo"></param>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        public static MvcHtmlString PageLinks(this HtmlHelper html,
            NewsInfo newsInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            result.Append("<ul>").Append(AppendPrev(newsInfo,pageUrl));
            for (int i = 1; i <= newsInfo.ToalPages; i++)
            {
                result.Append("<li>");
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == newsInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                }
                result.Append(tag.ToString()).Append("</li>");
            }
            result.Append(AppendNext(newsInfo,pageUrl)).Append("</ul>");
            return MvcHtmlString.Create(result.ToString());
        }

        private static string AppendPrev(NewsInfo info, Func<int, string> pageUrl)
        {
            return FirstPage(info, pageUrl) + PrevPage(info, pageUrl);
        }

        private static string AppendNext(NewsInfo info, Func<int, string> pageUrl)
        {
            return NextPage(info, pageUrl) + LastPage(info,pageUrl);
        }

        private static string FirstPage(NewsInfo info, Func<int, string> pageUrl)
        {
            StringBuilder prev = new StringBuilder();
            prev.Append("<li>");
            TagBuilder tag = new TagBuilder("a");
            tag.MergeAttribute("href",pageUrl(1));
            tag.InnerHtml = "首页";
            return prev.Append(tag.ToString()).Append("</li>").ToString();
        }

        private static string LastPage(NewsInfo info, Func<int, string> pageUrl)
        {
            StringBuilder prev = new StringBuilder();
            prev.Append("<li>");
            TagBuilder tag = new TagBuilder("a");
            tag.MergeAttribute("href", pageUrl(info.ToalPages));
            tag.InnerHtml = "末页";
            return prev.Append(tag.ToString()).Append("</li>").ToString();
        }

        private static string PrevPage(NewsInfo info,Func<int, string> pageUrl)
        {
            StringBuilder prev = new StringBuilder();
            prev.Append("<li>");
            TagBuilder tag = new TagBuilder("a");
            if (info.CurrentPage == 1)
            {
                tag.MergeAttribute("href", pageUrl(1));
            }
            else
            {
                tag.MergeAttribute("href", pageUrl(info.CurrentPage - 1));
            }
            tag.InnerHtml = "上一页";
            return prev.Append(tag.ToString()).Append("</li>").ToString();
        }

        private static string NextPage(NewsInfo info, Func<int, string> pageUrl)
        {
            StringBuilder prev = new StringBuilder();
            prev.Append("<li>");
            TagBuilder tag = new TagBuilder("a");
            if (info.CurrentPage == info.ToalPages)
            {
                tag.MergeAttribute("href", pageUrl(info.ToalPages));
            }
            else
            {
                tag.MergeAttribute("href", pageUrl(info.CurrentPage + 1));
            }
            tag.InnerHtml = "下一页";
            return prev.Append(tag.ToString()).Append("</li>").ToString();
        }
    }
}