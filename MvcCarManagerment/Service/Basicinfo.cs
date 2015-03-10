using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCarManagerment.Models;
using YuanChen.BLL;
using System.Net;
using System.Web.Security;

namespace MvcCarManagerment.Service
{
    public class Basicinfo
    {


        #region cache
        private static Dictionary<string, object> _cache = new Dictionary<string, object>();
        #endregion

        #region 获取类型列表
        /// <summary>
        /// 获取类型列表
        /// </summary>
        /// <returns>获取类型列表</returns>
        public static IList<YuanChen.Model.Sys_TypeModel> GeTypeList()
        {
            var key = "Type";
            if (!_cache.ContainsKey(key))
            {
                lock (_cache)
                {
                    string strwhere = "ParentID  is not null";
                    Sys_TypeModel model = new Sys_TypeModel();
                    var list = model.GetModelList(strwhere);
                    if (!_cache.ContainsKey(key))
                    {
                        _cache.Add(key, list);
                    }
                }
            }
            return (IList<YuanChen.Model.Sys_TypeModel>)_cache[key];

        }

        /// <summary>
        /// 获取默认返回类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetType(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return id.Trim();
            }
            else
            {
                return "1FB3525A-2A2C-48FB-AF67-849DD12DA1BD";
            }

        }

        /// <summary>
        /// 获取默认返回图片类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetImageType(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return id.Trim();
            }
            else
            {
                return "1";
            }

        }
        #endregion

        #region  获取图片类型列表
        public static IList<YuanChen.Model.Image_Type> GetImageTypeList()
        {
            var key = "ImageType";
            if (!_cache.ContainsKey(key))
            {
                lock (_cache)
                {
                    string strwhere = "1 = 1 order by ImageType ";
                    Image_Type model = new Image_Type();
                    var list = model.GetModelList(strwhere);
                    if (!_cache.ContainsKey(key))
                    {
                        _cache.Add(key, list);
                    }
                }
            }
            return (IList<YuanChen.Model.Image_Type>)_cache[key];
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UserModel GetUserInfo()
        {
            var Userinfo = HttpContext.Current.User.Identity as FormsIdentity;
            UserModel info = new UserModel
            {
                UserName = Userinfo.Name,
                UserPwd = Userinfo.Ticket.UserData
            };
            return info;
        }

        /// <summary>
        /// 获取前汽车服务的消息
        /// </summary>
        /// <returns></returns>
        public static List<YuanChen.Model.News> GetTopListCar()
        {
            NewsService news = new NewsService();
            IEnumerable<YuanChen.Model.News> list = news.GetTopCarService(12);
            return list.ToList();

        }

        /// <summary>
        /// 获取前汽车服务类别的消息
        /// </summary>
        /// <returns></returns>
        public static List<YuanChen.Model.Server_List> GetTopServerListCar()
        {
            CarService car = new CarService();
            IEnumerable<YuanChen.Model.Server_List> list = car.GetTopCarService();
            return list.ToList();

        }

        /// <summary>
        /// 获取车辆抵押的消息
        /// </summary>
        /// <returns></returns>
        public static List<YuanChen.Model.News> GetTopListPledge()
        {
            NewsService news = new NewsService();
            IEnumerable<YuanChen.Model.News> list = news.GetTopPledge(12);
            return list.ToList();

        }
    }
}