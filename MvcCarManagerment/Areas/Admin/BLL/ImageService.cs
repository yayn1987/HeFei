using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    public class ImageService
    {
        private YuanChen.BLL.Images ImageBll = new YuanChen.BLL.Images();
        private string type = String.Empty;

        public ImageService(string type = "1")
        {
            this.type = type;
        }

        public ImagePage Images
        {
            get
            {
                var imagePage = new ImagePage
                {
                    Images = GetImages()
                };
                return imagePage;
            }
        }

        /// <summary>
        /// 获取新闻动态的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.Images> GetImages()
        {
            return this.ImageBll.GetModelList("ImageType = '" + this.type + "' order by Time desc");
        }

    }
}