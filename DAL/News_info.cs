using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace YuanChen.DAL
{
    //News_info
    public partial class News_info
    {

        public bool Exists(long ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from News_info");
            strSql.Append(" where ");
            strSql.Append(" ID = @ID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Add(YuanChen.Model.News_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into News_info(");
            strSql.Append("TiTle,NewsComment,ImageUrl,ListID,TypeID,Time");
            strSql.Append(") values (");
            strSql.Append("@TiTle,@NewsComment,@ImageUrl,@ListID,@TypeID,@Time");
            strSql.Append(") ");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
			            new SqlParameter("@TiTle", SqlDbType.VarChar,400) ,            
                        new SqlParameter("@NewsComment", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@ImageUrl", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TypeID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Time", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.TiTle;
            parameters[1].Value = model.NewsComment;
            parameters[2].Value = model.ImageUrl;
            parameters[3].Value = model.ListID;
            parameters[4].Value = model.TypeID;
            parameters[5].Value = model.Time;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {

                return Convert.ToInt64(obj);

            }

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.News_info model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update News_info set ");

            strSql.Append(" TiTle = @TiTle , ");
            strSql.Append(" NewsComment = @NewsComment , ");
            strSql.Append(" ImageUrl = @ImageUrl , ");
            strSql.Append(" ListID = @ListID , ");
            strSql.Append(" TypeID = @TypeID , ");
            strSql.Append(" Time = @Time  ");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.BigInt,8) ,            
                        new SqlParameter("@TiTle", SqlDbType.VarChar,400) ,            
                        new SqlParameter("@NewsComment", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@ImageUrl", SqlDbType.VarChar,200) ,            
                        new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@TypeID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Time", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.TiTle;
            parameters[2].Value = model.NewsComment;
            parameters[3].Value = model.ImageUrl;
            parameters[4].Value = model.ListID;
            parameters[5].Value = model.TypeID;
            parameters[6].Value = model.Time;
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
        public bool Delete(long ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from News_info ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
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
        /// 批量删除一批数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from News_info ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public YuanChen.Model.News_info GetModel(long ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, TiTle, NewsComment, ImageUrl, ListID, TypeID, Time  ");
            strSql.Append("  from News_info ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
            parameters[0].Value = ID;


            YuanChen.Model.News_info model = new YuanChen.Model.News_info();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = long.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.TiTle = ds.Tables[0].Rows[0]["TiTle"].ToString();
                model.NewsComment = ds.Tables[0].Rows[0]["NewsComment"].ToString();
                model.ImageUrl = ds.Tables[0].Rows[0]["ImageUrl"].ToString();
                if (ds.Tables[0].Rows[0]["ListID"].ToString() != "")
                {
                    model.ListID = new Guid(ds.Tables[0].Rows[0]["ListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = new Guid(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
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
            strSql.Append(" FROM News_info ");
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
            strSql.Append(" FROM News_info ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

