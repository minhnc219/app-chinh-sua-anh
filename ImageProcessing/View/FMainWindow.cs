using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessing.Process;
using ImageProcessing.View.ImageProc.ColorProc;
using ImageProcessing.View.ImageProc;
using ImageProcessing.View.ImageProc.Insert;
using ImageProcessing.View.Histogram;
using System.Drawing.Drawing2D;

namespace ImageProcessing.View
{
    public partial class FMainWindow : Form
    {
        public Bitmap ImageBitmap { get; set; }
        public FMainWindow(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        ColorProcessing colorProc = new ColorProcessing();
        EffectProcessing effectProc = new EffectProcessing();
        ResizeProcessing resizeProc = new ResizeProcessing();

        private void FMainWindow_Load(object sender, EventArgs e)
        {

        }

        #region ToolStripMenuItem Option
        //Load image
        private void tsLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ImageBitmap = new Bitmap(openFile.FileName);
                pbImage.Image = ImageBitmap;
            }
            else
            {
                MessageBox.Show("Không tải được ảnh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Save image
        private void tsSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPG(*.JPG)|*.jpg";
            if(pbImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chỉnh sửa !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image.Save(saveFileDialog.FileName);
                }
            }
        }        

        #endregion        

        #region ToolStripMenuItem Image Processing
        //Check survival of Image
        private void tsImageProcessing_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tsImageProcessing.HideDropDown();
                tsLoadImage_Click(sender, e);
            }
            else
            {
                FMainWindow_Load(sender, e);
            }
        }
        private void tsImageProcessing_MouseHover(object sender, EventArgs e)
        {
            tsImageProcessing_Click(sender, e);
        }

        #region Basic Processing
        private void tsBasicProc_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FBasic fBasic = new FBasic(ImageBitmap);
                fBasic.ShowDialog();
                ImageBitmap = fBasic.ImageBitmap;
                pbImage.Image = ImageBitmap;
            }
        }
        
        #endregion

        #region Color Processing       
        //Color Filter Processing
        private void tsColorFilterProc_Click(object sender, EventArgs e)
        {
            FColorFilter fColorFilter = new FColorFilter(ImageBitmap);
            fColorFilter.ShowDialog();
            ImageBitmap = fColorFilter.ImageBitmap;
            pbImage.Image = ImageBitmap;
        }

        //Effect Processing
        private void tsEffectProc_Click(object sender, EventArgs e)
        {
            FEffect fEffect = new FEffect(ImageBitmap);
            fEffect.ShowDialog();
            ImageBitmap = fEffect.ImageBitmap;
            pbImage.Image = ImageBitmap;
        }

        #endregion

        #region Resize Processing         
        private void tsTxtRate_TextChanged(object sender, EventArgs e)
        {
            if (tsTxtRate.Text.Equals(""))
            {
                MessageBox.Show("Không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pbImage.Image = resizeProc.Resize(ImageBitmap, int.Parse(tsTxtRate.Text));
            }
        }

        //Save or not save change
        private void tsSizeProc_DropDownClosed(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn lưu thay đổi ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ImageBitmap = (Bitmap)pbImage.Image;
            }
            else
            {
                pbImage.Image = ImageBitmap;
            }
        }

        //Enter letter is invalid
        private void tsTxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Rotation Processing        
        //Rotate 90 degrees
        private void tsRotstion90_Click(object sender, EventArgs e)
        {
            ImageBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbImage.Image = ImageBitmap;
        }

        //Rotate -90 degrees
        private void tsRotation270_Click(object sender, EventArgs e)
        {
            ImageBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbImage.Image = ImageBitmap;
        }

        //Flip
        private void tsFlipping_Click(object sender, EventArgs e)
        {
            ImageBitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
            pbImage.Image = ImageBitmap;
        }

        #endregion

        #region Drop Processing
        private void tsCropProc_Click(object sender, EventArgs e)
        {
            FDrop fDrop = new FDrop(ImageBitmap);
            fDrop.ShowDialog();
            ImageBitmap = fDrop.ImageBitmap;
            pbImage.Image = ImageBitmap;
        }

        #endregion

        #region Insert Processing
        //Check survival of Image
        private void tsInsertProc_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FMainWindow_Load(sender, e);
            }
        }

        //Insert Text
        private void tsInsertText_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FInsertText fInsertText = new FInsertText(ImageBitmap);
                fInsertText.ShowDialog();
                ImageBitmap = fInsertText.ImageBitmap;
                pbImage.Image = ImageBitmap;
            }            
        }

        //Insert Image
        private void tsInsertImage_Click(object sender, EventArgs e)
        {
            FInsertImage fInsertImage = new FInsertImage(ImageBitmap);
            fInsertImage.ShowDialog();
            ImageBitmap = fInsertImage.ImageBitmap;
            pbImage.Image = ImageBitmap;
        }

        //Insert Shape
        private void tsInsertShape_Click(object sender, EventArgs e)
        {
            FInsertShape fInsertShape = new FInsertShape(ImageBitmap);
            fInsertShape.ShowDialog();
            ImageBitmap = fInsertShape.ImageBitmap;
            pbImage.Image = ImageBitmap;
        }

        #endregion

        #endregion

        #region ToolStripMenuItem Histogram        
        private void tsHistogram_Click(object sender, EventArgs e)
        {
            //Check survival of Image
            if (pbImage.Image == null)
            {
                MessageBox.Show("Không có ảnh chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FHistogram fHistogram = new FHistogram(ImageBitmap);
                fHistogram.ShowDialog();
            }
        }

        #endregion
        
    }
}
