using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Models
{
    public class ImageModel
    {
        [Display(Name = "图片ID")]
        public Guid ID { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "请上传【图片】！")]
        [Display(Name = "图片路径")]
        public string ImagerUrl
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "请填写【图片名称】！")]
        [Display(Name = "图片名称")]
        public string Title
        {
            get;
            set;
        }

        [Display(Name = "图片类型")]
        public string ImageType
        {
            get;
            set;
        }

        [Display(Name = "图片链接地址")]
        public string LinkUrl
        {
            get;
            set;
        }
    }
}