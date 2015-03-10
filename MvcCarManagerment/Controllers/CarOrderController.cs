using MvcCarManagerment.Areas.Admin.Models;
using MvcCarManagerment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCarManagerment.Controllers
{
    public class CarOrderController : Controller
    {
        //
        // GET: /CarOrder/
        private int PageSize = 20;
        private CarOrderService news = new CarOrderService();

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
