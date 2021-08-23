using OpenCvSharp;
using System;
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
			string filepath = "//ares//Temporary//EV//tsurunuma//2020//20201005tsurunuma//Sony camera//MAH00023.mp4";
			//string filepath = "MAH00023.avi";
			var video =new VideoCapture();
			video = VideoCapture.FromFile(filepath);
			if (video.IsOpened() == false)
			{
				//cout << "Could not open the file...." << endl;
				return ;
			}

			var image = new Mat();
			var Blur = new Mat();
			//Cv2.NamedWindow("image");
			while (video.Read(image))
			{
				if (image.Empty() == true) break;
				Cv2.Resize(image, image,new OpenCvSharp.Size(image.Cols / 3, image.Rows / 3));

				Cv2.GaussianBlur(image, Blur, new Size(trackBar1.Value*2+1, trackBar1.Value*2+1), trackBar2.Value, trackBar3.Value);

				Cv2.ImShow("image", image);
				Cv2.ImShow("Blur", Blur);
				if (Cv2.WaitKey(1) == 'q') break;
			}
			Cv2.DestroyAllWindows();
			return ;
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
