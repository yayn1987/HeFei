using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Models
{
    public class AboutUsModel
    {
        [Display(Name = "关于ID")]
        public Guid ID { get; set; }

        [Display(Name = "关于我们")]
        public string Coment { get; set; }
    }
}