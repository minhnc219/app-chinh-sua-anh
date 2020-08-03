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
using ZedGraph;

namespace ImageProcessing.View.Histogram
{
    public partial class FHistogram : Form
    {
        public Bitmap ImageBitmap { get; set; }

        public FHistogram(Bitmap imageBitmap)
        {
            ImageBitmap = imageBitmap;
            InitializeComponent();
        }

        HistogramProcessing histogramProc = new HistogramProcessing();

        private void FHistogram_Load(object sender, EventArgs e)
        {
            LoadHistogramDiagramRGB();
        }

        #region Handle
        private void LoadHistogramDiagramRGB()
        {
            // Get location and size of zgcHistogram            
            int widthDiagram = zgcHistogram.Size.Width;
            int heightDiagram = zgcHistogram.Size.Height;

            //Compute histogram
            double[,] histogram = histogramProc.ComputeHistogram(ImageBitmap);

            //Convert histogram to point
            List<PointPairList> points = histogramProc.ConvertHistogram(histogram);

            //Draw histogram diagram and show
            zgcHistogram.GraphPane = histogramProc.HistogramDiagramRGB(points, widthDiagram, heightDiagram);
            zgcHistogram.Refresh();
        }

        private void LoadrgbHistogramDiagram(string rgb)
        {
            // Get location and size of zgcHistogram            
            int widthDiagram = zgcHistogram.Size.Width;
            int heightDiagram = zgcHistogram.Size.Height;

            //Compute histogram
            double[] histogram = histogramProc.ComputeHistogram(ImageBitmap, rgb);

            //Convert histogram to point
            PointPairList points = histogramProc.ConvertHistogram(histogram);

            //Draw histogram diagram and show
            zgcHistogram.GraphPane = histogramProc.rgbHistogramDiagram(points, widthDiagram, heightDiagram, rgb);
            zgcHistogram.Refresh();
        }

        #endregion

        #region Button
        //Button RGB Histogram
        private void btnRGBHistogram_Click(object sender, EventArgs e)
        {
            LoadHistogramDiagramRGB();
        }

        //Button Red Histogram
        private void btnRedHistogram_Click(object sender, EventArgs e)
        {
            LoadrgbHistogramDiagram("r");
        }

        //Button Green Histogram
        private void btnGreenHistogram_Click(object sender, EventArgs e)
        {
            LoadrgbHistogramDiagram("g");
        }

        //Button Blue Histogram
        private void btnBlueHistogram_Click(object sender, EventArgs e)
        {
            LoadrgbHistogramDiagram("b");
        }

        #endregion        
    }
}
