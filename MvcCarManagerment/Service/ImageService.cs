using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class ImageService
    {
        private YuanChen.BLL.Images imageService = new YuanChen.BLL.Images();

        public IEnumerable<YuanChen.Model.Images> GetTopImages(int top)
        {
            DataSet ds = imageService.GetList("ImageType = 1","Time");
            return imageService.DataTableToList(ds.Tables[0]).OrderByDescending(t => t.Time).Take(4);
        }
    }
}