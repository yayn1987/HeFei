using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class OfferService : YuanChenService
    {
        /// <summary>
        /// 返回优惠活动的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '868eb660-335a-4176-8c6b-8a76d6865856'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
    }
}