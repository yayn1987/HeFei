using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    /// <summary>
    /// 二手车交易、评估
    /// </summary>
    public class HandCarService
    {
        private YuanChen.BLL.News CarBll = new YuanChen.BLL.News();

        public NewsPage News
        {
            get
            {
                var newsPage = new NewsPage
                {
                    News = GetHandleCar()
                };
                return newsPage;
            }
        }

        /// <summary>
        /// 获取新闻动态的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetHandleCar()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.CarBll.GetModelList("TypeID = '5C0DE674-C29F-4FDC-86E2-9C36CC98F9DE' order by Time desc");
        }
    }
}