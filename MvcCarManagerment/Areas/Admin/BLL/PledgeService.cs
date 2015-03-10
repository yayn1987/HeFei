using MvcCarManagerment.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    /// <summary>
    /// 车辆抵押
    /// </summary>
    public class PledgeService
    {
        private YuanChen.BLL.News BusinessBll = new YuanChen.BLL.News();

        public NewsPage News
        {
            get
            {
                var newsPage = new NewsPage
                {
                    News = GetPledge()
                };
                return newsPage;
            }
        }

        /// <summary>
        /// 获取车辆抵押的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetPledge()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.BusinessBll.GetModelList("TypeID = 'e07c0a8c-94b8-4eee-b5b5-023a0ec8306c' order by Time desc");
        }
    }
}