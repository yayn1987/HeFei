using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    /// <summary>
    /// 商务礼仪服务
    /// </summary>
    public class BusinessService
    {
        private YuanChen.BLL.News BusinessBll = new YuanChen.BLL.News();

        public NewsPage News
        {
            get
            {
                var newsPage = new NewsPage
                {
                    News = GetBusiness()
                };
                return newsPage;
            }
        }

        /// <summary>
        /// 获取新闻动态的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetBusiness()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.BusinessBll.GetModelList("TypeID = '3B57EA6B-95D3-4548-AF8E-743992E08D7E' order by Time desc");
        }
    }
}