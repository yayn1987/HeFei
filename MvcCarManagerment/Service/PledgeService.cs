using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class PledgeService : YuanChenService
    {
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = 'e07c0a8c-94b8-4eee-b5b5-023a0ec8306c'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
    }
}