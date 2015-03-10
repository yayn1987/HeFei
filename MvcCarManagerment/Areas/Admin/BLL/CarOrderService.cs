using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    /// <summary>
    /// 车辆订购、按揭
    /// </summary>
    public class CarOrderService
    {
        private YuanChen.BLL.News CarBll = new YuanChen.BLL.News();

        public NewsPage News
        {
            get
            {
                var newsPage = new NewsPage
                {
                    News = GetCarOrder()
                };
                return newsPage;
            }
        }

        /// <summary>
        /// 获取新闻动态的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetCarOrder()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.CarBll.GetModelList("TypeID = '129D7619-5F5C-4276-81BB-2A9E52CC6672' order by Time desc");
        }
    }
}