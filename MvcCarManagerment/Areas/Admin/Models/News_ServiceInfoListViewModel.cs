using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class News_ServiceInfoListViewModel
    {
        public IEnumerable<YuanChen.Model.News_info> NewsServiceInfo { get; set; }

        public NewsInfo NewsInfo { get; set; }
    }
}