using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuanChen.Model;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class NewsListViewModel
    {
        public IEnumerable<News> News { get; set; }

        public NewsInfo NewsInfo { get; set; }
    }
}