using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCarManagerment.Controllers
{
    public class ManagerMentController : Controller
    {
        //
        // GET: /ManagerMent/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 管理界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Manager()
        {

            return View();
        }
    }
}
