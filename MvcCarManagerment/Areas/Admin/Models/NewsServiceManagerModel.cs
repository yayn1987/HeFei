using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class NewsServiceManagerModel
    {
        [Display(Name = "ID")]
        public long ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "请填写【文章标题】！")]
        [Display(Name = "文章标题")]
        public string TiTle { get; set; }

        [Display(Name = "文章内容")]
        public string NewsComment { get; set; }

        [Display(Name = "类别类型")]
        public Guid ListID { get; set; }

        [Display(Name = "文章所属类型ID")]
        public Guid TypeID { get; set; }

        [Display(Name = "图片路径")]
        public string ImageUrl { get; set; }
    }
}