using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Omu.ValueInjecter;
using System.Web.Mvc;
using MvcCarManagerment.Models;

namespace MvcCarManagerment.Controllers
{
    public class CustomerController : Controller
    {
        YuanChen.BLL.CustomerService method = new YuanChen.BLL.CustomerService();
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            CustomerModel model = new CustomerModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                YuanChen.Model.CustomerService info = new YuanChen.Model.CustomerService();
                info.InjectFrom(model);
                info.Time = DateTime.Now;
                var lo = method.Add(info);
                if (lo != 0)
                {
                    ViewData["msg"] = "增加成功！";
                }
                else
                {
                    ViewData["msg"] = "增加失败！";
                }
            }
            return View(model);
            //return RedirectToAction("Index", "Home");
        }
    }
}
