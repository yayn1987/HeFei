using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcCarManagerment.Models
{
    public class CustomerModel
    {
        [Display(Name = "CustomerID")]
        public long ID
        {
            set;
            get;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "主题不能为空")]
        [Display(Name = "主题")]
        public string SubJect
        {
            set;
            get;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "姓名不能为空")]
        [Display(Name = "姓名")]
        public string Name
        {
            set;
            get;
        }

        [Display(Name = "邮箱")]
        [RegularExpression(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "请输入正确的Email")]
        public string Email
        {
            set;
            get;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "联系方式不能为空")]
        [RegularExpression(@"^\d{3}[-]?\d{8}$|^\d{4}[-]?\d{8}$|^\d{4}[-]?\d{7}$"
           , ErrorMessage = "请正确填写【电话】(如010-88888888)或者【手机号码】！")]
        [Display(Name = "联系方式")]
        public string Tel
        {
            set;
            get;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "内容不能为空")]
        [Display(Name = "内容")]
        [StringLength(500, ErrorMessage = "最多不能超过500个字")]
        public string Comment
        {
            set;
            get;
        }

        [Display(Name = "提交时间")]
        public DateTime? Time { get; set; }

        [Display(Name = "提交时间")]
        public string FormatTime
        {
            get
            {
                if (Time.HasValue)
                {
                    return Time.Value.Date.ToString("yyyy年MM月dd日");
                }
                else
                {
                    return DateTime.Now.ToString("yyyy年MM月dd日");
                }

            }
        }


        /// <summary>
        /// 
        /// </summary>
        public bool IsRead
        {
            set;
            get;
        }

        public string IsReadStatus
        {
            get
            {
                if (IsRead)
                {
                    return "已阅";
                }
                else
                {
                    return "待阅";
                }
            }
        }
    }
}