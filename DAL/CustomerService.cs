using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace YuanChen.DAL
{
	/// <summary>
	/// 数据访问类:CustomerService
	/// </summary>
	public partial class CustomerService
	{
		public CustomerService()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerService");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(YuanChen.Model.CustomerService model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CustomerService(");
			strSql.Append("SubJect,Name,Email,Tel,Comment,IsRead,Time)");
			strSql.Append(" values (");
			strSql.Append("@SubJect,@Name,@Email,@Tel,@Comment,@IsRead,@Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SubJect", SqlDbType.VarChar,100),
					new SqlParameter("@Name", SqlDbType.VarChar,300),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Comment", SqlDbType.VarChar,600),
					new SqlParameter("@IsRead", SqlDbType.Bit,1),
					new SqlParameter("@Time", SqlDbType.DateTime)};
			parameters[0].Value = model.SubJect;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Email;
			parameters[3].Value = model.Tel;
			parameters[4].Value = model.Comment;
			parameters[5].Value = model.IsRead;
			parameters[6].Value = model.Time;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(YuanChen.Model.CustomerService model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerService set ");
			strSql.Append("SubJect=@SubJect,");
			strSql.Append("Name=@Name,");
			strSql.Append("Email=@Email,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Comment=@Comment,");
			strSql.Append("IsRead=@IsRead,");
			strSql.Append("Time=@Time");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SubJect", SqlDbType.VarChar,100),
					new SqlParameter("@Name", SqlDbType.VarChar,300),
					new SqlParameter("@Email", SqlDbType.VarChar,100),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Comment", SqlDbType.VarChar,600),
					new SqlParameter("@IsRead", SqlDbType.Bit,1),
					new SqlParameter("@Time", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.SubJect;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Email;
			parameters[3].Value = model.Tel;
			parameters[4].Value = model.Comment;
			parameters[5].Value = model.IsRead;
			parameters[6].Value = model.Time;
			parameters[7].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerService ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerService ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public YuanChen.Model.CustomerService GetModel(long ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SubJect,Name,Email,Tel,Comment,IsRead,Time from CustomerService ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			YuanChen.Model.CustomerService model=new YuanChen.Model.CustomerService();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public YuanChen.Model.CustomerService DataRowToModel(DataRow row)
		{
			YuanChen.Model.CustomerService model=new YuanChen.Model.CustomerService();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=long.Parse(row["ID"].ToString());
				}
				if(row["SubJect"]!=null)
				{
					model.SubJect=row["SubJect"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Comment"]!=null)
				{
					model.Comment=row["Comment"].ToString();
				}
				if(row["IsRead"]!=null && row["IsRead"].ToString()!="")
				{
					if((row["IsRead"].ToString()=="1")||(row["IsRead"].ToString().ToLower()=="true"))
					{
						model.IsRead=true;
					}
					else
					{
						model.IsRead=false;
					}
				}
				if(row["Time"]!=null && row["Time"].ToString()!="")
				{
					model.Time=DateTime.Parse(row["Time"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,SubJect,Name,Email,Tel,Comment,IsRead,Time ");
			strSql.Append(" FROM CustomerService ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,SubJect,Name,Email,Tel,Comment,IsRead,Time ");
			strSql.Append(" FROM CustomerService ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM CustomerService ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from CustomerService T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "CustomerService";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

