using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace YuanChen.DAL
{
    //Server_List
    public partial class Server_List
    {

        public bool Exists(Guid ListID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Server_List");
            strSql.Append(" where ");
            strSql.Append(" ListID = @ListID  ");
            SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ListID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(YuanChen.Model.Server_List model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Server_List(");
            strSql.Append("ListID,ListName,ParentID,ImageUrl");
            strSql.Append(") values (");
            strSql.Append("@ListID,@ListName,@ParentID,@ImageUrl");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ListName", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@ParentID", SqlDbType.UniqueIdentifier,16),
                        new SqlParameter("@ImageUrl", SqlDbType.VarChar,200)
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.ListName;
            parameters[2].Value = model.ParentID;
            parameters[3].Value = model.ImageUrl;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.Server_List model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Server_List set ");

            strSql.Append(" ListID = @ListID , ");
            strSql.Append(" ListName = @ListName , ");
            strSql.Append(" ParentID = @ParentID , ");
            strSql.Append(" ImageUrl = @ImageUrl  ");
            strSql.Append(" where ListID=@ListID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@ListName", SqlDbType.VarChar,100) ,            
                        new SqlParameter("@ParentID", SqlDbType.UniqueIdentifier,16) ,
                        new SqlParameter("@ImageUrl", SqlDbType.VarChar,200) 
              
            };

            parameters[0].Value = model.ListID;
            parameters[1].Value = model.ListName;
            parameters[2].Value = model.ParentID;
            parameters[3].Value = model.ImageUrl;
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
        public bool Delete(Guid ListID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Server_List ");
            strSql.Append(" where ListID=@ListID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ListID;


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
        public YuanChen.Model.Server_List GetModel(Guid ListID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ListID, ListName, ParentID,ImageUrl  ");
            strSql.Append("  from Server_List ");
            strSql.Append(" where ListID=@ListID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ListID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ListID;


            YuanChen.Model.Server_List model = new YuanChen.Model.Server_List();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ListID"].ToString() != "")
                {
                    model.ListID = new Guid(ds.Tables[0].Rows[0]["ListID"].ToString());
                }
                model.ListName = ds.Tables[0].Rows[0]["ListName"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = new Guid(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ImageUrl"].ToString() != "")
                {
                    model.ImageUrl = ds.Tables[0].Rows[0]["ImageUrl"].ToString();
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
            strSql.Append(" FROM Server_List ");
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
            strSql.Append(" FROM Server_List ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (!string.IsNullOrEmpty(filedOrder))
            {
                strSql.Append(" order by " + filedOrder);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

