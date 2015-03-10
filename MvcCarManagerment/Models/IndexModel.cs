using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Models
{
    public class IndexModel
    {
        private Service.NewsService service = new Service.NewsService();

        public IEnumerable<YuanChen.Model.Images> Images
        {
            get
            {
                return new Service.ImageService().GetTopImages(4);
            }
        }

        public IEnumerable<YuanChen.Model.News> News {
            get
            {
                return service.GetNews(5);
            }
        }

        public IDictionary<string,string> Service
        {
            get
            {
                return new Dictionary<string, string>
                {
                    {"Wed","高端婚庆策划"},{"Business","高端商务礼仪"},{"CarService","高端汽车服务"},
                    {"CarOrder","车辆订购、按揭"},{"Pledge","车辆抵押"},{"HandCar","二手车交易、评估"}
                };
            }
        }

        public YuanChen.Model.AboutUsTable AboutUs
        {
            get
            {
                return new Service.AboutService().GetAboutUs();
            }
        }
    }
}