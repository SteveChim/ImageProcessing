using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;                  //
using Emgu.CV.CvEnum;           // usual Emgu Cv imports
using Emgu.CV.Structure;        //
using Emgu.CV.UI;               //


namespace ImageProcessing
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult drChosenFile;

            drChosenFile = ofdOpenFile.ShowDialog();

            if (drChosenFile != DialogResult.OK || ofdOpenFile.FileName == "")
            {
                lblChosenFile.Text = "file not chosen";
                return;
            }

            Mat inputFormColor;

            try
            {
                inputFormColor = new Mat(ofdOpenFile.FileName, ImreadModes.Color);
            }
            catch (Exception ex)
            {
                lblChosenFile.Text = "unable to open image, error: " + ex.Message;
                return;
            }

            if (inputFormColor == null)
            {
                lblChosenFile.Text = "unable to open image";
                return;
            }

            CvInvoke.Resize(inputFormColor, inputFormColor, new Size(0, 0), 0.25, 0.25, Inter.Cubic);

            Mat inputFormGray = new Mat(inputFormColor.Size, DepthType.Cv8U, 1);
            Mat inputFormGrayFiltered = new Mat(inputFormColor.Size, DepthType.Cv8U, 1);
            Mat inputFormComplement = new Mat(inputFormColor.Size, DepthType.Cv8U, 1);

            inputFormComplement.SetTo(new MCvScalar(255));

            CvInvoke.CvtColor(inputFormColor, inputFormGray, ColorConversion.Bgr2Gray);

            CvInvoke.BilateralFilter(inputFormGray, inputFormGrayFiltered, 9, 80.0, 80.0);

            CvInvoke.AdaptiveThreshold(inputFormGrayFiltered, inputFormGrayFiltered, 255, AdaptiveThresholdType.GaussianC, ThresholdType.Binary, 11, 2);

            CvInvoke.Subtract(inputFormComplement, inputFormGrayFiltered, inputFormComplement);

            Size inputFormSize = new Size(450, 650);

            Point inputFormCenter = new Point(inputFormGray.Size.Width / 2, inputFormGray.Size.Height / 2);

            CvInvoke.GetRectSubPix(inputFormComplement, inputFormSize, inputFormCenter, inputFormComplement);

            Size sampleSize = new Size(45, 65);

            int[,] histogram = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int Histogram = 0;
                    Mat sampleForm = new Mat(sampleSize, DepthType.Cv8U, 1);
                    Point sampleSizeCenter = new Point(45 * i + 22, 65 * j + 32);
                    CvInvoke.GetRectSubPix(inputFormComplement, sampleSize, sampleSizeCenter, sampleForm);
                    for (int height = 0; height < sampleForm.Rows; height++)
                        for (int width = 0; width < sampleForm.Cols; width++)
                        {
                            if (Convert.ToInt16(sampleForm.GetData(height, width)[0]) != 0)
                            {
                                Histogram++;
                            }
                        }
                    histogram[i, j] = Histogram;
                }
            }

            string fileName = System.IO.Path.GetFileNameWithoutExtension(ofdOpenFile.FileName);
            string arrayFileName = "C:\\CsharpTemp\\" +  fileName + "_Array.txt";
            using (StreamWriter sw = new StreamWriter(arrayFileName))
            {
                //sw.WriteLine("HistogramArray");
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        sw.Write(histogram[j, i] + " ");
                    }
                    sw.WriteLine("");
                }

                sw.Flush();
                sw.Close();
            }
            


            ibOriginal.Image = inputFormColor;
            ibFiltered.Image = inputFormComplement;

            ////Converting Emgu.CV.Image to Bitmap
            ////The Image class has a ToBitmap() function that return a Bitmap object, which can easily be displayed on a PictureBox control using Windows Form.
            //Image<Gray, Byte> imageInputFormComplement = inputFormComplement.ToImage<Gray, Byte>();
            //Bitmap newImage = new Bitmap(ofdOpenFile.FileName);
            //newImage = imageInputFormComplement.ToBitmap();



            ////Create a 3 channel image of 400x200
            ////A "Hello World" Example 
            //using (Mat img = new Mat(200, 400, DepthType.Cv8U, 3))
            //{
            //    img.SetTo(new Bgr(255, 0, 0).MCvScalar); // set it to Blue color

            //    //Draw "Hello, world." on the image using the specific font
            //    CvInvoke.PutText(
            //       img,
            //       "Hello, world",
            //       new System.Drawing.Point(10, 80),
            //       FontFace.HersheyComplex,
            //       1.0,
            //       new Bgr(0, 255, 0).MCvScalar);

            //    //Show the image using ImageViewer from Emgu.CV.UI
            //    ImageViewer.Show(img, "Test Window");
            //}
        }
    }
}
