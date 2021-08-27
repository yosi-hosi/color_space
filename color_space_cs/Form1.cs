using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_space_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
        {
			string filepath = "//ares//Temporary//EV//tsurunuma//2020//20201005tsurunuma//Sony camera//MAH00023.avi";
			//string filepath = "MAH00023.avi";
			VideoCapture video = new VideoCapture();
			video.Open(filepath);
			if (video.IsOpened() == false)
			{
				Console.WriteLine("Could not open the file....");
				return;
			}

			int H_MIN = 0, H_MAX = 40, S_MIN = 20, S_MAX = 170, V_MIN = 30, V_MAX = 200;
			string HSV_Trackbar = "Trackbars HSV";
			Cv2.NamedWindow(HSV_Trackbar, 0);
			Cv2.ResizeWindow(HSV_Trackbar, 400, 150);
			Cv2.CreateTrackbar("H_MIN", HSV_Trackbar, 179, onChange: H_MIN_Changed);
			Cv2.CreateTrackbar("H_MAX", HSV_Trackbar, &H_MAX, 179, on_trackbar);
			Cv2.CreateTrackbar("S_MIN", HSV_Trackbar, &S_MIN, 255, on_trackbar);
			Cv2.CreateTrackbar("S_MAX", HSV_Trackbar, &S_MAX, 255, on_trackbar);
			Cv2.CreateTrackbar("V_MIN", HSV_Trackbar, &V_MIN, 255, on_trackbar);
			Cv2.CreateTrackbar("V_MAX", HSV_Trackbar, &V_MAX, 255, on_trackbar);

			Mat image = new Mat();
			Mat HSV = new Mat();
			Mat binary = new Mat();
			Cv2.NamedWindow("image");
			while (true)
			{
				video.Read(image);
				if (image.Empty() == true) break;
				Cv2.Resize(image, image, new OpenCvSharp.Size(image.Cols / 3, image.Rows / 3));
				Cv2.CvtColor(image, HSV, ColorConversionCodes.BGR2HSV);
				Cv2.InRange(HSV, new Scalar(H_MIN, S_MIN, V_MIN), new Scalar(H_MAX, S_MAX, V_MAX), binary);
				Cv2.ImShow("image", image);
				Cv2.ImShow("HSV", HSV);
				Cv2.ImShow("binary", binary);
				if (Cv2.WaitKey(1) == 'q') break;
			}
			Cv2.DestroyAllWindows();
			return;
		}
	}
}

//基本は「考えられる修正内容」のそれっぽいやつでいける
//Cv2.Imshowみたいな感じに修正
//()のなかで,を打てば教えてくれる
//初めてのものはnewしないといけない cf.ガーベッジコレクション
//Mat image=new Mat();
//VideoCapture video=new VideoCapture();
//new Size(
//work OpenCVのImShowじゃなくてwinFormに描画してみる
//work ツールボックスいろいろ遊ぶ
//次回　山中の汚いコード(引き継げるものはこれだけ)見る

//today's point
//ググりながら慣れる。
