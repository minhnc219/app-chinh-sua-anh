using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Process
{
    class ResizeProcessing
    {
        //Resize
        public Bitmap Resize(Bitmap bitmap, float percentage)
        {
            //Get original size of image
            int originalWidth = bitmap.Width;
            int originalHeight = bitmap.Height;

            //Compute new size of image
            int newWidth = (int)(originalWidth * percentage / 100);
            int newHeight = (int)(originalHeight * percentage / 100);

            Bitmap result = new Bitmap(newWidth, newHeight);

            //Create graphic from result
            Graphics graphic = Graphics.FromImage((Image)result);

            //Draw with new size
            graphic.DrawImage((Image)bitmap, 0, 0, newWidth, newHeight);
            graphic.Dispose();

            return result;
        }
    }
}
