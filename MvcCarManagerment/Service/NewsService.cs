using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using YuanChen.BLL;
using YuanChen.Model;

namespace MvcCarManagerment.Service
{
    public class NewsService : YuanChenService
    {
        /// <summary>
        /// 返回新闻的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public override IEnumerable<YuanChen.Model.News> GetNews(int top = 0)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '1fb3525a-2a2c-48fb-af67-849dd12da1bd'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回优惠活动的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopOffer(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '868eb660-335a-4176-8c6b-8a76d6865856'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回高端婚庆策划的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopWed(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '6ba0df17-3bf5-4a82-9527-1fc3cf567e68'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回高端商务礼仪的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopBusiness(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '3b57ea6b-95d3-4548-af8e-743992e08d7e'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回高端汽车服务的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopCarService(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '1743f8a1-f4c0-416d-b07f-56e6424907e7'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回车辆订购、按揭的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopCarOrder(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '129d7619-5f5c-4276-81bb-2a9e52cc6672'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回二手车交易的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopHandlerCar(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = '5c0de674-c29f-4fdc-86e2-9c36cc98f9de'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 返回车辆抵押的前几条信息，以时间排序
        /// </summary>
        /// <param name="top">条数</param>
        public IEnumerable<YuanChen.Model.News> GetTopPledge(int top)
        {
            DataSet ds = newsBll.GetList(top, "TypeID = 'e07c0a8c-94b8-4eee-b5b5-023a0ec8306c'", "Time desc");
            return newsBll.DataTableToList(ds.Tables[0]);
        }
        
    }
}