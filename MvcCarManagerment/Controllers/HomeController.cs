using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Models;

namespace MvcCarManagerment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexModel index = new IndexModel();
            return View(index);
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
