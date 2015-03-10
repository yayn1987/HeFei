using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace MvcCarManagerment.Areas.Admin.Common
{
    public class ReducePic
    {
        public static void ReducePicture(string ImagePath, string tThumbImage, int width)
        {
            string ThumbImage = HttpContext.Current.Server.MapPath(tThumbImage);
            string PicPath = HttpContext.Current.Server.MapPath(ImagePath);
            Image NewImage = Image.FromFile(PicPath);
            int ToWidth = width;
            int ToHeight = width;
            int Width = NewImage.Width;
            int Height = NewImage.Height;

            if (Width >= Height)
            {
                ToWidth = width;
                ToHeight = width * Height / Width;
            }
            else
            {
                ToHeight = width;
                ToWidth = width * Width / Height;
            }

            using (Bitmap bitmap = new Bitmap(ToWidth, ToHeight))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    //g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High; //高质量插值法
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //高质量，低速度呈平滑程度
                    g.Clear(Color.Transparent); //画布设置透明
                    g.DrawImage(NewImage, new Rectangle(0, 0, ToWidth, ToHeight),
                        new Rectangle(0, 0, Width, Height),
                        GraphicsUnit.Pixel); //设置像素为度量单位
                    NewImage.Dispose();
                    g.Dispose();

                }
                try
                {
                    bitmap.Save(ThumbImage, ImageFormat.Jpeg);
                }
                catch (Exception e)
                {
                    bitmap.Dispose();
                }
                finally
                {
                    bitmap.Dispose();
                }
            }
        }

        /// <summary>
        /// 等比例缩小，并且删除原图片
        /// </summary>
        /// <param name="ImagePath"></param>
        /// <param name="tThumbImage"></param>
        /// <param name="path"></param>
        /// <param name="width"></param>
        public static void ReducePicture(string ImagePath, string tThumbImage, string path, int width)
        {
            string ThumbImage = HttpContext.Current.Server.MapPath(tThumbImage);
            string PicPath = HttpContext.Current.Server.MapPath(ImagePath);
            Image NewImage = Image.FromFile(PicPath);
            int ToWidth = width;
            int ToHeight = width;
            int Width = NewImage.Width;
            int Height = NewImage.Height;

            if (Width >= Height)
            {
                ToWidth = width;
                ToHeight = width * Height / Width;
            }
            else
            {
                ToHeight = width;
                ToWidth = width * Width / Height;
            }

            using (Bitmap bitmap = new Bitmap(ToWidth, ToHeight))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High; //高质量插值法
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //高质量，低速度呈平滑程度
                    g.Clear(Color.Transparent); //画布设置透明
                    g.DrawImage(NewImage, new Rectangle(0, 0, ToWidth, ToHeight),
                        new Rectangle(0, 0, Width, Height),
                        GraphicsUnit.Pixel); //设置像素为度量单位
                    NewImage.Dispose();
                    g.Dispose();

                }
                try
                {
                    bitmap.Save(ThumbImage, ImageFormat.Jpeg);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }
                catch (Exception e)
                {
                    bitmap.Dispose();
                }
                finally
                {
                    bitmap.Dispose();
                }
            }
        }
    }
}