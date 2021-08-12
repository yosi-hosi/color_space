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
			VideoCapture video;
			video.open(filepath);
			if (video.isOpened() == false)
			{
				//cout << "Could not open the file...." << endl;
				return 0;
			}

			Mat image, HSV, binary;
			namedWindow("image");
			while (1)
			{
				video >> image;
				if (image.empty() == true) break;
				resize(image, image, Size(image.cols / 2, image.rows / 2));

				imshow("binary", binary);
				if (waitKey(1) == 'q') break;
			}
			destroyAllWindows();
			return 0;
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
