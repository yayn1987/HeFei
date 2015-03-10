using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class NewsServiceInfoPage
    {
        public IEnumerable<YuanChen.Model.News_info> NewsServiceIinfo { get; set; }

        public int Count
        {
            get
            {
                return NewsServiceIinfo.Count();
            }
        }
    }
}