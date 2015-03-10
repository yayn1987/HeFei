using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Service;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/

        private int PageSize = 20;
        private NewsService news = new NewsService();

        public ActionResult Index(int page = 1)
        {
            NewsPage newsPage = news.News;
            NewsListViewModel listModel = new NewsListViewModel
            {
                News = newsPage.News.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = newsPage.Count,
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return View(listModel);
        }

        public ActionResult Detail(string id)
        {
            YuanChen.Model.News n = news.GetNewsByID(id);
            return View(n);
        }

    }
}
