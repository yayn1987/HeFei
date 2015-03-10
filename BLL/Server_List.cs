using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace YuanChen.BLL
{
    //Server_List
    public partial class Server_List
    {

        private readonly YuanChen.DAL.Server_List dal = new YuanChen.DAL.Server_List();
        public Server_List()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ListID)
        {
            return dal.Exists(ListID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(YuanChen.Model.Server_List model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.Server_List model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid ListID)
        {

            return dal.Delete(ListID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YuanChen.Model.Server_List GetModel(Guid ListID)
        {

            return dal.GetModel(ListID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YuanChen.Model.Server_List GetModelByCache(Guid ListID)
        {

            string CacheKey = "Server_ListModel-" + ListID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ListID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (YuanChen.Model.Server_List)objModel;
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
        public List<YuanChen.Model.Server_List> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.Server_List> DataTableToList(DataTable dt)
        {
            List<YuanChen.Model.Server_List> modelList = new List<YuanChen.Model.Server_List>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YuanChen.Model.Server_List model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new YuanChen.Model.Server_List();
                    if (dt.Rows[n]["ListID"].ToString() != "")
                    {
                        model.ListID = new Guid(dt.Rows[n]["ListID"].ToString());
                    }
                    model.ListName = dt.Rows[n]["ListName"].ToString();
                    if (dt.Rows[n]["ParentID"].ToString() != "")
                    {
                        model.ParentID = new Guid(dt.Rows[n]["ParentID"].ToString());
                    }
                    //ImageUrl
                    if (dt.Rows[n]["ImageUrl"].ToString() != "")
                    {
                        model.ImageUrl = dt.Rows[n]["ImageUrl"].ToString();
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