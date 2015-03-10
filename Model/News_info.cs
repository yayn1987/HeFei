using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace YuanChen.Model{
	 	//News_info
		public class News_info
	{
   		     
      	/// <summary>
		/// ID
        /// </summary>		
		private long _id;
        public long ID
        {
            get{ return _id; }
            set{ _id = value; }
        }        
		/// <summary>
		/// TiTle
        /// </summary>		
		private string _title;
        public string TiTle
        {
            get{ return _title; }
            set{ _title = value; }
        }        
		/// <summary>
		/// NewsComment
        /// </summary>		
		private string _newscomment;
        public string NewsComment
        {
            get{ return _newscomment; }
            set{ _newscomment = value; }
        }        
		/// <summary>
		/// ImageUrl
        /// </summary>		
		private string _imageurl;
        public string ImageUrl
        {
            get{ return _imageurl; }
            set{ _imageurl = value; }
        }        
		/// <summary>
		/// ListID
        /// </summary>		
		private Guid _listid;
        public Guid ListID
        {
            get{ return _listid; }
            set{ _listid = value; }
        }        
		/// <summary>
		/// TypeID
        /// </summary>		
		private Guid _typeid;
        public Guid TypeID
        {
            get{ return _typeid; }
            set{ _typeid = value; }
        }        
		/// <summary>
		/// Time
        /// </summary>		
		private DateTime _time;
        public DateTime Time
        {
            get{ return _time; }
            set{ _time = value; }
        }        
		   
	}
}

