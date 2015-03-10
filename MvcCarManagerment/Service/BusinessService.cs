using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class BusinessService : YuanChenService
    {
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '3b57ea6b-95d3-4548-af8e-743992e08d7e'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
    }
}