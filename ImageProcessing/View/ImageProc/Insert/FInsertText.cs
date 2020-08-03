using System;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessing.Process;

namespace ImageProcessing.View.ImageProc.Insert
{
    public partial class FInsertText : Form
    {
        public Bitmap ImageBitmap { get; set; }

        public FInsertText(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        InsertProcessing insertProc = new InsertProcessing();

        private void FInsertText_Load(object sender, EventArgs e)
        {
            pbImage.Image = ImageBitmap;
            LoadcbFontName();
            LoadcbFontStyle();
            LoadcbTextColor();
        }        

        #region Load Combo Box
        //Load cbFontName
        private void LoadcbFontName()
        {
            cbFontName.Items.Clear();
            cbFontName.Items.Add("Arial");
            cbFontName.Items.Add("Freestyle Script");
            cbFontName.Items.Add("Lucida Handwriting");
            cbFontName.Items.Add("Snap ITC");
            cbFontName.Items.Add("Times New Roman");
            cbFontName.Items.Add("Vladimir Script");
        }

        //Load cbFontStyle
        private void LoadcbFontStyle()
        {
            cbFontStyle.Items.Clear();
            cbFontStyle.Items.Add("Bình thường");
            cbFontStyle.Items.Add("In đậm");
            cbFontStyle.Items.Add("In nghiêng");
            cbFontStyle.Items.Add("Gạch chân");
            cbFontStyle.Items.Add("Gạch ngang");
        }

        //Load cbTextColor
        private void LoadcbTextColor()
        {
            cbTextColor.Items.Clear();
            cbTextColor.Items.Add("Màu trắng");
            cbTextColor.Items.Add("Màu vàng");
            cbTextColor.Items.Add("Màu da cam");
            cbTextColor.Items.Add("Màu hồng");
            cbTextColor.Items.Add("Màu đỏ");
            cbTextColor.Items.Add("Màu nâu");
            cbTextColor.Items.Add("Màu lục");
            cbTextColor.Items.Add("Màu lam");
            cbTextColor.Items.Add("Màu tím");
            cbTextColor.Items.Add("Màu xám");
            cbTextColor.Items.Add("Màu đen");            
        }

        #endregion

        private void txtFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region Button

        #region Handle insert text
        //Insert Text
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string text = txtTextInsert.Text.Trim();
            string fontName = cbFontName.Text.Trim();
            string fontStyle = cbFontStyle.Text.Trim();
            string textSize = txtFontSize.Text.Trim();
            string textColor = cbTextColor.Text.Trim();
            if(text.Equals("") || fontName.Equals("") || fontStyle.Equals("") || textSize.Equals("") || textColor.Equals(""))
            {
                MessageBox.Show("Điền đầy đủ thông tin văn bản cần chèn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textSize.Equals("0"))
            {
                MessageBox.Show("Kích thước chữ bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chọn vị trí cần chèn trên hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbImage.MouseDown += PbImage_MouseDown;
            }
        }

        //Select position to insert text
        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {           
            string text = txtTextInsert.Text.Trim();
            string fontName = cbFontName.Text.Trim();
            string fontStyle = cbFontStyle.Text.Trim();
            int textSize = int.Parse(txtFontSize.Text.Trim());
            string textColor = cbTextColor.Text.Trim();
            pbImage.Image = insertProc.InsertText(ImageBitmap, text, e.X, e.Y, fontName, textSize, fontStyle, textColor);
        }
        #endregion

        //Reset
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

        //Save
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn lưu chỉnh sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ImageBitmap = (Bitmap)pbImage.Image;               
            }
            else
                return;
        }

        #endregion


    }
}
