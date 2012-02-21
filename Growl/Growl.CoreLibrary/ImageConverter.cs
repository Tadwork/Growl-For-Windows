using System;
using System.Drawing;

namespace Growl.CoreLibrary
{
    /// <summary>
    /// Converts Image objects to byte arrays, as well as converting byte arrays and
    /// url references into Images.
    /// </summary>
    public static class ImageConverter
    {
        /// <summary>
        /// Converts the specified <see cref="System.Drawing.Image"/> into an array of bytes
        /// </summary>
        /// <param name="image"><see cref="System.Drawing.Image"/></param>
        /// <returns>Array of bytes</returns>
        public static byte[] ImageToBytes(System.Drawing.Image image)
        {
            byte[] bytes = null;
            if (image != null)
            {
                lock (image)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    using (ms)
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        bytes = ms.GetBuffer();
                    }
                }
            }
            return bytes;
        }

        /// <summary>
        /// Converts an array of bytes into an <see cref="System.Drawing.Image"/>
        /// </summary>
        /// <param name="bytes">The array of bytes</param>
        /// <returns>The resulting <see cref="System.Drawing.Image"/></returns>
        public static System.Drawing.Image ImageFromBytes(byte[] bytes)
        {
            System.Drawing.Image image = null;
            try
            {
                if (bytes != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes, false);
                    using (ms)
                    {
                        image = ImageFromStream(ms);
                    }
                }
            }
            catch
            {
            }
            return image;
        }

        /// <summary>
        /// Converts a url (filesystem or web) into an <see cref="System.Drawing.Image"/>
        /// </summary>
        /// <param name="url">The url path to the image</param>
        /// <returns>The resulting <see cref="System.Drawing.Image"/></returns>
        public static System.Drawing.Image ImageFromUrl(string url)
        {
            System.Drawing.Image image = null;
            try
            {
                if (!String.IsNullOrEmpty(url))
                {
                    Uri uri = new Uri(url);
                    if (uri.IsFile)
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(uri.LocalPath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
                        using (fs)
                        {
                            image = ImageFromStream(fs);
                        }
                    }
                    else
                    {
                        WebClientEx wc = new WebClientEx();
                        using (wc)
                        {
                            byte[] bytes = wc.DownloadData(uri);
                            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes, false);
                            using (ms)
                            {
                                image = ImageFromStream(ms);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            return image;
        }

        private static System.Drawing.Image ImageFromStream(System.IO.Stream stream)
        {
            System.Drawing.Image image = null;
            try
            {
                stream.Position = 0;
                System.Drawing.Image tempImage = System.Drawing.Bitmap.FromStream(stream);
                // dont close stream yet, first create a copy
                using (tempImage)
                {
                    image = new Bitmap(tempImage);
                }
            }
            catch
            {
                // the file could be an .ico file that is not usable by the Image class, so try that just in case
                try
                {
                    stream.Position = 0;
                    Icon icon = new Icon(stream);
                    if (icon != null) image = icon.ToBitmap();
                }
                catch
                {
                    // give up - we cant open this file type
                }
            }

            return image;
        }


        /* I AM JUST SAVING THIS FOR NOW
        private byte[] ConvertToBytes2(Bitmap bmp)
        {
            System.Drawing.Imaging.BitmapData bData = bmp.LockBits(new Rectangle(new Point(), bmp.Size),
            System.Drawing.Imaging.ImageLockMode.ReadOnly,
            System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            // number of bytes in the bitmap
            int byteCount = bData.Stride * bmp.Height;
            byte[] bmpBytes = new byte[byteCount];

            // Copy the locked bytes from memory
            System.Runtime.InteropServices.Marshal.Copy(bData.Scan0, bmpBytes, 0, byteCount);

            // don't forget to unlock the bitmap!!
            bmp.UnlockBits(bData);

            return bmpBytes;
        }
         * */
    }
}
