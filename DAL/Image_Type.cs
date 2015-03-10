using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace YuanChen.DAL
{
    //Image_Type
    public partial class Image_Type
    {

        public bool Exists(Guid ImagerID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Image_Type");
            strSql.Append(" where ");
            strSql.Append(" ImagerID = @ImagerID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ImagerID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ImagerID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(YuanChen.Model.Image_Type model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Image_Type(");
            strSql.Append("ImagerID,ImageType,ImageName");
            strSql.Append(") values (");
            strSql.Append("@ImagerID,@ImageType,@ImageName");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ImagerID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ImageType", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@ImageName", SqlDbType.VarChar,10)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.ImageType;
            parameters[2].Value = model.ImageName;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.Image_Type model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Image_Type set ");

            strSql.Append(" ImagerID = @ImagerID , ");
            strSql.Append(" ImageType = @ImageType , ");
            strSql.Append(" ImageName = @ImageName  ");
            strSql.Append(" where ImagerID=@ImagerID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ImagerID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ImageType", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@ImageName", SqlDbType.VarChar,10)             
              
            };

            parameters[0].Value = model.ImagerID;
            parameters[1].Value = model.ImageType;
            parameters[2].Value = model.ImageName;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid ImagerID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Image_Type ");
            strSql.Append(" where ImagerID=@ImagerID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ImagerID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ImagerID;


            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public YuanChen.Model.Image_Type GetModel(Guid ImagerID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ImagerID, ImageType, ImageName  ");
            strSql.Append("  from Image_Type ");
            strSql.Append(" where ImagerID=@ImagerID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ImagerID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ImagerID;


            YuanChen.Model.Image_Type model = new YuanChen.Model.Image_Type();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ImagerID"].ToString() != "")
                {
                    model.ImagerID = new Guid(ds.Tables[0].Rows[0]["ImagerID"].ToString());
                }
                model.ImageType = ds.Tables[0].Rows[0]["ImageType"].ToString();
                model.ImageName = ds.Tables[0].Rows[0]["ImageName"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Image_Type ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" * ");
            strSql.Append(" FROM Image_Type ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

