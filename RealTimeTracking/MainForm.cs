using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
//using OpenCvSharp.MachineLearning;
using OpenCvSharp.Blob;
using OpenCvSharp.UserInterface;
using OpenCvSharp.CPlusPlus;
using OpenCvSharp.Extensions;

namespace RealTimeTracking
{
    public partial class MainForm : Form
    {
        PictureBoxIpl m_pictureBoxIpl;
        PictureBoxIpl m_pictureBoxHSV;
        PictureBoxIpl m_pictureBoxTreShould;
        Mat cameraFeed;
        Mat HSV;
        Mat threshold;
        VideoCapture captureCam;


        int H_MIN = 0, H_MAX = 256, S_MIN = 0, S_MAX = 256, V_MIN = 0, V_MAX = 256;

        public MainForm()
        {
            InitializeComponent();


            cameraFeed = new Mat();
            HSV = new Mat();
            threshold = new Mat();
            captureCam = new VideoCapture();

            m_pictureBoxIpl = new PictureBoxIpl();
            m_pictureBoxIpl.SizeMode = PictureBoxSizeMode.StretchImage;
            m_pictureBoxIpl.Size = new System.Drawing.Size(320, 280);

            m_pictureBoxHSV = new PictureBoxIpl();
            m_pictureBoxHSV.SizeMode = PictureBoxSizeMode.StretchImage;
            m_pictureBoxHSV.Size = new System.Drawing.Size(320, 280);

            m_pictureBoxTreShould = new PictureBoxIpl();
            m_pictureBoxTreShould.SizeMode = PictureBoxSizeMode.StretchImage;
            m_pictureBoxTreShould.Size = new System.Drawing.Size(320, 280);  


            m_panelCamera.Controls.Add(m_pictureBoxIpl);
            m_panelHSV.Controls.Add(m_pictureBoxHSV);
            m_panelTreshould.Controls.Add(m_pictureBoxTreShould);
            
        }
        private void m_timer_Tick(object sender, EventArgs e)
        {
            if (!m_backgroundWorker.IsBusy)
                m_backgroundWorker.RunWorkerAsync();
        }

        

        private void m_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!captureCam.IsOpened())
            {
                captureCam.Open(CaptureDevice.Any);

                captureCam.Set(CvConst.CV_CAP_PROP_FRAME_WIDTH, FRAME_WIDTH);
                captureCam.Set(CvConst.CV_CAP_PROP_FRAME_HEIGHT, FRAME_HEIGHT);
            }


            captureCam.Read(cameraFeed);

