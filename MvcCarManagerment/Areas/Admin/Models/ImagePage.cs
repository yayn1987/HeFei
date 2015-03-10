using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class ImagePage
    {
        public IEnumerable<YuanChen.Model.Images> Images { get; set; }

        public int Count
        {
            get
            {
                return Images.Count();
            }
        }
    }
}