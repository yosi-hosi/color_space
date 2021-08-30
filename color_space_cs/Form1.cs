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
			textBox7.Text = H_MIN.ToString();
			textBox8.Text = H_MAX.ToString();
			textBox9.Text = S_MIN.ToString();
			textBox10.Text = S_MAX.ToString();
			textBox11.Text = V_MIN.ToString();
			textBox12.Text = V_MAX.ToString();

			Mat image = new Mat();
			Mat HSV = new Mat();
			Mat binary = new Mat();
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
				H_MIN = trackBar1.Value;
				H_MAX = trackBar2.Value;
				S_MIN = trackBar3.Value;
				S_MAX = trackBar4.Value;
				V_MIN = trackBar5.Value;
				V_MAX = trackBar6.Value;

			}
			Cv2.DestroyAllWindows();
			return;
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			textBox7.Text = trackBar1.Value.ToString();
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
        {
			textBox8.Text = trackBar2.Value.ToString();
		}

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
			textBox9.Text = trackBar3.Value.ToString();
		}

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
			textBox10.Text = trackBar4.Value.ToString();
		}

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
			textBox11.Text = trackBar5.Value.ToString();
		}

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
			textBox12.Text = trackBar6.Value.ToString();
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
