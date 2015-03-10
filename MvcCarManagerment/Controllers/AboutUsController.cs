using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Service;

namespace MvcCarManagerment.Controllers
{
    public class AboutUsController : Controller
    {
        //
        // GET: /AboutUs/

        private AboutService about = new AboutService();

        public ActionResult Index()
        {
            YuanChen.Model.AboutUsTable aboutUs = about.GetAboutUs();
            return View(aboutUs);
        }

    }
}
