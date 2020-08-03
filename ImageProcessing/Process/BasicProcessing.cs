using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Process
{
    class BasicProcessing
    {
        //Contrast and bightness processing
        public Bitmap ContrastAndBrightnessProc(Bitmap imageBitmap, int contrastValue, int brightnessValue)
        {
            Bitmap result = new Bitmap(imageBitmap.Width, imageBitmap.Height);
            BitmapData sourceData = imageBitmap.LockBits(new Rectangle(0, 0,
                            imageBitmap.Width, imageBitmap.Height),
                            ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            imageBitmap.UnlockBits(sourceData);

            //Formula Compute Contrust level : CL =  { (100 + contrustValue) / 100} ^ 2
            double contrastLevel = Math.Pow((100.0 + contrastValue) / 100.0, 2);

            double blue = 0;
            double green = 0;
            double red = 0;

            //Formula compute value 's color with Contrust level
            //      newColorValueTmp = [ ( oldColorValue / 255 - 0.5 ) * CL + 0.5 ] * 255
            //Formula compute value 's color with contrust level and brightValue
            //      newColorValue = newColorValueTmp + brightValue
            for (int k = 0; k + 3 < pixelBuffer.Length; k += 3) 
            {
                blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                           contrastLevel) + 0.5) * 255.0 + brightnessValue;

                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                            contrastLevel) + 0.5) * 255.0 + brightnessValue;

                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                           contrastLevel) + 0.5) * 255.0 + brightnessValue;

                if (blue > 255)
                { blue = 255; }
                else if (blue < 0)
                { blue = 0; }

                if (green > 255)
                { green = 255; }
                else if (green < 0)
                { green = 0; }

                if (red > 255)
                { red = 255; }
                else if (red < 0)
                { red = 0; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }            

            BitmapData resultData = result.LockBits(new Rectangle(0, 0, result.Width, result.Height),
                                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            result.UnlockBits(resultData);           
            return result;
        }
       
    }
}
