using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Process
{
    class ColorProcessing
    {
        //Color filter
        public Bitmap ColorFilter(Bitmap bitmap, string colorFilter)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color color;
            //Filter red color
            if (colorFilter.Equals("Màu đỏ"))
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        color = bitmap.GetPixel(x, y);
                        result.SetPixel(x, y, Color.FromArgb((byte)color.R, 0, 0));
                    }
                }
            }
            //Filter green color
            else if(colorFilter.Equals("Màu lục"))
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        color = bitmap.GetPixel(x, y);
                        result.SetPixel(x, y, Color.FromArgb(0, (byte)color.G, 0));
                    }
                }
            }
            //Filter blue color
            else if (colorFilter.Equals("Màu lam"))
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        color = bitmap.GetPixel(x, y);
                        result.SetPixel(x, y, Color.FromArgb(0, 0, (byte)color.B));
                    }
                }
            }
            
            return result;
        }
    }
}
