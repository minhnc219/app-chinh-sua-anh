using System;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessing.Process;

namespace ImageProcessing.View.ImageProc.Insert
{
    public partial class FInsertShape : Form
    {
        public Rectangle rectangle { get; set; }
        public Bitmap ImageBitmap { get; set; }

        public FInsertShape(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        InsertProcessing insertProc = new InsertProcessing();

        bool InsertShape = false;
        Point StartLocation;            // Store starting location
        Point EndLocation;              // Store ending location
        bool IsMouseDown = false;       // = true if mouse down
        
        private void FInsertShape_Load(object sender, EventArgs e)
        {
            pbImage.Image = ImageBitmap;
            LoadcbShapeName();
            LoadcbShapeColor();
        }

        #region Load Combo Box
        //Combo Box Shape Name
        private void LoadcbShapeName()
        {
            cbShapeName.Items.Clear();
            cbShapeName.Items.Add("Hình chữ nhật");
            cbShapeName.Items.Add("Hình tròn");
            cbShapeName.Items.Add("Đường tròn");
        }

        //Combo Box Shape Color
        private void LoadcbShapeColor()
        {
            cbShapeColor.Items.Clear();
            cbShapeColor.Items.Add("Màu trắng");
            cbShapeColor.Items.Add("Màu vàng");
            cbShapeColor.Items.Add("Màu da cam");
            cbShapeColor.Items.Add("Màu hồng");
            cbShapeColor.Items.Add("Màu đỏ");
            cbShapeColor.Items.Add("Màu nâu");
            cbShapeColor.Items.Add("Màu lục");
            cbShapeColor.Items.Add("Màu lam");
            cbShapeColor.Items.Add("Màu tím");
            cbShapeColor.Items.Add("Màu xám");
            cbShapeColor.Items.Add("Màu đen");
        }

        #endregion

        #region Handle Insert Shape        
        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (InsertShape == true)
            {
                IsMouseDown = true;
                StartLocation = e.Location;     //Get starting location        
            }
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                EndLocation = e.Location;   //Get current location
                pbImage.Paint += PbImage_Paint;
                Refresh();
            }            
        }

        //Draw shape on picture
        private void PbImage_Paint(object sender, PaintEventArgs e)
        {
            rectangle = GetLocationAndSize();
            string shapeName = cbShapeName.Text.Trim();
            Color shapeColor = SelectColor(cbShapeColor.Text.Trim());
            Pen pen = new Pen(shapeColor);

            if(rectangle != null)
            {
                if(shapeName.Equals("Hình chữ nhật"))
                {
                    e.Graphics.DrawRectangle(pen, rectangle);       
                }
                else if (shapeName.Equals("Hình tròn"))
                {
                    e.Graphics.FillEllipse(pen.Brush, rectangle);
                }
                else if (shapeName.Equals("Đường tròn"))
                {
                    e.Graphics.DrawEllipse(pen, rectangle);
                }
                else
                {
                    e.Graphics.DrawRectangle(pen, rectangle);
                }
            }
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            if(IsMouseDown == true)
            {
                EndLocation = e.Location;   //Get ending location
                IsMouseDown = false;
                pbImage.Paint += PbImage_Paint;
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

        //Select color by vietnamese
        private Color SelectColor(string colorVina)
        {
            if (colorVina.Equals("Màu trắng"))
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

        #region Button         
        private void btnInsertShape_Click(object sender, EventArgs e)
        {
            string shapeName = cbShapeName.Text.Trim();
            string shapeColor = cbShapeColor.Text.Trim();
            if(shapeName.Equals("") || shapeColor.Equals(""))
            {
                MessageBox.Show("Điền đầy đủ thông tin của hình cần chèn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {               
                MessageBox.Show("Vẽ trên ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InsertShape = true;               
            }
        }        

        //Reset to initial image
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

        //Save change
        private void btnSave_Click(object sender, EventArgs e)
        {
            string shapeName = cbShapeName.Text.Trim();
            Color shapeColor = SelectColor(cbShapeColor.Text.Trim());

            DialogResult dr = MessageBox.Show("Bạn có muốn lưu chỉnh sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ImageBitmap = insertProc.InsertShape(ImageBitmap,shapeName,rectangle,shapeColor);                
            }
            else
                return;
        }

        #endregion        
    }
}
