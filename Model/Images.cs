using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace YuanChen.Model
{
    //Images
    public class Images
    {

        /// <summary>
        /// ID
        /// </summary>		
        private Guid _id;
        public Guid ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// ImagerUrl
        /// </summary>		
        private string _imagerurl;
        public string ImagerUrl
        {
            get { return _imagerurl; }
            set { _imagerurl = value; }
        }

        /// <summary>
        /// LinkUrl
        /// </summary>
        private string _linkurl;
        public string LinkUrl
        {
            get { return _linkurl; }
            set { _linkurl = value; }

        }

        /// <summary>
        /// Title
        /// </summary>		
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        /// <summary>
        /// ImageType
        /// </summary>		
        private string _imagetype;
        public string ImageType
        {
            get { return _imagetype; }
            set { _imagetype = value; }
        }
        /// <summary>
        /// Time
        /// </summary>		
        private DateTime _time;
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

    }
}

