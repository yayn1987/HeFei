using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class ServerListPage
    {
        public IEnumerable<YuanChen.Model.Server_List> News { get; set; }

        public int Count
        {
            get
            {
                return News.Count();
            }
        }
    }
}