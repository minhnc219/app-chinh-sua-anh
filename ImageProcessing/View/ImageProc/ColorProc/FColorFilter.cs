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

namespace ImageProcessing.View.ImageProc.ColorProc
{
    public partial class FColorFilter : Form
    {
        public Bitmap ImageBitmap { get; set; }
        public FColorFilter(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        ColorProcessing colorProc = new ColorProcessing();

        private void FColorFilter_Load(object sender, EventArgs e)
        {
            pbRedColorFilter.Image = colorProc.ColorFilter(ImageBitmap, "Màu đỏ");
            pbGreenColorFilter.Image = colorProc.ColorFilter(ImageBitmap, "Màu lục");
            pbBlueColorFilter.Image = colorProc.ColorFilter(ImageBitmap, "Màu lam");
        }

        #region Handle Selection
        //Select "Red Filter"
        private void pbRedColorFilter_Click(object sender, EventArgs e)
        {
            ImageBitmap = colorProc.ColorFilter(ImageBitmap, "Màu đỏ");
            this.Hide();
        }

        //Select "Green Filter"
        private void pbGreenColorFilter_Click(object sender, EventArgs e)
        {
            ImageBitmap = colorProc.ColorFilter(ImageBitmap, "Màu lục");
            this.Hide();
        }

        //Select "Blue Filter"
        private void pbBlueColorFilter_Click(object sender, EventArgs e)
        {
            ImageBitmap = colorProc.ColorFilter(ImageBitmap, "Màu lam");
            this.Hide();
        }

        #endregion

    }
}
