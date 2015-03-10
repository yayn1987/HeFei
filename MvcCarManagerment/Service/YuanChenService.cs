using MvcCarManagerment.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public abstract class YuanChenService
    {
        protected YuanChen.BLL.News newsBll = new YuanChen.BLL.News();
        protected YuanChen.BLL.News_info infoBll = new YuanChen.BLL.News_info();
        protected YuanChen.BLL.Server_List serverBll = new YuanChen.BLL.Server_List();

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

        public abstract IEnumerable<YuanChen.Model.News> GetNews(int top = 0);

        /// <summary>
        /// 根据ID返回一个实例
        /// </summary>
        public YuanChen.Model.News GetNewsByID(string id)
        {
            Guid guid = new Guid(id);
            return newsBll.GetModel(guid);
        }
    }
}