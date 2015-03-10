using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Areas.Admin.BLL;
using MvcCarManagerment.Areas.Admin.Common;
using MvcCarManagerment.Areas.Admin.Models;
using MvcCarManagerment.Models;
using Omu.ValueInjecter;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class CarOrderManagerController : Controller
    {

        private int PageSize = 6;
        private YuanChen.BLL.News NewsBll = new YuanChen.BLL.News();
        private CarOrderService service = new CarOrderService();

        //
        // GET: /Admin/CarOrderManager/
        /// <summary>
        ///  车辆订购、按揭
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult Index(int page = 1)
        {
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

        /// <summary>
        /// 追加车辆订购、按揭
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }


        /// <summary>
        /// 车辆订购、按揭管理界面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(ManagerModel model, FormCollection fc)
        {
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                HttpPostedFileBase httpPostedFile = Request.Files["fileName"];
                string fileName = httpPostedFile.FileName;
                if (!String.IsNullOrEmpty(fileName))
                {
                    if (fileName.LastIndexOf("\\") > -1)
                    {
                        fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                    }
                    string name = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + fileName;       //获取文件名
                    string type = name.Substring(name.LastIndexOf(".") + 1);    //获取文件类型
                    var path = System.Configuration.ConfigurationManager.AppSettings["uploadpath"];
                    var strurl = Server.MapPath(path);
                    var ipath = Path.Combine(strurl, "s-" + name);//获取文件路径
                    var wpath = path + name;//相对路径
                    var spath = path + "s-" + name;//相对路径(缩略图)
                    model.ImageUrl = spath;//图片的相对路径
                    PicHandle.ResizeImage(httpPostedFile, ipath, 236, 150);
                }
                else
                {
                    string defaultname = "default.png";
                    string name = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + defaultname;       //获取文件名
                    var path = System.Configuration.ConfigurationManager.AppSettings["uploadpath"];
                    var strurl = Server.MapPath(path);
                    var imagepath = path + defaultname;//获取原图片相对路径
                    var ipath = Path.Combine(strurl, "s-" + name);//获取文件路径
                    var spath = path + "s-" + name;//相对路径(缩略图)
                    model.ImageUrl = spath;//图片的相对路径
                    ReducePic.ReducePicture(imagepath, spath, 236);
                }
                YuanChen.Model.News newinfo = new YuanChen.Model.News();
                newinfo.InjectFrom(model);
                newinfo.Time = DateTime.Now;
                newinfo.TypeID = new Guid("129D7619-5F5C-4276-81BB-2A9E52CC6672");
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

        /// <summary>
        /// 车辆订购、按揭编辑
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
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
                HttpPostedFileBase httpPostedFile = Request.Files["fileName"];
                string fileName = httpPostedFile.FileName;
                if (!String.IsNullOrEmpty(fileName))
                {
                    if (fileName.LastIndexOf("\\") > -1)
                    {
                        fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                    }
                    string name = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + fileName;       //获取文件名
                    string type = name.Substring(name.LastIndexOf(".") + 1);    //获取文件类型
                    var path = System.Configuration.ConfigurationManager.AppSettings["uploadpath"];
                    var strurl = Server.MapPath(path);
                    var ipath = Path.Combine(strurl, "s-" + name);//获取文件路径
                    var wpath = path + name;//相对路径
                    var spath = path + "s-" + name;//相对路径(缩略图)
                    model.ImageUrl = spath;//图片的相对路径
                    PicHandle.ResizeImage(httpPostedFile, ipath, 236, 150);
                }
                YuanChen.Model.News newinfo = new YuanChen.Model.News();
                newinfo.InjectFrom(model);
                newinfo.Time = DateTime.Now;
                //保存到数据库News
                YuanChen.BLL.News method = new YuanChen.BLL.News();
                method.Update(newinfo);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(string id)
        {
            NewsBll.Delete(new Guid(id));
            return RedirectToAction("Index");
        }

    }
}
