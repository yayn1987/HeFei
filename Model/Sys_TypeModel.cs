using System;
namespace YuanChen.Model
{
	/// <summary>
	/// Sys_TypeModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sys_TypeModel
	{
		public Sys_TypeModel()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private Guid _parentid;
		/// <summary>
		/// 
		/// </summary>
		public Guid ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAME
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		#endregion Model

	}
}

