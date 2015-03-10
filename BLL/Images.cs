using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Maticsoft.Common;
using Maticsoft.Model;
namespace YuanChen.BLL
{
    //Images
    public partial class Images
    {

        private readonly YuanChen.DAL.Images dal = new YuanChen.DAL.Images();
        public Images()
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
        public void Add(YuanChen.Model.Images model)
        {
            dal.Add(model);

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.Images model)
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
        public YuanChen.Model.Images GetModel(Guid ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public YuanChen.Model.Images GetModelByCache(Guid ID)
        {

            string CacheKey = "ImagesModel-" + ID;
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
            return (YuanChen.Model.Images)objModel;
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
        public DataSet GetList(string strWhere, string filedOrder)
        {
            return dal.GetList(strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.Images> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<YuanChen.Model.Images> DataTableToList(DataTable dt)
        {
            List<YuanChen.Model.Images> modelList = new List<YuanChen.Model.Images>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                YuanChen.Model.Images model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new YuanChen.Model.Images();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = new Guid(dt.Rows[n]["ID"].ToString());
                    }
                    model.ImagerUrl = dt.Rows[n]["ImagerUrl"].ToString();
                    model.LinkUrl = dt.Rows[n]["LinkUrl"].ToString();
                    model.Title = dt.Rows[n]["Title"].ToString();
                    model.ImageType = dt.Rows[n]["ImageType"].ToString();
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