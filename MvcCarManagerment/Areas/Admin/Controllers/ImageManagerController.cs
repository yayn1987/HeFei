using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCarManagerment.Areas.Admin.Common;
using MvcCarManagerment.Models;
using Omu.ValueInjecter;
using MvcCarManagerment.Areas.Admin.BLL;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.Controllers
{
    public class ImageManagerController : Controller
    {
        private int PageSize = 6;
        private YuanChen.BLL.Images ImageBll = new YuanChen.BLL.Images();
        //private ImageService service = new ImageService();
        //
        // GET: /Admin/ImageManager/

        public ActionResult Index(string type = "1", int page = 1)
        {
            ImageService service = new ImageService(type);
            ImagePage imagePage = service.Images;
            ImagesListViewModel listModel = new ImagesListViewModel
            {
                Images = imagePage.Images.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = imagePage.Count,
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return View(listModel);
        }

        public ActionResult ADIndex(string type = "2", int page = 1)
        {
            ImageService service = new ImageService(type);
            ImagePage imagePage = service.Images;
            ImagesListViewModel listModel = new ImagesListViewModel
            {
                Images = imagePage.Images.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = imagePage.Count,
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return PartialView(listModel);
        }

        /// <summary>
        /// 广告位图片
        /// </summary>
        /// <param name="type"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult AdImageIndex(string type = "2", int page = 1)
        {
            ImageService service = new ImageService(type);
            ImagePage imagePage = service.Images;
            ImagesListViewModel listModel = new ImagesListViewModel
            {
                Images = imagePage.Images.Skip((page - 1) * PageSize)
                .Take(PageSize),
                NewsInfo = new NewsInfo
                {
                    ToalItems = imagePage.Count,
                    CurrentPage = page,
                    ItemPerPage = PageSize
                }
            };
            return View(listModel);
        }

        /// <summary>
        /// 图片上传管理
        /// </summary>
        /// <returns></returns>
        public ActionResult AddImageManager(string type = "1")
        {
            ViewBag.type = type;
            return View();
        }

        /// <summary>
        /// 图片上传管理
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddImageManager(ImageModel model, FormCollection fc)
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
                    var ipath = Path.Combine(strurl, "s-" + name);//获取文件路径
                    var wpath = path + "s-" + name;//相对路径
                    var spath = path + "s-" + name;//相对路径(缩略图)
                    model.ImagerUrl = spath;
                    //if (type == "jpg" || type == "gif" || type == "bmp" || type == "png")
                    //{
                    //    //检查是否有该路径，没有就创建
                    //    if (!Directory.Exists(strurl))
                    //    {
                    //        Directory.CreateDirectory(strurl);
                    //    }
                    //    file.SaveAs(ipath);        //服务器保存路径
                    //}
                    if (model.ImageType == "1")//1 首页图片，2 广告位图片
                    {
                        //ReducePic.ReducePicture(wpath, spath, ipath, 1038);//首页图片
                        PicHandle.ResizeImage(file, ipath, 1036, 500);
                    }
                    else
                    {
                        // ReducePic.ReducePicture(wpath, spath, ipath, 236);//广告位图片
                        PicHandle.ResizeImage(file, ipath, 236, 150);

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
                if (model.ImageType == "1")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("AdImageIndex");
                }

            }
            return View();
        }

        /// <summary>
        /// 更新图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult EditImage(Guid id)
        {
            YuanChen.BLL.Images method = new YuanChen.BLL.Images();
            ImageModel model = new ImageModel();
            if (id != Guid.Empty)
            {
                var record = method.GetModel(id);
                if (record != null)
                {
                    model.InjectFrom(record);
                }
            }
            return View(model);
        }


        /// <summary>
        /// 保存更新图片
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EditImage(ImageModel model)
        {
            YuanChen.BLL.Images method = new YuanChen.BLL.Images();
            YuanChen.Model.Images info = new YuanChen.Model.Images();
            info.InjectFrom(model);
            info.Time = DateTime.Now;
            method.Update(info);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            ImageBll.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
