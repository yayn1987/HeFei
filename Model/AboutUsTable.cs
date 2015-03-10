using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace YuanChen.Model
{
    //AboutUsTable
    public class AboutUsTable
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
        /// Coment
        /// </summary>		
        private string _coment;
        public string Coment
        {
            get { return _coment; }
            set { _coment = value; }
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

