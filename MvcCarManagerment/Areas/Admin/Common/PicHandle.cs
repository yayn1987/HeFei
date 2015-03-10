using System;
using System.IO;
using System.Web;

using System.Drawing;

namespace MvcCarManagerment.Areas.Admin.Common
{
    public class PicHandle
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
                    bitmap.Save(ThumbImage, System.Drawing.Imaging.ImageFormat.Jpeg);
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
        /// 给定一个矩形（长方形 正方形）剪切的范围 传入一张图片的原始尺寸 
        /// 得到一个在该矩形范围内的最佳尺寸(原图的比例不会变)
        /// </summary>
        /// <param name="specifySize">指定尺寸</param>
        /// <param name="originalSize">原始尺寸</param>
        /// <returns>返回（原图片等比例）最佳尺寸</returns>
        private static Size ResizeSite(Size specifySize, Size originalSize)
        {
            Size finaSize = new Size();
            float specifyScale = (float)specifySize.Width / (float)specifySize.Height;
            float originalScale = (float)originalSize.Width / (float)originalSize.Height;
            // 以width为准
            if (specifyScale < originalScale)
            {
                finaSize.Height = (int)(originalSize.Width / specifyScale);
                finaSize.Width = originalSize.Width;
            }
            // 以height为准
            else
            {
                finaSize.Height = originalSize.Height;
                finaSize.Width = (int)(originalSize.Height * specifyScale);
            }
            return finaSize;
        }


        /// <summary>
        /// 缩放图片 按比例 如果指定的尺寸和原图片尺寸比例不等，会留空边
        /// </summary>
        /// <param name="postedFile">原图HttpPostedFileBase对象</param>
        /// <param name="savePath">保存图片的绝对路径 包括图片名</param>
        /// <param name="newWidth">指定宽度</param>
        /// <param name="newHeight">指定高度</param>
        public static void ResizeImage(System.Web.HttpPostedFileBase postedFile,
            string savePath, int newWidth, int newHeight)
        {
            //创建目录
            string dir = Path.GetDirectoryName(savePath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            //原始图片（获取原始图片创建对象，并使用流中嵌入的颜色管理信息）
            System.Drawing.Image originalImage =
                System.Drawing.Image.FromStream(postedFile.InputStream, true);

            int ow = originalImage.Width;//原始宽度
            int oh = originalImage.Height;//原始高度

            Size toSize = ResizeSite(new Size(newWidth, newHeight), new Size(ow, oh));
            int towidth = toSize.Width;//原图片缩放后的宽度
            int toheight = toSize.Height;//原图片缩放后的高度

            int x = 0;
            int y = 0;

            x = (towidth - ow) / 2;
            y = (toheight - oh) / 2;

            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.InterpolationMode =
                System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            g.Clear(System.Drawing.Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new System.Drawing.Rectangle(x, y, ow, oh),
            new System.Drawing.Rectangle(0, 0, ow, oh),
            System.Drawing.GraphicsUnit.Pixel);
            //--------------------------------------------------------------------------------

            ////新建一个bmp图片2
            //System.Drawing.Image bitmap2 = new System.Drawing.Bitmap(newWidth, newHeight);
            ////新建一个画板2
            //System.Drawing.Graphics g2 = System.Drawing.Graphics.FromImage(bitmap2);
            ////设置高质量插值法
            //g2.InterpolationMode =
            //    System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            ////设置高质量,低速度呈现平滑程度
            //g2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            ////清空画布并以黑色背景色填充
            //g2.Clear(System.Drawing.Color.Black);
            //g2.DrawImageUnscaled(bitmap, new Point(x, y));

            try
            {
                //以jpg格式保存缩略图
                bitmap.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                //bitmap2.Dispose();
                //g2.Dispose();
                g.Dispose();
            }
        }
    }
}
