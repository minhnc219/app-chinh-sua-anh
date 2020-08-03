using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing.Process
{
    class InsertProcessing
    {
        #region Insert text
        //Insert text
        public Bitmap InsertText(Bitmap imageBitmap, string text, int xPos, int yPos, string fontName, int fontSize, string fontStyleVina, string colorVina)
        {
            Bitmap tmpImage = (Bitmap)imageBitmap.Clone();
            Graphics graphics = Graphics.FromImage(tmpImage);
            FontStyle fontStyle = FontStyle.Regular;
            switch(fontStyleVina)
            {
                case "Bình thường":
                    fontStyle = FontStyle.Regular;
                    break;
                case "In đậm":
                    fontStyle = FontStyle.Bold;
                    break;
                case "In nghiêng":
                    fontStyle = FontStyle.Italic;
                    break;
                case "Gạch chân":
                    fontStyle = FontStyle.Underline;
                    break;
                case "Gạch ngang":
                    fontStyle = FontStyle.Strikeout;
                    break;
            }
            Font font = new Font(fontName, fontSize, fontStyle);
            Color color = SelectColor(colorVina);
            int gW = (int)(text.Length * fontSize);
            LinearGradientBrush LGBrush = new LinearGradientBrush(new Rectangle(0, 0, gW, fontSize), color, color, LinearGradientMode.Vertical);
            graphics.DrawString(text, font, LGBrush, xPos, yPos);
            return (Bitmap)tmpImage.Clone();
        }

        //Select color by vietnamese
        private Color SelectColor(string colorVina)
        {      
            if(colorVina.Equals("Màu trắng"))            
                return Color.White;
            else if (colorVina.Equals("Màu vàng"))
                return Color.Yellow;
            else if (colorVina.Equals("Màu da cam"))
                return Color.Orange;
            else if (colorVina.Equals("Màu hồng"))
                return Color.Pink;
            else if (colorVina.Equals("Màu đỏ"))
                return Color.Red;
            else if (colorVina.Equals("Màu nâu"))
                return Color.Brown;
            else if (colorVina.Equals("Màu lục"))
                return Color.Green;
            else if (colorVina.Equals("Màu lam"))
                return Color.Blue;
            else if (colorVina.Equals("Màu tím"))
                return Color.Purple;
            else if (colorVina.Equals("Màu xám"))
                return Color.Gray;
            else 
                return Color.Black;                       
        }

        #endregion

        #region Insert Image        
        public Bitmap InsertImage(Bitmap imageBitmap, Bitmap insertImage, int xPos, int yPos)
        {
            Bitmap tmpImage = (Bitmap)imageBitmap.Clone();
            Graphics graphics = Graphics.FromImage(tmpImage);
            Rectangle rectangle = new Rectangle(xPos, yPos, insertImage.Width, insertImage.Height);
            graphics.DrawImage(insertImage, rectangle);
            return (Bitmap)tmpImage.Clone();
        }
        #endregion

        #region Insert shape
        public Bitmap InsertShape(Bitmap imageBitmap, string shapeName, Rectangle rectangle, Color shapeColor)
        {
            Bitmap tmpImage = (Bitmap)imageBitmap.Clone();
            Graphics graphics = Graphics.FromImage(tmpImage);
            Pen pen = new Pen(shapeColor);

            if(shapeName.Equals("Hình chữ nhật"))
            {
                graphics.DrawRectangle(pen, rectangle);
            }
            else if(shapeName.Equals("Hình tròn"))
            {
                graphics.FillEllipse(pen.Brush, rectangle);
            }
            else if (shapeName.Equals("Đường tròn"))
            {
                graphics.DrawEllipse(pen, rectangle);
            }

            return (Bitmap)tmpImage.Clone();
        }

        #endregion
    }
}