            if (cameraFeed.Width != 0 && cameraFeed.Height != 0)
            {
                Cv2.CvtColor(cameraFeed, HSV, ColorConversion.BgrToHsv); 
                Cv2.InRange(HSV, new Scalar(H_MIN, S_MIN, V_MIN), new Scalar(H_MAX, S_MAX, V_MAX), threshold);

                if(m_checkBoxUseMorphOps.Checked)
                    morphOps(threshold);

                if (m_checkBoxTrackObject.Checked)
                    trackFilteredObject(0, 0, threshold, cameraFeed);

                m_pictureBoxIpl.ImageIpl = cameraFeed.ToIplImage();
                m_pictureBoxHSV.ImageIpl = HSV.ToIplImage();
                m_pictureBoxTreShould.ImageIpl = threshold.ToIplImage();
            }
        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        void drawObject(int x, int y, Mat frame)
        {
            Cv2.Circle(frame, new OpenCvSharp.CPlusPlus.Point(x, y), 20, new Scalar(0, 255, 0), 2);
         
            if (y - 25 > 0)
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(x, y - 25), new Scalar(0, 255, 0), 2);
            else
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(x, 0), new Scalar(0, 255, 0), 2);

            if (y + 25 < FRAME_HEIGHT)
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(x, y + 25), new Scalar(0, 255, 0), 2);
            else Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(x, FRAME_HEIGHT), new Scalar(0, 255, 0), 2);

            if (x - 25 > 0)
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(x - 25, y), new Scalar(0, 255, 0), 2);
            else
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(0, y), new Scalar(0, 255, 0), 2);

            if (x + 25 < FRAME_WIDTH)
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(x + 25, y), new Scalar(0, 255, 0), 2);
            else
                Cv2.Line(frame, new OpenCvSharp.CPlusPlus.Point(x, y), new OpenCvSharp.CPlusPlus.Point(FRAME_WIDTH, y), new Scalar(0, 255, 0), 2);

            Cv2.PutText(frame, x.ToString() + "," + y.ToString(), new OpenCvSharp.CPlusPlus.Point(x, y + 30), FontFace.Italic, 1, new Scalar(0, 255, 0), 2);

        }
        const int FRAME_WIDTH = 640;
        const int FRAME_HEIGHT = 480;
        const int MIN_OBJECT_AREA = 20 * 20;
        const double MAX_OBJECT_AREA = FRAME_HEIGHT * FRAME_WIDTH / 1.5;
        const int MAX_NUM_OBJECTS = 50;
        void trackFilteredObject(double x, double y, Mat threshold, Mat cameraFeed)
        {

	Mat temp = new Mat();
	threshold.CopyTo(temp);
	//these two vectors needed for output of findContours
	OpenCvSharp.CPlusPlus.Point[][] contours;
            HiearchyIndex[] hierarchy;
	//find contours of filtered image using openCV findContours function
            Cv2.FindContours(temp, out contours, out hierarchy, ContourRetrieval.CComp, ContourChain.ApproxSimple);
	//use moments method to find our filtered object
	double refArea = 0;
	bool objectFound = false;
    if (hierarchy.Length > 0)
    {
        int numObjects = hierarchy.Length;
        //if number of objects greater than MAX_NUM_OBJECTS we have a noisy filter
        if (numObjects < MAX_NUM_OBJECTS)
        {

            for (int i = 0; i < hierarchy.Length; i++)
            {
                Moments moment = new Moments(contours[i]);

                double area = moment.M00;

                //if the area is less than 20 px by 20px then it is probably just noise
                //if the area is the same as the 3/2 of the image size, probably just a bad filter
                //we only want the object with the largest area so we safe a reference area each
                //iteration and compare it to the area in the next iteration.
                if (area > MIN_OBJECT_AREA && area < MAX_OBJECT_AREA && area > refArea)
                {
                    x = moment.M10 / area;
                    y = moment.M01 / area;
                    objectFound = true;
                    refArea = area;
                }
                else objectFound = false;


            }
            //let user know you found an object
            if (objectFound == true)
            {
                Cv2.PutText(cameraFeed, "Tracking Object", new OpenCvSharp.CPlusPlus.Point(0, 50), FontFace.HersheyDuplex, 1, new Scalar(0, 255, 0), 2);
                //draw object location on screen
                drawObject(Convert.ToInt32(x), Convert.ToInt32(y), cameraFeed);
            }

        }
        else 
            Cv2.PutText(cameraFeed, "TOO MUCH NOISE! ADJUST FILTER", new OpenCvSharp.CPlusPlus.Point(0, 50), FontFace.HersheyComplexSmall, 2, new Scalar(0, 0, 255), 2);
    }
}

        void morphOps(Mat thresh)
        {
            Mat erodeElement = Cv2.GetStructuringElement(StructuringElementShape.Rect, new OpenCvSharp.CPlusPlus.Size(3, 3));
            Mat dilateElement = Cv2.GetStructuringElement(StructuringElementShape.Rect, new OpenCvSharp.CPlusPlus.Size(8, 8));

            Cv2.Erode(thresh, thresh, erodeElement);
            Cv2.Erode(thresh, thresh, erodeElement);

            Cv2.Dilate(thresh, thresh, dilateElement);
            Cv2.Dilate(thresh, thresh, dilateElement);
        }

        private void trackBars_Scroll(object sender, EventArgs e)
        {
            TrackBar myTrack = (TrackBar)sender;

            if (myTrack == m_trackBarHueMin)
                H_MIN = m_trackBarHueMin.Value;
            else if (myTrack == m_trackBarHueMax)
                H_MAX = m_trackBarHueMax.Value;
            else if (myTrack == m_trackBarSaturationMin)
                S_MIN = m_trackBarSaturationMin.Value;
            else if (myTrack == m_trackBarSaturationMax)
                S_MAX = m_trackBarSaturationMax.Value;
            else if (myTrack == m_trackBarValueMin)
                V_MIN = m_trackBarValueMin.Value;
            else if (myTrack == m_trackBarValueMax)
                V_MAX = m_trackBarValueMax.Value;




        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
