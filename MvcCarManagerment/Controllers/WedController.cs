using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Service;
using MvcCarManagerment.Models;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Controllers
{
    public class WedController : Controller
    {
        //
        // GET: /Wed/
        private int PageSize = 4;
        private WedService news = new WedService();

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
            WedModel wed = new WedModel { Wed = n };
            return View(wed);
        }

    }
}
