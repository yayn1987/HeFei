using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Models
{
    public class BusinessModel
    {
        private Service.NewsService service = new Service.NewsService();

        public IEnumerable<YuanChen.Model.News> Weds
        {
            get
            {
                return service.GetTopBusiness(10);
            }
        }

        public YuanChen.Model.News Wed { get; set; }
    }
}