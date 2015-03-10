using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Areas.Admin.Common;
using MvcCarManagerment.Models;
using MvcCarManagerment.Extention;
using Omu.ValueInjecter;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class ManagerMentController : Controller
    {
        //
        // GET: /Admin/ManagerMent/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 管理界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Manager(string id)
        {
            ViewBag.tag = id;
            return View();
        }

        /// <summary>
        /// 管理界面
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Manager(ManagerModel model, FormCollection fc)
        {
            //string path = "~/UploadImage/";//上传路径
            ModelState.Remove("ID");
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase httpPostedFile = Request.Files["fileName"];
                    string name = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + httpPostedFile.FileName;       //获取文件名
                    string type = name.Substring(name.LastIndexOf(".") + 1);    //获取文件类型
                    ////var physicalPath = Server.MapPath(path);
                    ////var physicalFile = Path.Combine(physicalPath, name);
                    string ipath = Server.MapPath("~\\UploadImage") + "\\" + name;    //获取文件路径
                    //var path = System.Configuration.ConfigurationManager.AppSettings["uploadpath"];
                    //var filename = this.SaveFile(httpPostedFile, path);
                    string wpath = "~\\UploadImage\\" + name;        //[color=red]设置文件保存相对路径(这里的路径起始就是我们存放图片的文件夹名)[/color]
                    model.ImageUrl = wpath;//图片的相对路径
                    if (type == "jpg" || type == "gif" || type == "bmp" || type == "png")
                    {
                        //检查是否有该路径，没有就创建
                        if (!Directory.Exists(Server.MapPath("~\\UploadImage\\")))
                        {
                            Directory.CreateDirectory(Server.MapPath("~\\UploadImage\\"));
                        }
                        httpPostedFile.SaveAs(ipath);        //服务器保存路径
                    }
                }
                YuanChen.Model.News newinfo = new YuanChen.Model.News();
                newinfo.InjectFrom(model);
                //if (model.ID == Guid.Empty)
                //{
                //    newinfo.ID = Guid.NewGuid();
                //}
                // newinfo.TypeID = (Guid)model.TypeID.ToString().ToUpper();
                newinfo.Time = DateTime.Now;
                //保存到数据库News
                YuanChen.BLL.News method = new YuanChen.BLL.News();
                bool bo = method.Exists(model.ID);
                if (bo)
                {
                    method.Update(newinfo);
                }
                else
                {
                    method.Add(newinfo);
                }
                return View();
            }
            else
            {
                return View();
            }
        }

        public ActionResult ManagerIndex()
        {
            return View();
        }

        /// <summary>
        /// 图片上传管理
        /// </summary>
        /// <returns></returns>
        public ActionResult ImageManager()
        {
            return View();
        }

        /// <summary>
        /// 图片上传管理
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ImageManager(ImageModel model, FormCollection fc)
        {
            ModelState.Remove("ID");
            ModelState.Remove("ImagerUrl");
            if (ModelState.IsValid)
            {
                HttpPostedFileBase file = Request.Files["uploadfile"];
                string fileName = file.FileName;
                if (!String.IsNullOrEmpty(fileName))
                {
                    if (fileName.LastIndexOf("\\") > -1)
                    {
                        fileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                    }
                    string name = "AD" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fffffff") + fileName;       //获取文件名
                    string type = name.Substring(name.LastIndexOf(".") + 1);    //获取文件类型
                    var path = System.Configuration.ConfigurationManager.AppSettings["uploadAdpath"];
                    var strurl = Server.MapPath(path);
                    var ipath = Path.Combine(strurl, name);//获取文件路径
                    var wpath = path + name;//相对路径
                    model.ImagerUrl = wpath;
                    if (type == "jpg" || type == "gif" || type == "bmp" || type == "png")
                    {
                        //检查是否有该路径，没有就创建
                        if (!Directory.Exists(strurl))
                        {
                            Directory.CreateDirectory(strurl);
                        }
                        file.SaveAs(ipath);        //服务器保存路径
                    }
                    var spath = path + "s-" + name;//相对路径(缩略图)
                    if (model.ImageType == "1")//1 首页图片，2 广告位图片
                    {
                        ReducePic.ReducePicture(wpath, spath, 980);
                    }
                    else
                    {
                        ReducePic.ReducePicture(wpath, spath, 200);
                    }

                    if (System.IO.File.Exists(ipath))
                    {
                        System.IO.File.Delete(ipath);
                    }
                    YuanChen.Model.Images imageinfo = new YuanChen.Model.Images();
                    imageinfo.InjectFrom(model);
                    imageinfo.Time = DateTime.Now;
                    //保存或者更新到images
                    YuanChen.BLL.Images method = new YuanChen.BLL.Images();
                    bool bo = method.Exists(model.ID);
                    if (bo)
                    {
                        method.Update(imageinfo);
                    }
                    else
                    {
                        method.Add(imageinfo);
                    }

                }
                return View();
            }
            return View();
        }

        /// <summary>
        /// 关于我们展示
        /// </summary>
        /// <returns></returns>
        public ActionResult AboutUs()
        {
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
            return RedirectToAction("AboutUs");
        }
    }
}
