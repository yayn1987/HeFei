using System;
using System.Collections.Generic;
using System.Linq;
using Omu.ValueInjecter;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Models;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class CustomerManagerController : Controller
    {
        YuanChen.BLL.CustomerService method = new YuanChen.BLL.CustomerService();
        //
        // GET: /Admin/CustomerManager/

        public ActionResult Index()
        {
            List<CustomerModel> result = new List<CustomerModel>();
            var record = method.GetCustomerList();
            if (record != null && record.Count > 0)
            {
                foreach (var item in record)
                {
                    CustomerModel model = new CustomerModel();
                    model.InjectFrom(item);
                    result.Add(model);
                }
            }
            return View(result);
        }

        /// <summary>
        /// 客户服务查看界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(long id)
        {
            CustomerModel model = new CustomerModel();
            var record = method.GetModel(id);
            if (record != null)
            {
                record.IsRead = true;
                method.Update(record);
                model.InjectFrom(record);
            }
            return View(model);
        }

        /// <summary>
        /// 删除客户服务
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(long id)
        {
            method.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
