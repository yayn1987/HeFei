using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Service
{
    public class AboutService
    {
        private YuanChen.BLL.AboutUsTable about = new YuanChen.BLL.AboutUsTable();

        /// <summary>
        /// 返回关于我们信息
        /// </summary>
        public YuanChen.Model.AboutUsTable GetAboutUs()
        {
            return about.GetModel(new Guid("b0529e99-40bd-4f6d-9426-35df362e600a"));
        }
    }
}