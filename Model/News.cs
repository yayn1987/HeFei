using System;
namespace YuanChen.Model
{
	/// <summary>
	/// News:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class News
	{
		public News()
		{}
		#region Model
		private Guid _id;
		private string _newscomment;
		private string _title;
		private string _imageurl;
		private Guid _typeid;
		private DateTime? _time;
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
		public string NewsComment
		{
			set{ _newscomment=value;}
			get{return _newscomment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageUrl
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid TypeID
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

