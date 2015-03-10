using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCarManagerment.Areas.Admin.Models;

namespace MvcCarManagerment.Areas.Admin.BLL
{
    /// <summary>
    /// 高端汽车服务
    /// </summary>
    public class CarService
    {

        private YuanChen.BLL.News CarBll = new YuanChen.BLL.News();
        private YuanChen.BLL.Server_List ServerBll = new YuanChen.BLL.Server_List();//服务类型系列
        private YuanChen.BLL.News_info NewsinfoBll = new YuanChen.BLL.News_info();//服务类别新闻

        public NewsPage News
        {
            get
            {
                var newsPage = new NewsPage
                {
                    News = GetCar()
                };
                return newsPage;
            }
        }

        //public NewsServiceInfoPage NewsServiceInfo
        //{
        //    get
        //    {
        //        var newsPage = new NewsServiceInfoPage
        //        {
        //            NewsServiceIinfo = GetCar()
        //        };
        //        return newsPage;
        //    }
        //}

        /// <summary>
        /// 获取新闻动态的所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News> GetCar()
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return this.CarBll.GetModelList("TypeID = '1743F8A1-F4C0-416D-B07F-56E6424907E7' order by Time desc");
        }

        /// <summary>
        /// 获取服务类型
        /// </summary>
        /// <param name="paerid"></param>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.Server_List> GetServerList(string paerid)
        {
            return ServerBll.GetModelList(" ParentID ='" + paerid + "'");
        }

        /// <summary>
        /// 获取服务动态的各个类别所有列表数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<YuanChen.Model.News_info> GetNewsService(string listid, string paerid)
        {
            //Guid guid = new Guid("2036a3dc-a3d1-445c-b77f-d4f9f6837b01");
            return NewsinfoBll.GetModelList(" TypeID ='" + paerid + "'" + " and ListID='" + listid + "'" + " order by Time desc");
        }

        /// <summary>
        /// 由类别ID获取类模型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public YuanChen.Model.Server_List GetType(string id)
        {
            return ServerBll.GetModel(new Guid(id));
        }

        /// <summary>
        /// 删除该类型下的内容新闻
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentid"></param>
        public bool DeleteNews_info(string id, string parentid)
        {
            List<string> result = new List<string>();
            string str = string.Empty;
            var list = NewsinfoBll.GetModelList(" ListID = '" + id + "'" + " and TypeID = '" + parentid + "'");
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    result.Add(item.ID.ToString());
                }
            }
            if (result.Count > 0)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result.Count == 1)
                    {
                        str = "'" + result[0].ToString() + "'";
                    }
                    else
                    {
                        if (i != result.Count - 1)
                        {
                            str += "'" + result[i].ToString() + "',";
                        }
                        else
                        {
                            str += "'" + result[i].ToString() + "'";
                        }
                    }
                }
            }
            if (str != string.Empty)
            {
                bool bo = NewsinfoBll.DeleteList(str);
                if (bo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}