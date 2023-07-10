#include <opencv2/opencv.hpp>
#include <uchar.h>

struct Color32
{
	uchar red;
	uchar green;
	uchar blue;
	uchar alpha;
};

extern "C" __declspec(dllexport) void FlipImage(Color32 * *rawImage, int width, int height)
{
	using namespace cv;
	Mat image(height, width, CV_8UC4, *rawImage);
	flip(image, image, -1);
}