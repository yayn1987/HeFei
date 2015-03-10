using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Service;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Controllers
{
    public class CarServiceController : Controller
    {
        private int PageSize = 12;
        private int CarServiceDetailsPageSize = 4;
        private NewsService news = new NewsService();
        private CarService car = new CarService();

        //
        // GET: /CarService/

        public ActionResult Index(int page = 1)
        {
            //IEnumerable<YuanChen.Model.News> list = news.GetTopCarService(12);
            IEnumerable<YuanChen.Model.Server_List> list = car.GetServer_Info(0);
            ServerListListViewModel listModel = new ServerListListViewModel
            {
                ServiceListInfo = list.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = list.Count(),
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return View(listModel);
        }


        public ActionResult Detail(long id)
        {
            YuanChen.Model.News_info n = car.GetNewsinfo(id);
            return View(n);
        }

        /// <summary>
        /// 查看详细界面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult CarServiceDetails(string id, string parentid = "1743F8A1-F4C0-416D-B07F-56E6424907E7", int page = 1)
        {
            //YuanChen.BLL.News_info service = new YuanChen.BLL.News_info();
            //var re = service.GetType(id);
            //if (re != null)
            //{
            //    ViewData["type"] = re.ListName;
            //}
            //else
            //{
            //    ViewData["type"] = "";
            //}

            // var record = service.GetNewsService(id, parentid).ToList();
            //News_ServiceInfoListViewModel listmodel = new News_ServiceInfoListViewModel
            //{
            //    NewsServiceInfo = record.Skip((page - 1) * PageSize)
            //    .Take(PageSize),
            //    NewsInfo = new NewsInfo
            //    {
            //        ToalItems = record.Count,
            //        CurrentPage = page,
            //        ItemPerPage = PageSize
            //    }
            //};
            var record = car.GetNew_Info(id, 0);
            News_ServiceInfoListViewModel listmodel = new News_ServiceInfoListViewModel
            {
                NewsServiceInfo = record.Skip((page - 1) * CarServiceDetailsPageSize)
               .Take(CarServiceDetailsPageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = record.Count(),
                    CurrentPage = page,
                    ItemPerPage = CarServiceDetailsPageSize
                }
            };
            return View(listmodel);
            //return View();
        }

    }
}
