using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Models
{
    public class WedModel
    {
        private Service.NewsService service = new Service.NewsService();

        public IEnumerable<YuanChen.Model.News> Weds
        {
            get
            {
                return service.GetTopWed(20);
            }
        }

        public YuanChen.Model.News Wed { get; set; }
    }
}