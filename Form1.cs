using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Security.Cryptography;

namespace CSharpVisionAlgoPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pbOriginImage.MouseWheel += picturebox_MouseWheel;
            pbResult.MouseWheel += picturebox_MouseWheel;
        }

        private void btnImgLoad_Click(object sender, EventArgs e)
        {
            var imgPath = new OpenFileDialog();
            if (imgPath.ShowDialog() == DialogResult.OK)
            {
                srcImg = Cv2.ImRead(imgPath.FileName);
                pbOriginImage.Image = BitmapConverter.ToBitmap(srcImg);
            }
        }
        private void picturebox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ZoomIn((PictureBox)sender);
            }
            else
            {
                ZoomOut((PictureBox)sender);
            }
        }

        private void ZoomIn(PictureBox pictureBox)
        {
            double ZOOM_FACTOR = 1.1;
            int MIN_MAX = 5;

            if ((pictureBox.Width < (MIN_MAX * pictureBox.Width)) &&
                (pictureBox.Height < (MIN_MAX * pictureBox.Height)))
            {
                pictureBox.Width = Convert.ToInt32(pictureBox.Width * ZOOM_FACTOR);
                pictureBox.Height = Convert.ToInt32(pictureBox.Height * ZOOM_FACTOR);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ZoomOut(PictureBox pictureBox)
        {
            double ZOOM_FACTOR = 1.1;
            int MIN_MAX = 5;

            if ((pictureBox.Width > (pictureBox.Width / MIN_MAX)) &&
                (pictureBox.Height > (pictureBox.Height / MIN_MAX)))
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = Convert.ToInt32(pictureBox.Width / ZOOM_FACTOR);
                pictureBox.Height = Convert.ToInt32(pictureBox.Height / ZOOM_FACTOR);
            }
        }
        Mat? srcImg;

        private void btnAlgo_Click(object sender, EventArgs e)
        {
            if (srcImg == null)
            {
                MessageBox.Show("이미지를 먼저 로드하세요.");
                return;
            }
            Mat bufImg = new Mat();
            Mat retImg = srcImg.Clone();
            // 여기에 영상처리 알고리즘 구현
            var thresholdValue = 128;

            Cv2.CvtColor(srcImg, bufImg, ColorConversionCodes.BGR2GRAY);
            Cv2.GaussianBlur(bufImg, bufImg, new OpenCvSharp.Size(3, 3), 1.5);
            var clahe = Cv2.CreateCLAHE(2.0, new OpenCvSharp.Size(3, 3));
            clahe.Apply(bufImg, bufImg);
            Cv2.Canny(bufImg, bufImg, 100, 200);
            Cv2.Threshold(bufImg, bufImg, thresholdValue, 255, ThresholdTypes.Binary);
            Cv2.FindContours(bufImg, out OpenCvSharp.Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            //List<OpenCvSharp.Point[]> new_contours = new List<OpenCvSharp.Point[]>();
            foreach (OpenCvSharp.Point[] p in contours)
            {
                double length = Cv2.ArcLength(p, true);
                double area = Cv2.ContourArea(p, true);

                Rect boundingRect = Cv2.BoundingRect(p);
                if (Math.Abs(area) < 600)
                {
                    Cv2.Rectangle(retImg, boundingRect, Scalar.Red, 2);
                }
                else
                {
                    Cv2.Rectangle(retImg, boundingRect, Scalar.Green, 2);
                }
            }

            //Cv2.DrawContours(bufImg, new_contours, -1, new Scalar(255, 0, 0), 2, LineTypes.AntiAlias, null, 1);
            //Cv2.ImShow("dst", dst);
            pbResult.Image = BitmapConverter.ToBitmap(retImg);
        }
    }
}
