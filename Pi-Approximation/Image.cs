using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Pi_Approximation
{
    public class Image
    {
        #region Constants
        private const double tolerance = 0.0025;
        #endregion

        #region Properties
        public int Width { get; }

        public int Height { get; }

        public Bitmap Data { get; }
        #endregion

        #region Constructors
        public Image(int size, bool inscribeCircle = false)
        {
            this.Width = this.Height = size;
            this.Data = new Bitmap(size, size, PixelFormat.Format24bppRgb);
            BitmapData data = this.Data.LockBits(new Rectangle(0, 0, size, size), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            byte[] bytes = new byte[size * size * 3];
            if (inscribeCircle)
            {
                double r = (size - 1d) / 2d;
                int index = 0;
                for (int j = 0; j < size; j++)
                {
                    double y2 = (j / r) - 1d;
                    y2 *= y2;
                    for (int i = 0; i < size; i++)
                    {
                        double x2 = (i / r) - 1d;
                        x2 *= x2;
                        byte value = Math.Abs(x2 + y2 - 1d) <= tolerance || Math.Abs(x2 + y2) <= tolerance / 100d ? byte.MinValue : byte.MaxValue;
                        bytes[index++] = value;
                        bytes[index++] = value;
                        bytes[index++] = value;
                    }
                }
            }
            else
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = byte.MaxValue;
                }
            }
            Marshal.Copy(bytes, 0, data.Scan0, bytes.Length);
            this.Data.UnlockBits(data);
        }

        public Image(Bitmap image)
        {
            this.Width = image.Width;
            this.Height = image.Height;
            this.Data = image;
        }
        #endregion

        #region Operators
        public static implicit operator Bitmap(Image image) => image.Data;

        public static explicit operator Image(Bitmap image) => new Image(image);
        #endregion
    }
}