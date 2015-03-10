using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class NewsPage
    {
        public IEnumerable<YuanChen.Model.News> News { get; set; }

        public int Count
        {
            get
            {
                return News.Count();
            }
        }
    }
}