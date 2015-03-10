using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Models
{
    /// <summary>
    /// 新闻的分页模型信息
    /// </summary>
    public class NewsInfo
    {
        /// <summary>
        /// 新闻总条数
        /// </summary>
        public int ToalItems { get; set; }

        /// <summary>
        /// 每页显示的新闻条数
        /// </summary>
        public int ItemPerPage { get; set; }

        /// <summary>
        /// 当前显示的页的索引值
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 页面的总数
        /// </summary>
        public int ToalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)ToalItems / ItemPerPage);
            }
        }
    }
}