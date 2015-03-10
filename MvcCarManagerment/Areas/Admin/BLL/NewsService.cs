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
    /// <summary>
    /// 新闻列表的逻辑处理类
    /// </summary>
    public class NewsService
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
        /// 获取新闻动态的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetNews()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.newsBll.GetModelList("TypeID = '1fb3525a-2a2c-48fb-af67-849dd12da1bd' order by Time desc");
        }
    }
}