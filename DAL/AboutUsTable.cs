using System;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Maticsoft.DBUtility;
namespace YuanChen.DAL
{
    //AboutUsTable
    public partial class AboutUsTable
    {

        public bool Exists(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AboutUsTable");
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
        public void Add(YuanChen.Model.AboutUsTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AboutUsTable(");
            strSql.Append("ID,Coment,Time");
            strSql.Append(") values (");
            strSql.Append("@ID,@Coment,@Time");
            strSql.Append(") ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Coment", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Time", SqlDbType.DateTime)             
              
            };

            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.Coment;
            parameters[2].Value = model.Time;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(YuanChen.Model.AboutUsTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AboutUsTable set ");

            strSql.Append(" ID = @ID , ");
            strSql.Append(" Coment = @Coment , ");
            strSql.Append(" Time = @Time  ");
            strSql.Append(" where ID=@ID  ");

            SqlParameter[] parameters = {
			            new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16) ,            
                        new SqlParameter("@Coment", SqlDbType.VarChar,-1) ,            
                        new SqlParameter("@Time", SqlDbType.NChar,10)             
              
            };

            parameters[0].Value = model.ID;
            parameters[1].Value = model.Coment;
            parameters[2].Value = model.Time;
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
            strSql.Append("delete from AboutUsTable ");
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
        public YuanChen.Model.AboutUsTable GetModel(Guid ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, Coment, Time  ");
            strSql.Append("  from AboutUsTable ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.UniqueIdentifier,16)			};
            parameters[0].Value = ID;


            YuanChen.Model.AboutUsTable model = new YuanChen.Model.AboutUsTable();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = new Guid(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Coment = ds.Tables[0].Rows[0]["Coment"].ToString();
                model.Time = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString());

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
            strSql.Append(" FROM AboutUsTable ");
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
            strSql.Append(" FROM AboutUsTable ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


    }
}

