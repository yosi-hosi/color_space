#include <opencv2/opencv.hpp>
#include <iostream>

using namespace cv;
using namespace std;

int counter = 0;
void on_trackbar(int, void*)
{//This function gets called whenever a
 // trackbar position is changed
	cout << "trackbar has moved!_" <<counter<< endl;
	counter++;
}

int main(void)
{
	string filepath ="//ares//Temporary//EV//tsurunuma//2020//20201005tsurunuma//Sony camera//MAH00023.avi";
	//string filepath = "MAH00023.avi";
	VideoCapture video;
	video.open(filepath);
	if (video.isOpened() == false) {
		cout << "Could not open the file...." << endl;
		return 0;
	}

	int  H_MIN = 0, H_MAX = 40, S_MIN = 20, S_MAX = 170, V_MIN = 30, V_MAX = 200;
	string HSV_Trackbar = "Trackbars HSV";
	namedWindow(HSV_Trackbar, 0);
	resizeWindow(HSV_Trackbar, 400, 150);
	createTrackbar("H_MIN", HSV_Trackbar, &H_MIN, 179, on_trackbar);
	createTrackbar("H_MAX", HSV_Trackbar, &H_MAX, 179, on_trackbar);
	createTrackbar("S_MIN", HSV_Trackbar, &S_MIN, 255, on_trackbar);
	createTrackbar("S_MAX", HSV_Trackbar, &S_MAX, 255, on_trackbar);
	createTrackbar("V_MIN", HSV_Trackbar, &V_MIN, 255, on_trackbar);
	createTrackbar("V_MAX", HSV_Trackbar, &V_MAX, 255, on_trackbar);


	Mat image, HSV, binary;
	namedWindow("image");
	while (1) {
		video >> image;
		if (image.empty() == true) break;
		resize(image, image, Size(image.cols / 2, image.rows / 2));
		cvtColor(image, HSV, COLOR_BGR2HSV);
		inRange(HSV, Scalar(H_MIN, S_MIN, V_MIN), Scalar(H_MAX, S_MAX, V_MAX), binary);
		//imshow("image", image);
		//imshow("HSV", HSV);
		imshow("binary", binary);
		if (waitKey(1) == 'q') break;
	}
	destroyAllWindows();
	return 0;
}

// OpenCVの導入
// VS使い方
// c++,c#,python
// namespace
// namedwindow
// Relative,absolute
// waitKey
// .exe
// work C#で作る
// 次回カメラキャプチャ

//today's point
//早くバグを取れることが一番大事。