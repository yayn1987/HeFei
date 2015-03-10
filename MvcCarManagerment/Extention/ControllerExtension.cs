using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MvcCarManagerment.Extention
{
    public static class ControllerExtension
    {
        public static string SaveFile(this Controller controller, HttpPostedFileBase file, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = "~/UploadImage/";
            }

            // var filename = string.Format("{0}{1}", Guid.NewGuid().ToString().ToUpper(), Path.GetExtension(file.FileName));
            var filename = file.FileName;
            string type = file.FileName.Substring(file.FileName.LastIndexOf(".") + 1);    //获取文件类型;

            var physicalPath = controller.Server.MapPath(path);
            if (!Directory.Exists(physicalPath))
            {
                Directory.CreateDirectory(physicalPath);
            }

            if (type == "jpg" || type == "gif" || type == "bmp" || type == "png")
            {
                var physicalFile = Path.Combine(physicalPath, filename);
                file.SaveAs(physicalFile);
            }

            return filename;
        }

        public static bool RemoveFile(this Controller controller, string filename, string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                path = "~/UploadImage/";
            }

            var physicalPath = controller.Server.MapPath(path);

            var physicalFile = Path.Combine(controller.Server.MapPath(path), filename);

            if (File.Exists(physicalFile))
            {
                File.Delete(physicalFile);
                return true;
            }

            return false;
        }
    }
}