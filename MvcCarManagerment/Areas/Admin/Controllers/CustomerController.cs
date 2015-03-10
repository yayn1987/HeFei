using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Admin/Customer/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustormerIndex()
        {
            return View();
        }

        /// <summary>
        /// 查看客户详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CustomerDetail(long id)
        {
            YuanChen.BLL.CustomerService method = new YuanChen.BLL.CustomerService();
            var record = method.GetCustomerList(id);
            //todo
            return View();
        }

        /// <summary>
        /// 已阅客户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ReadCustomer(long id)
        {
            YuanChen.BLL.CustomerService method = new YuanChen.BLL.CustomerService();
            var record = method.GetModel(id);
            if (record != null)
            {
                record.IsRead = true;
                method.Update(record);
            }
            //todo
            return View();
        }
    }
}
