using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace YuanChen.Model
{
    //Server_List
    public class Server_List
    {

        /// <summary>
        /// ListID
        /// </summary>		
        private Guid _listid;
        public Guid ListID
        {
            get { return _listid; }
            set { _listid = value; }
        }
        /// <summary>
        /// ListName
        /// </summary>		
        private string _listname;
        public string ListName
        {
            get { return _listname; }
            set { _listname = value; }
        }
        /// <summary>
        /// ParentID
        /// </summary>		
        private Guid _parentid;
        public Guid ParentID
        {
            get { return _parentid; }
            set { _parentid = value; }
        }

        private string _imageurl;
        /// <summary>
        /// ImageUrl
        /// </summary>
        public string ImageUrl
        {
            set { _imageurl = value; }
            get { return _imageurl; }
        }
    }
}

