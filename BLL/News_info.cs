using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace YuanChen.BLL
{
    //News_info
    public partial class News_info
    {

        private readonly YuanChen.DAL.News_info dal = new YuanChen.DAL.News_info();
        public News_info()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Add(YuanChen.Model.News_info model)
        {
            return dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.News_info model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YuanChen.Model.News_info GetModel(long ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YuanChen.Model.News_info GetModelByCache(long ID)
        {

            string CacheKey = "News_infoModel-" + ID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (YuanChen.Model.News_info)objModel;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.News_info> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.News_info> DataTableToList(DataTable dt)
        {
            List<YuanChen.Model.News_info> modelList = new List<YuanChen.Model.News_info>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YuanChen.Model.News_info model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new YuanChen.Model.News_info();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = long.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.TiTle = dt.Rows[n]["TiTle"].ToString();
                    model.NewsComment = dt.Rows[n]["NewsComment"].ToString();
                    model.ImageUrl = dt.Rows[n]["ImageUrl"].ToString();
                    if (dt.Rows[n]["ListID"].ToString() != "")
                    {
                        model.ListID = new Guid(dt.Rows[n]["ListID"].ToString());
                    }
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = new Guid(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["Time"].ToString() != "")
                    {
                        model.Time = DateTime.Parse(dt.Rows[n]["Time"].ToString());
                    }


                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        #endregion

    }
}