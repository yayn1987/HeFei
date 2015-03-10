using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace YuanChen.BLL
{
    //Image_Type
    public partial class Image_Type
    {

        private readonly YuanChen.DAL.Image_Type dal = new YuanChen.DAL.Image_Type();
        public Image_Type()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ImagerID)
        {
            return dal.Exists(ImagerID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(YuanChen.Model.Image_Type model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.Image_Type model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid ImagerID)
        {

            return dal.Delete(ImagerID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YuanChen.Model.Image_Type GetModel(Guid ImagerID)
        {

            return dal.GetModel(ImagerID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YuanChen.Model.Image_Type GetModelByCache(Guid ImagerID)
        {

            string CacheKey = "Image_TypeModel-" + ImagerID;
            object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ImagerID);
                    if (objModel != null)
                    {
                        int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
                        Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (YuanChen.Model.Image_Type)objModel;
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
        public List<YuanChen.Model.Image_Type> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.Image_Type> DataTableToList(DataTable dt)
        {
            List<YuanChen.Model.Image_Type> modelList = new List<YuanChen.Model.Image_Type>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YuanChen.Model.Image_Type model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new YuanChen.Model.Image_Type();
                    if (dt.Rows[n]["ImagerID"].ToString() != "")
                    {
                        model.ImagerID = new Guid(dt.Rows[n]["ImagerID"].ToString());
                    }
                    model.ImageType = dt.Rows[n]["ImageType"].ToString();
                    model.ImageName = dt.Rows[n]["ImageName"].ToString();


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