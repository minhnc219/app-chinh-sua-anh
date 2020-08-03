using System.Collections.Generic;
using System.Drawing;
using ZedGraph;

namespace ImageProcessing.Process
{
    class HistogramProcessing
    {
        #region Histogram of RGB
        //Compute histogram of RGB 
        public double[,] ComputeHistogram(Bitmap bitmap)
        {
            double[,] histogram = new double[3, 256];
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    byte red = color.R;
                    byte green = color.G;
                    byte blue = color.B;

                    histogram[0, red]++;
                    histogram[1, green]++;
                    histogram[2, blue]++;
                }
            }
            return histogram;
        }

        //Convert array of histogram to point 
        public List<PointPairList> ConvertHistogram(double[,] histogram)
        {
            List<PointPairList> points = new List<PointPairList>();
            PointPairList redPoints = new PointPairList();  //Convert histogram R
            PointPairList greenPoints = new PointPairList();    //Convert histogram G
            PointPairList bluePoints = new PointPairList();    //Convert histogram B

            for (int i = 0; i < 256; i++)
            {
                redPoints.Add(i, histogram[0, i]);                //Convert for R
                greenPoints.Add(i, histogram[1, i]);            //Convert for G
                bluePoints.Add(i, histogram[2, i]);             //Convert for B
            }

            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);

            return points;
        }

        //Make diagram in ZedGraph
        public GraphPane HistogramDiagramRGB(List<PointPairList> histogramPoint, int width, int height)
        {
            GraphPane graphPane = new GraphPane();

            graphPane.Title.Text = "";          //Name of diagram
            graphPane.Rect = new Rectangle(0, 0, width, height);

            //Set up Ox
            graphPane.XAxis.Title.Text = @"Giá trị màu";
            graphPane.XAxis.Scale.Min = 0;          //Min = 0
            graphPane.XAxis.Scale.Max = 255;
            graphPane.XAxis.Scale.MajorStep = 5;
            graphPane.XAxis.Scale.MinorStep = 1;

            //Set up Oy
            graphPane.YAxis.Title.Text = @"Số điểm ảnh";
            graphPane.YAxis.Scale.Min = 0;          //Min = 0
            graphPane.YAxis.Scale.Max = 120000;
            graphPane.YAxis.Scale.MajorStep = 10000;
            graphPane.YAxis.Scale.MinorStep = 5;

            //Perform
            graphPane.AddBar("", histogramPoint[0], Color.Red);
            graphPane.AddBar("", histogramPoint[1], Color.Green);
            graphPane.AddBar("", histogramPoint[2], Color.Blue);

            return graphPane;
        }

        #endregion

        #region Histogram of R or G or B
        //Compute histogram
        public double[] ComputeHistogram(Bitmap bitmap, string rgb)
        {
            double[] histogram = new double[256];
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    switch (rgb)
                    {
                        case "r":
                            histogram[color.R]++;
                            break;
                        case "g":
                            histogram[color.G]++;
                            break;
                        case "b":
                            histogram[color.B]++;
                            break;
                        default:
                            break;
                    }
                }
            }
            return histogram;
        }

        //Convert array of histogram to point
        public PointPairList ConvertHistogram(double[] histogram)
        {
            PointPairList points = new PointPairList();

            for (int i = 0; i < 256; i++)
            {
                points.Add(i, histogram[i]);
            }

            return points;
        }

        //Make diagram in ZedGraph
        public GraphPane rgbHistogramDiagram(PointPairList histogramPoint, int width, int height, string rgb)
        {
            GraphPane graphPane = new GraphPane();

            graphPane.Title.Text = "";          //Name of diagram
            graphPane.Rect = new Rectangle(0, 0, width, height);

            //Set up Ox
            graphPane.XAxis.Title.Text = @"Giá trị màu";
            graphPane.XAxis.Scale.Min = 0;          //Min = 0
            graphPane.XAxis.Scale.Max = 255;
            graphPane.XAxis.Scale.MajorStep = 5;
            graphPane.XAxis.Scale.MinorStep = 1;

            //Set up Oy
            graphPane.YAxis.Title.Text = @"Số điểm ảnh";
            graphPane.YAxis.Scale.Min = 0;          //Min = 0
            graphPane.YAxis.Scale.Max = 120000;
            graphPane.YAxis.Scale.MajorStep = 10000;
            graphPane.YAxis.Scale.MinorStep = 5;

            //Perform
            switch (rgb)
            {
                case "r":
                    graphPane.AddBar("", histogramPoint, Color.Red);
                    break;
                case "g":
                    graphPane.AddBar("", histogramPoint, Color.Green);
                    break;
                case "b":
                    graphPane.AddBar("", histogramPoint, Color.Blue);
                    break;
                default:
                    break;
            }
            return graphPane;
        }

        #endregion
    }
}
