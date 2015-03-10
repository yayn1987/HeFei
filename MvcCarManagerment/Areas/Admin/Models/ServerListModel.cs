using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Areas.Admin.Models
{
    public class ServerListModel
    {
        [Display(Name = "类型ID")]
        public Guid ListID
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "类型名称不可为空！")]
        [Display(Name = "类型名称")]
        public string ListName
        {
            get;
            set;
        }

        [Display(Name = "图片路径")]
        public string ImageUrl
        {
            get;
            set;
        }


        [Display(Name = "所属类")]
        public Guid ParentID
        {
            get;
            set;
        }
    }
}