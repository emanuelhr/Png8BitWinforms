using nQuant;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Png8BitCadenas
{

    public  class PictureManipulation  : IDisposable
    {
        public  bool ConvertPicture(string path, int width=400, int height=400)
        {

            FileInfo fileInfo = new FileInfo(path);
            var newPath = new StringBuilder(path);
           
            newPath.Remove(newPath.Length - fileInfo.Extension.Length, fileInfo.Extension.Length);
            newPath.Append(".png");
            using (var originalImage = new Bitmap(path))
            {
                if (originalImage.Size != new Size(width, height) || originalImage.PixelFormat != PixelFormat.Format32bppArgb)
                {
                    Bitmap newImage = OriginalImageScale(originalImage, width, height);
                    if (newPath.ToString() == path)
                    {
                        var lastIndex = newPath.ToString().LastIndexOf(@"\");
                        var random = new Random();
                        newPath.Insert(lastIndex + 1, random.Next(0, 6000).ToString());
                    }

                    To8BitPng(newPath.ToString(), newImage);
                    return true;
                }
                return false;
            }
            
        }

        public  void  To8BitPng(string path, Bitmap image)
        {
            try
            {
                var quantizer = new WuQuantizer();
                using (var quantized = quantizer.QuantizeImage(image))
                {
                    quantized.Save(path, ImageFormat.Png);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        //returns original image scaled
        public  Bitmap OriginalImageScale(Bitmap image, float width, float height)
        {
            float scale = Math.Min(width / image.Width, height / image.Height);
            var brush = new SolidBrush(Color.White);
            var bmp = new Bitmap((int)width, (int)height);
            using (var graph = Graphics.FromImage(bmp))
            {
                graph.InterpolationMode = InterpolationMode.High;
                graph.CompositingQuality = CompositingQuality.HighQuality;
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                var scaleWidth = (int)(image.Width * scale);
                var scaleHeight = (int)(image.Height * scale);
                graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
                graph.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);
            }
            return bmp;
        }

        public  bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}