using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class HandlerCarService : YuanChenService
    {
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '5c0de674-c29f-4fdc-86e2-9c36cc98f9de'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
    }
}