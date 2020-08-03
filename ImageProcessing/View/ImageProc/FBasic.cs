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

namespace ImageProcessing.View.ImageProc
{
    public partial class FBasic : Form
    {
        public Bitmap ImageBitmap { get; set; }
        public FBasic(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        BasicProcessing basicProc = new BasicProcessing();

        private void FBasic_Load(object sender, EventArgs e)
        {
            pbBasic.Image = ImageBitmap;
        }

        //Handle Brightness
        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            pbBasic.Image = basicProc.ContrastAndBrightnessProc(ImageBitmap, tbContrast.Value, tbBrightness.Value);
        }

        //Handle Contrast
        private void tbContrast_Scroll(object sender, EventArgs e)
        {
            pbBasic.Image = basicProc.ContrastAndBrightnessProc(ImageBitmap, tbContrast.Value, tbBrightness.Value);
        }

        //Save Basic Processing 
        private void btnConfirmBasicProc_Click(object sender, EventArgs e)
        {
            ImageBitmap = basicProc.ContrastAndBrightnessProc(ImageBitmap, tbContrast.Value, tbBrightness.Value);           
            this.Hide();
        }
    }
}
