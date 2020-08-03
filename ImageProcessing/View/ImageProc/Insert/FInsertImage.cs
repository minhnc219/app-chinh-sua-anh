using System;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessing.Process;

namespace ImageProcessing.View.ImageProc.Insert
{
    public partial class FInsertImage : Form
    {
        public Bitmap ImageBitmap { get; set; }
        public Bitmap InsertImage { get; set; }

        public FInsertImage(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        ResizeProcessing resizeProc = new ResizeProcessing();
        InsertProcessing insertProc = new InsertProcessing();

        private void FInsertImage_Load(object sender, EventArgs e)
        {
            pbImage.Image = ImageBitmap;            
        }

        #region Button
        //Button Insert Image
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            //Check Insert Image Null Or Not Null
            if (pbInsertImage.Image == null)
            {
                MessageBox.Show("Không có ảnh để chèn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chọn vị trí cần chèn trên hình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pbImage.MouseDown += PbImage_MouseDown;
            }
        }

        //Button Reset
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

        //Button Save
        private void btnSave_Click(object sender, EventArgs e)
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

        //Select position to insert image
        private void PbImage_MouseDown(object sender, MouseEventArgs e)
        {
            pbImage.Image = insertProc.InsertImage(ImageBitmap, (Bitmap)pbInsertImage.Image, e.X, e.Y);
        }

        #region Handle insert image
        //Load Insert Image
        private void pbInsertImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {        
                InsertImage = new Bitmap(openFile.FileName);
                pbInsertImage.Image = InsertImage;
            }
            else
            {
                MessageBox.Show("Không tải được ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }              

        #region Handle text box size of insert image
        private void txtInsertImageSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInsertImageSize_TextChanged(object sender, EventArgs e)
        {
            if (pbInsertImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chèn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string insertImageSize = txtInsertImageSize.Text.Trim();
                if (insertImageSize.Equals("") || insertImageSize.Equals("0"))
                {
                    MessageBox.Show("Không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                else
                {
                    pbInsertImage.Image = resizeProc.Resize(InsertImage, int.Parse(insertImageSize));
                }
            }            
        }

        #endregion

        #endregion      
       
    }
}
