using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuanChen;
using Omu.ValueInjecter;
using MvcCarManagerment.Areas.Admin.BLL;
using MvcCarManagerment.Areas.Admin.Models;
using MvcCarManagerment.Models;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class NewsManagerController : Controller
    {
        private int PageSize = 6;
        private YuanChen.BLL.News NewsBll = new YuanChen.BLL.News();
        private NewsService service = new NewsService();
        //
        // GET: /Admin/NewsManager/

        public ActionResult Index(int page = 1)
        {
            //IList<YuanChen.Model.News> newsList = NewsBll.GetModelList("");
            //return View(newsList);
            NewsPage newsPage = service.News;
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

        public ActionResult Edit(string ID)
        {
            Guid guid = new Guid(ID);
            YuanChen.Model.News News = NewsBll.GetModel(guid);
            if (News == null)
            {
                return HttpNotFound();
            }
            ManagerModel model = new ManagerModel();
            model.InjectFrom(News);

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(ManagerModel model, FormCollection fc)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                YuanChen.Model.News newinfo = new YuanChen.Model.News();
                newinfo.InjectFrom(model);
                newinfo.Time = DateTime.Now;
                //newinfo.TypeID = new Guid("1fb3525a-2a2c-48fb-af67-849dd12da1bd");
                //保存到数据库News
                YuanChen.BLL.News method = new YuanChen.BLL.News();
                method.Update(newinfo);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 管理界面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(ManagerModel model, FormCollection fc)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                YuanChen.Model.News newinfo = new YuanChen.Model.News();
                newinfo.InjectFrom(model);
                newinfo.Time = DateTime.Now;
                newinfo.TypeID = new Guid("1fb3525a-2a2c-48fb-af67-849dd12da1bd");
                //保存到数据库News
                YuanChen.BLL.News method = new YuanChen.BLL.News();
                method.Add(newinfo);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Delete(string id)
        {
            NewsBll.Delete(new Guid(id));
            return RedirectToAction("Index");
        }

    }
}
