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
    public partial class FEffect : Form
    {
        public Bitmap ImageBitmap { get; set; }
        public FEffect(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        EffectProcessing effectProc = new EffectProcessing();

        private void FEffect_Load(object sender, EventArgs e)
        {
            pbBAndWEffect.Image = effectProc.BlackAndWhiteMode(ImageBitmap);
            pbNagativeEffect.Image = effectProc.NagativeImageMode(ImageBitmap);
        }

        #region Handle Selection
        //Effect: Black and white image
        private void pbBAndWEffect_Click(object sender, EventArgs e)
        {
            ImageBitmap = effectProc.BlackAndWhiteMode(ImageBitmap);
            this.Hide();
        }

        //Effect: Nagative image
        private void pbNagativeEffect_Click(object sender, EventArgs e)
        {
            ImageBitmap = effectProc.NagativeImageMode(ImageBitmap);
            this.Hide();
        }

        #endregion
    }
}
