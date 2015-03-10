using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuanChen.Model;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class ImagesListViewModel
    {
        public IEnumerable<Images> Images { get; set; }

        public NewsInfo NewsInfo { get; set; }
    }
}