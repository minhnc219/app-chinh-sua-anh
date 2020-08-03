using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing.View.ImageProc
{
    public partial class FDrop : Form
    {
        public Bitmap ImageBitmap { get; set; }
        public Rectangle rectangle { get; set; }

        public FDrop(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        Point StartLocation;            // Store starting location
        Point EndLocation;              // Store ending location
        bool IsMouseDown = false;       // = true if mouse down

        private void FDrop_Load(object sender, EventArgs e)
        {
            pbImage.Image = ImageBitmap;            
        }      
       
        #region Handle drop        
        //Confirm starting location
        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            StartLocation = e.Location;         // Get starting location            
        }

        //Confirm current location
        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                EndLocation = e.Location;           // Get current location 
                pbImage.Paint += PbImage_Paint;
                Refresh();
            }
        }

        //confirm ending location
        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                IsMouseDown = false;
                EndLocation = e.Location;           // Get ending location
                pbImage.Paint += PbImage_Paint;

                //Confirm drop image by button
                if (rectangle != null && rectangle.Width != 0 && rectangle.Height != 0)
                {
                    Bitmap tmpBitmap = ImageBitmap;
                    Bitmap tmpImage = (Bitmap)tmpBitmap.Clone();
                    pbImage.Image = (Bitmap)tmpImage.Clone(rectangle, tmpImage.PixelFormat);
                }
            }
        }

        //Draw shape to drop
        private void PbImage_Paint(object sender, PaintEventArgs e)
        {
            rectangle = GetLocationAndSize();           

            if (rectangle != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, rectangle);
            }
        }

        //Get location and size of shape
        private Rectangle GetLocationAndSize()
        {
            Rectangle rect = new Rectangle();
            rect.X = Math.Min(StartLocation.X, EndLocation.X);         //Get X-position of shape 
            rect.Y = Math.Min(StartLocation.Y, EndLocation.Y);         //Get X-position of shape 

            rect.Width = Math.Abs(StartLocation.X - EndLocation.X);    //Get width of shape 
            rect.Height = Math.Abs(StartLocation.Y - EndLocation.Y);   //Get height of shape

            return rect;
        }

        #endregion

        #region Button 
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn chỉnh sửa lại từ đầu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                pbImage.Image = ImageBitmap;
            }
            else
                return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu chỉnh sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ImageBitmap = (Bitmap)pbImage.Image;
                this.Hide();
            }
            else
                return;
        }

        #endregion
    }
}
