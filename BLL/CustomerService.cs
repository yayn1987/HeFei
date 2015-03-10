﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using YuanChen.Model;
namespace YuanChen.BLL
{
    /// <summary>
    /// CustomerService
    /// </summary>
    public partial class CustomerService
    {
        private readonly YuanChen.DAL.CustomerService dal = new YuanChen.DAL.CustomerService();
        public CustomerService()
        { }
        #region  BasicMethod
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
        public long Add(YuanChen.Model.CustomerService model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.CustomerService model)
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
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YuanChen.Model.CustomerService GetModel(long ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YuanChen.Model.CustomerService GetModelByCache(long ID)
        {

            string CacheKey = "CustomerServiceModel-" + ID;
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
            return (YuanChen.Model.CustomerService)objModel;
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
        public List<YuanChen.Model.CustomerService> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.CustomerService> DataTableToList(DataTable dt)
        {
            List<YuanChen.Model.CustomerService> modelList = new List<YuanChen.Model.CustomerService>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YuanChen.Model.CustomerService model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
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

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 由主键ID检索客户服务，按照时间和状态排序
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<YuanChen.Model.CustomerService> GetCustomerList(long id)
        {
            string sqlwhere = " ID =" + id + " order by  time desc";
            return GetModelList(sqlwhere);
        }

        /// <summary>
        /// 由主键ID检索客户服务，按照时间和状态排序
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<YuanChen.Model.CustomerService> GetCustomerList()
        {
            string sqlwhere = " 1=1 order by  IsRead, time desc";
            return GetModelList(sqlwhere);
        }


        #endregion  ExtensionMethod
    }
}

