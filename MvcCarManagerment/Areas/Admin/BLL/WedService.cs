using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YuanChen.Model;
using YuanChen.BLL;
using MvcCarManagerment.Models;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    public class WedService
    {
        private YuanChen.BLL.News newsBll = new YuanChen.BLL.News();

        public NewsPage News
        {
            get
            {
                var newsPage = new NewsPage
                {
                    News = GetNews()
                };
                return newsPage;
            }
        }

        /// <summary>
        /// 获取高端婚庆的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetNews()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.newsBll.GetModelList("TypeID = '6ba0df17-3bf5-4a82-9527-1fc3cf567e68' order by Time desc");
        }
    }
}