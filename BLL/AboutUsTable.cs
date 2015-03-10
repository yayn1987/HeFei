using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace YuanChen.BLL
{
    //AboutUsTable
    public partial class AboutUsTable
    {

        private readonly YuanChen.DAL.AboutUsTable dal = new YuanChen.DAL.AboutUsTable();
        public AboutUsTable()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(YuanChen.Model.AboutUsTable model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.AboutUsTable model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid ID)
        {

            return dal.Delete(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YuanChen.Model.AboutUsTable GetModel(Guid ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YuanChen.Model.AboutUsTable GetModelByCache(Guid ID)
        {

            string CacheKey = "AboutUsTableModel-" + ID;
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
            return (YuanChen.Model.AboutUsTable)objModel;
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
        public List<YuanChen.Model.AboutUsTable> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.AboutUsTable> DataTableToList(DataTable dt)
        {
            List<YuanChen.Model.AboutUsTable> modelList = new List<YuanChen.Model.AboutUsTable>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YuanChen.Model.AboutUsTable model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new YuanChen.Model.AboutUsTable();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = new Guid(dt.Rows[n]["ID"].ToString());
                    }
                    model.Coment = dt.Rows[n]["Coment"].ToString();
                    model.Time = DateTime.Parse(dt.Rows[n]["Time"].ToString());


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

        #region extenMethod
        /// <summary>
        /// 获得前几行数据List
        /// </summary>
        public List<YuanChen.Model.AboutUsTable> GetTopList(int Top, string strWhere, string filedOrder)
        {
            DataSet ds = dal.GetList(Top, strWhere, filedOrder);
            return DataTableToList(ds.Tables[0]);
        }

        #endregion

    }
}