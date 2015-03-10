using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace YuanChen.Model
{
    //Image_Type
    public class Image_Type
    {

        /// <summary>
        /// ImagerID
        /// </summary>		
        private Guid _imagerid;
        public Guid ImagerID
        {
            get { return _imagerid; }
            set { _imagerid = value; }
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
        /// ImageName
        /// </summary>		
        private string _imagename;
        public string ImageName
        {
            get { return _imagename; }
            set { _imagename = value; }
        }

    }
}

