using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Process
{
    class EffectProcessing
    {
        // Mode: Black and white image
        public Bitmap BlackAndWhiteMode(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color color;
            Byte rgb;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    color = bitmap.GetPixel(x, y);
                    rgb = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
                    result.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }
            return result;
        }

        // Mode: Nagative image
        public Bitmap NagativeImageMode(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color color;
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    color = bitmap.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B));
                }
            }
            return result;
        }
    }
}
