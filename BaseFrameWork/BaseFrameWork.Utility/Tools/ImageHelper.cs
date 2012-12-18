using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace BaseFrameWork.Utility.Tools
{
    /// <summary>
    /// 图片工具类
    /// </summary>
    public static class ImageHelper
    {
        /// <summary>
        /// 压缩JPG图片
        /// </summary>
        /// <param name="NewfileName">压缩后图片存放的地址</param>
        /// <param name="OldfileName">需要压缩的图片地址</param>
        /// <param name="quality">压缩质量：如果为0则默认调整为80</param>
        public static void SetCompressImage(string NewfileName, string OldfileName, long quality)
        {
            if (quality == 0)
            {
                quality = 80;
            }
            using (Bitmap bitmp = new Bitmap(OldfileName))
            {
                EncoderParameters ep = new EncoderParameters(1);
                ep.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
                bitmp.Save(NewfileName, myImageCodecInfo, ep);
                bitmp.Dispose();
            }
        }
        /// <summary>
        /// 返回高清缩略图
        /// </summary>
        /// <param name="fileName">原文件</param>
        /// <param name="newFile">新文件</param>
        /// <param name="maxHeight">最大高度</param>
        /// <param name="maxWidth">最大宽度</param>
        /// <param name="qualitys">质量，如果为0，则设为80</param>
        public static void SetGoodImage(string fileName, string newFile, int maxHeight, int maxWidth,long qualitys)
        {
            if (qualitys == 0)
            {
                qualitys = 80;
            }
            using (System.Drawing.Image img = System.Drawing.Image.FromFile(fileName))
            {
                System.Drawing.Imaging.ImageFormat
                thisFormat = img.RawFormat;
                Size newSize = NewSize(maxWidth, maxHeight, img.Width, img.Height);
                Bitmap outBmp = new Bitmap(newSize.Width, newSize.Height);
                Graphics g = Graphics.FromImage(outBmp);
                // 设置画布的描绘质量
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Rectangle(0, 0, newSize.Width, newSize.Height),
                0, 0, img.Width, img.Height, GraphicsUnit.Pixel);
                g.Dispose();
                // 以下代码为保存图片时,设置压缩质量
                EncoderParameters encoderParams = new EncoderParameters();
                long[] quality = new long[1];
                quality[0] = qualitys;
                EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                encoderParams.Param[0] = encoderParam;
                //获得包含有关内置图像编码解码器的信息的ImageCodecInfo 对象.
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICI = null;
                for (int x = 0;
                x < arrayICI.Length;
                x++)
                {
                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {
                        jpegICI = arrayICI[x];
                        //设置JPEG编码
                        break;
                    }
                }
                if (jpegICI != null)
                {
                    outBmp.Save(newFile, jpegICI, encoderParams);
                }
                else
                {
                    outBmp.Save(newFile, thisFormat);
                }
                img.Dispose();
                outBmp.Dispose();
            }
        }
        // 得到到按比例最佳尺寸
        private static Size NewSize(int maxWidth, int maxHeight, int width, int height)
        {
            double w = 0.0;
            double h = 0.0;
            double sw = Convert.ToDouble(width);
            double sh = Convert.ToDouble(height);
            double mw = Convert.ToDouble(maxWidth);
            double mh = Convert.ToDouble(maxHeight);
            if (sw < mw && sh < mh)
            {
                w = sw;
                h = sh;
            }
            else if ((sw / sh) > (mw / mh))
            {
                w = maxWidth;
                h = (w * sh) / sw;
            }
            else
            {
                h = maxHeight;
                w = (h * sw) / sh;
            }
            return new Size(Convert.ToInt32(w), Convert.ToInt32(h));
        }
        /// <summary>
        ///   得到图片类型
        /// </summary>
        /// <param name="mimeType"></param>
        /// <returns></returns>
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
        /// <summary>
        /// 添加水印效果
        /// </summary>
        /// <param name="fileName">输入路径</param>
        /// <param name="newfileName">输出路径</param>
        /// <param name="WaterImg">水印文件路径</param>
        /// <param name="RightSpace">水印靠近图片右边的像素</param>
        /// <param name="BottomSpace">水印靠近底边的像素</param>
        /// <param name="LucencyPercent">透明度</param>
        public static void SetWaterMark( string fileName, string newfileName,string WaterImg,int RightSpace,int BottomSpace,int LucencyPercent)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(fileName))
            {
                ImageModification wm = new ImageModification();
                wm.DrawedImagePath = WaterImg; //水印图片
                wm.ModifyImagePath = fileName;   //图片的路径
                wm.RightSpace = RightSpace;        //水印位置
                wm.BottoamSpace = image.Height - BottomSpace;       //水银位置
                wm.LucencyPercent = LucencyPercent;          //透明度
                wm.OutPath = newfileName;         //生成的文件名
                wm.DrawImage();
                image.Dispose();
            }
        }
    }
}
