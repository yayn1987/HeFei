using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class WedService : YuanChenService
    {
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '6ba0df17-3bf5-4a82-9527-1fc3cf567e68'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
    }
}