using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Models;
using Omu.ValueInjecter;
using System.IO;
using MvcCarManagerment.Extention;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class AboutManagerController : Controller
    {
        //
        // GET: /Admin/AboutManager/

        /// <summary>
        /// 关于我们展示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Logion", new { area = "" });
            }
            AboutUsModel model = new AboutUsModel();
            YuanChen.BLL.AboutUsTable method = new YuanChen.BLL.AboutUsTable();
            var info = method.GetTopList(1, "", " Time desc");
            if (info != null && info.Count > 0)
            {
                foreach (var item in info)
                {
                    model.InjectFrom(item);
                }

            }
            return View(model);
        }

        /// <summary>
        /// 编辑关于我们界面
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult EditAboutUs(Guid ID)
        {
            AboutUsModel model = new AboutUsModel();
            YuanChen.BLL.AboutUsTable method = new YuanChen.BLL.AboutUsTable();
            if (ID != Guid.Empty)
            {
                var info = method.GetModel(ID);
                if (info != null)
                {
                    model.InjectFrom(info);
                }

            }
            return View(model);

        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult EditAboutUs(AboutUsModel model, FormCollection fc)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                YuanChen.Model.AboutUsTable usinfo = new YuanChen.Model.AboutUsTable();
                usinfo.InjectFrom(model);
                usinfo.Time = DateTime.Now;
                YuanChen.BLL.AboutUsTable method = new YuanChen.BLL.AboutUsTable();
                bool bp = method.Exists(model.ID);
                if (bp)
                {
                    method.Update(usinfo);
                }
                else
                {
                    method.Add(usinfo);
                }
            }
            return RedirectToAction("Index");
        }

    }
}
