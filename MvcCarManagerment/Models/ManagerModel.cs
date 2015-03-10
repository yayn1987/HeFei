using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Models
{
    public class ManagerModel
    {

        [Display(Name = "新闻ID")]
        public Guid ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "请填写【文章标题】！")]
        [Display(Name = "文章标题")]
        public string Title { get; set; }

        [Display(Name = "文章内容")]
        public string NewsComment { get; set; }

        [Display(Name = "类型")]
        public string Type { get; set; }

        [Display(Name = "文章所属类型ID")]
        public Guid TypeID { get; set; }

        [Display(Name = "图片路径")]
        public string ImageUrl { get; set; }
    }
}