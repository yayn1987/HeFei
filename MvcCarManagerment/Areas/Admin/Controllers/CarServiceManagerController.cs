using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Areas.Admin.Models;
using MvcCarManagerment.Areas.Admin.BLL;
using MvcCarManagerment.Models;
using Omu.ValueInjecter;
using MvcCarManagerment.Areas.Admin.Common;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class CarServiceManagerController : Controller
    {
        private int PageSize = 6;
        private YuanChen.BLL.News NewsBll = new YuanChen.BLL.News();
        private YuanChen.BLL.News_info infoBll = new YuanChen.BLL.News_info();
        private YuanChen.BLL.Server_List listBll = new YuanChen.BLL.Server_List();
        private CarService service = new CarService();

        /// <summary>
        /// 服务类型分类
        /// </summary>
        /// <returns></returns>
        public ActionResult IndexList(string parentid = "1743F8A1-F4C0-416D-B07F-56E6424907E7", int page = 1)
        {
            IList<ServerListModel> result = new List<ServerListModel>();
            var record = service.GetServerList(parentid);
            ServerListListViewModel listModel = new ServerListListViewModel
            {
                ServiceListInfo = record.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = record.Count(),
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return View(listModel);
            //if (record != null && record.Count() > 0)
            //{
            //    foreach (var item in record)
            //    {
            //        ServerListModel model = new ServerListModel();
            //        model.InjectFrom(item);
            //        result.Add(model);
            //    }

            //}
            //return View(result);
        }


        /// <summary>
        /// 查看详细界面
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(string id, string parentid = "1743F8A1-F4C0-416D-B07F-56E6424907E7", int page = 1)
        {
            var re = service.GetType(id);
            if (re != null)
            {
                ViewData["type"] = re.ListName;
            }
            else
            {
                ViewData["type"] = "";
            }

            var record = service.GetNewsService(id, parentid).ToList();
            News_ServiceInfoListViewModel listmodel = new News_ServiceInfoListViewModel
            {
                NewsServiceInfo = record.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = record.Count,
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return View(listmodel);
        }

        //
        // GET: /Admin/CarServiceManager/
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
        /// 追加汽车服务
        /// </summary>
        /// <returns></returns>
        public ActionResult Add(string id)
        {
            var re = service.GetType(id);
            if (re != null)
            {
                ViewData["type"] = re.ListName;
            }
            else
            {
                ViewData["type"] = "";
            }
            return View();
        }

        /// <summary>
        /// 管理界面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(NewsServiceManagerModel model, FormCollection fc, string id)
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
                    PicHandle.ResizeImage(httpPostedFile, ipath, 275, 190);
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
                    ReducePic.ReducePicture(imagepath, spath, 275);
                }

                YuanChen.Model.News_info newinfo = new YuanChen.Model.News_info();
                newinfo.InjectFrom(model);
                newinfo.Time = DateTime.Now;
                newinfo.TypeID = new Guid("1743F8A1-F4C0-416D-B07F-56E6424907E7");
                newinfo.ListID = new Guid(id);
                //保存到数据库News
                YuanChen.BLL.News_info method = new YuanChen.BLL.News_info();
                method.Add(newinfo);
                return RedirectToAction("Details", new { id = newinfo.ListID, parentid = newinfo.TypeID });
            }
            else
            {
                return View();
            }
        }


        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult Edit(long ID, string tyleid)
        {
            // Guid guid = new Guid(ID);
            var re = service.GetType(tyleid);
            if (re != null)
            {
                ViewData["type"] = re.ListName;
            }
            else
            {
                ViewData["type"] = "";
            }

            YuanChen.Model.News_info News = infoBll.GetModel(ID);
            if (News == null)
            {
                return HttpNotFound();
            }
            NewsServiceManagerModel model = new NewsServiceManagerModel();
            model.InjectFrom(News);

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(NewsServiceManagerModel model, FormCollection fc)
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
                    PicHandle.ResizeImage(httpPostedFile, ipath, 178, 138);
                }
                YuanChen.Model.News_info newinfo = new YuanChen.Model.News_info();
                newinfo.InjectFrom(model);
                newinfo.Time = DateTime.Now;
                //保存到数据库News_info
                YuanChen.BLL.News_info method = new YuanChen.BLL.News_info();
                method.Update(newinfo);
                return RedirectToAction("Details", new { id = newinfo.ListID, parentid = newinfo.TypeID });
            }
            else
            {
                return RedirectToAction("Details", new { id = model.ListID, parentid = model.TypeID });
            }
        }


        public ActionResult Delete(long id, Guid tyleid)
        {
            infoBll.Delete(id);
            return RedirectToAction("Details", new { id = tyleid });
        }

        /// <summary>
        /// 增加创建服务类别
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateType()
        {
            ServerListModel model = new ServerListModel();
            return View(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateType(ServerListModel model, string parentid = "1743f8a1-f4c0-416d-b07f-56e6424907e7")
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
                    PicHandle.ResizeImage(httpPostedFile, ipath, 178, 138);
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
                    ReducePic.ReducePicture(imagepath, spath, 178);
                }
                YuanChen.Model.Server_List info = new YuanChen.Model.Server_List();
                info.InjectFrom(model);
                info.ParentID = new Guid(parentid);
                listBll.Add(info);
                return RedirectToAction("IndexList");
            }
            else
            {
                return View();
            }
        }


        /// <summary>
        /// 编辑类别
        /// </summary>
        /// <returns></returns>
        public ActionResult EditType(Guid id)
        {
            var record = listBll.GetModel(id);
            ServerListModel model = new ServerListModel();
            if (record != null)
            {
                model.InjectFrom(record);
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditType(ServerListModel model)
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
                    PicHandle.ResizeImage(httpPostedFile, ipath, 178, 138);
                }
                YuanChen.Model.Server_List newinfo = new YuanChen.Model.Server_List();
                newinfo.InjectFrom(model);
                //保存到数据库Server_List
                listBll.Update(newinfo);
                return RedirectToAction("IndexList");
            }
            else
            {
                return View();
            }

        }

        /// <summary>
        /// 删除类型
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentid"></param>
        /// <returns></returns>
        public ActionResult DeleteType(Guid id, Guid parentid)
        {
            bool bo = listBll.Delete(id);
            if (bo)
            {
                service.DeleteNews_info(id.ToString(), parentid.ToString());
            }
            return RedirectToAction("IndexList");
        }
    }
}
