using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace YuanChen.DAL
{
    //Images
    public partial class Images
    {

        public bool Exists(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Images");
            strSql.Append(" where ");
            strSql.Append(" ID = @ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(YuanChen.Model.Images model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Images(");
            strSql.Append("ID,ImagerUrl,Title,ImageType,Time,LinkUrl");
            strSql.Append(") values (");
            strSql.Append("@ID,@ImagerUrl,@Title,@ImageType,@Time,@LinkUrl");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ImagerUrl", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@Title", SqlDbType.VarChar,400) ,            
                        new SqlParameter("@ImageType", SqlDbType.VarChar,10) ,            
                        new SqlParameter("@Time", SqlDbType.DateTime),
                        new SqlParameter("@LinkUrl", SqlDbType.VarChar,1000)
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.ImagerUrl;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.ImageType;
            parameters[4].Value = model.Time;
            parameters[5].Value = model.LinkUrl;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.Images model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Images set ");

            strSql.Append(" ID = @ID , ");
            strSql.Append(" ImagerUrl = @ImagerUrl , ");
            strSql.Append(" Title = @Title , ");
            strSql.Append(" ImageType = @ImageType , ");
            strSql.Append(" Time = @Time,  ");
            strSql.Append(" LinkUrl = @LinkUrl  ");
            strSql.Append(" where ID=@ID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ImagerUrl", SqlDbType.VarChar,1000) ,            
                        new SqlParameter("@Title", SqlDbType.VarChar,400) ,            
                        new SqlParameter("@ImageType", SqlDbType.VarChar,10) , 
                        new SqlParameter("@LinkUrl", SqlDbType.VarChar,1000) ,
                        new SqlParameter("@Time", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.ImagerUrl;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.ImageType;
            parameters[4].Value = model.LinkUrl;
            parameters[5].Value = model.Time;

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
        public bool Delete(Guid ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Images ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ID;


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
        public YuanChen.Model.Images GetModel(Guid ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, ImagerUrl, Title, ImageType, Time ,LinkUrl ");
            strSql.Append("  from Images ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ID;


            YuanChen.Model.Images model = new YuanChen.Model.Images();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = new Guid(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.ImagerUrl = ds.Tables[0].Rows[0]["ImagerUrl"].ToString();
                model.LinkUrl = ds.Tables[0].Rows[0]["LinkUrl"].ToString();
                model.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                model.ImageType = ds.Tables[0].Rows[0]["ImageType"].ToString();
                if (ds.Tables[0].Rows[0]["Time"].ToString() != "")
                {
                    model.Time = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());
                }

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
            strSql.Append(" FROM Images ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" * ");
            strSql.Append(" FROM Images ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

