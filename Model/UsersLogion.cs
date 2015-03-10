using System;
namespace YuanChen.Model
{
	/// <summary>
	/// UsersLogion:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UsersLogion
	{
		public UsersLogion()
		{}
		#region Model
		private long _userid;
		private string _username;
		private string _userpwd;
		/// <summary>
		/// 
		/// </summary>
		public long UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserPwd
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		#endregion Model

	}
}

