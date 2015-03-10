using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class CarOrderService : YuanChenService
    {
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '129d7619-5f5c-4276-81bb-2a9e52cc6672'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
    }
}