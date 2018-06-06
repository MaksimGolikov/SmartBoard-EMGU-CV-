using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Search_.WorkWithVideoStream;



namespace Search_
{
    class FindContours
    {

       #region by skin
        public void IdentifyContours(Bitmap colorImage, int thresholdValue, bool invert, int minPerimeter, int maxPerimeter,
                                     out Bitmap processedGray, out Bitmap processedColor, out List<RecognitionType> detectedObj)
        {
            detectedObj = new List<RecognitionType>();
            Rectangle gestureRectangle = new Rectangle(0,0,1,1);
            #region Conversion To grayscale

            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);


            IColorSkinDetector skinDetection;           

            Ycc  YCrCb_min = new Ycc(0, 131, 80);
            Ycc  YCrCb_max = new Ycc(255, 185, 135);
           
            #endregion


            #region  Image normalization and inversion (if required)
            grayImage = grayImage.ThresholdBinary(new Gray(thresholdValue), new Gray(255));
            if (invert)
            {
                grayImage._Not();
            }
            #endregion

            #region Extracting the Contours


            skinDetection = new YCrCbSkinDetector();
            Image<Gray, byte> skin = skinDetection.DetectSkin(color, YCrCb_min, YCrCb_max);



            using (MemStorage storage = new MemStorage())
            {

                for (Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                     Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        if (contours.Perimeter > minPerimeter && contours.Perimeter < maxPerimeter)
                        {
                            CvInvoke.cvDrawContours(skin, contours, new MCvScalar(255), new MCvScalar(255),
                                                                           -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            color.Draw(currentContour.BoundingRectangle, new Bgr(0, 255, 0), 1);

                            detectedObj.Add(new RecognitionType()
                            {
                                GesturePosition = currentContour.BoundingRectangle,
                                GestureImage = skin.ToBitmap().Clone(currentContour.BoundingRectangle, skin.ToBitmap().PixelFormat)
                            });
                        }                       
                    }
                }
            }


            #endregion


            #region Asigning output
            processedColor = color.ToBitmap();           
            processedGray = skin.ToBitmap();                  
            #endregion


        }


        public void IdentifyContours(Bitmap colorImage, int minPerimeter, int maxPerimeter, out List<RecognitionType> detectedObj)
        {

             detectedObj = new List<RecognitionType>();
            
            #region Conversion To grayscale

            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);


            IColorSkinDetector skinDetection;

            Ycc YCrCb_min = new Ycc(0, 131, 80);
            Ycc YCrCb_max = new Ycc(255, 185, 135);

            #endregion

                      

           

            skinDetection = new YCrCbSkinDetector();
            Image<Gray, byte> skin = skinDetection.DetectSkin(color, YCrCb_min, YCrCb_max);


            using (MemStorage storage = new MemStorage())
            {

                for (Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                     Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        if (contours.Perimeter > minPerimeter && contours.Perimeter < maxPerimeter)
                        {
                            CvInvoke.cvDrawContours(skin, contours, new MCvScalar(255), new MCvScalar(255),
                                                                           -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            color.Draw(currentContour.BoundingRectangle, new Bgr(0, 255, 0), 1);
                            
                            detectedObj.Add(new RecognitionType()
                            {
                                GesturePosition = currentContour.BoundingRectangle,
                                GestureImage = skin.ToBitmap().Clone(currentContour.BoundingRectangle, skin.ToBitmap().PixelFormat)
                            });
                        }                       
                    }
                }

            }
           
        }
        #endregion


        #region by RGB color

        public void IdentifyContours(Bitmap colorImage, bool invert, int minPerimeter, int maxPerimeter,
                                     int Red_H, int Green_H, int Blue_H, int Red_L, int Green_L, int Blue_L,
                                     out Bitmap processedGray, out Bitmap processedColor, out List<RecognitionType> detectedObj)
        {
            detectedObj = new List<RecognitionType>();
            Rectangle gestureRectangle = new Rectangle(0, 0, 1, 1);
            
            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);

            #region Extracting the Contours


            color.PyrDown().PyrUp();
            color.SmoothGaussian(3);
            var  finishImage = color.InRange(new Bgr(Blue_L, Green_L, Red_L),
                                             new Bgr(Blue_H, Green_H, Red_H));

            finishImage.PyrDown().PyrUp();
            finishImage.SmoothGaussian(3);

            if (invert)
            {
                finishImage._Not();
            }

            using (MemStorage storage = new MemStorage())
            {

                for (Contour<Point> contours = finishImage.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                     Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        if (contours.Perimeter > minPerimeter && contours.Perimeter < maxPerimeter)
                        {
                            CvInvoke.cvDrawContours(finishImage, contours, new MCvScalar(255), new MCvScalar(255),
                                                    -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            color.Draw(currentContour.BoundingRectangle, new Bgr(0, 255, 0), 1);

                            detectedObj.Add(new RecognitionType()
                            {
                                GesturePosition = currentContour.BoundingRectangle,
                                GestureImage = finishImage.ToBitmap().Clone(currentContour.BoundingRectangle, finishImage.ToBitmap().PixelFormat)
                            });
                        }
                    }
                }
            }
            #endregion


            #region Asigning output
            processedColor = color.ToBitmap();
            processedGray = finishImage.ToBitmap();
            #endregion
        }






        #endregion


        public void IdentifyContours(Bitmap colorImage,double up, double down, int minPerimeter, int maxPerimeter,
                                      out Bitmap returnColor, out Bitmap returnGray, out List<RecognitionType> detectedObj)
        {
           
            Rectangle gestureRectangle = new Rectangle(0, 0, 1, 1);
            detectedObj = new List<RecognitionType>();

            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Hsv, byte> color = new Image<Hsv, byte>(colorImage);

            #region Extracting the Contours
            
            
            var channels = color.Split();

            channels[1].PyrDown().PyrUp();
            channels[1].SmoothMedian(5);
            channels[1].PyrDown().PyrUp();

            var im = channels[1].InRange(new Gray(down), new Gray(up));
            var finishImage = im.SmoothMedian(5);
            finishImage._Not();

            using (MemStorage storage = new MemStorage())
            {

                for (Contour<Point> contours = finishImage.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                     Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        if (contours.Perimeter > minPerimeter && contours.Perimeter < maxPerimeter)
                        {
                            CvInvoke.cvDrawContours(finishImage, contours, new MCvScalar(255), new MCvScalar(255),
                                                                           -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            color.Draw(currentContour.BoundingRectangle, new Hsv(0, 255, 0), 1);

                            detectedObj.Add(new RecognitionType()
                            {
                                GesturePosition = currentContour.BoundingRectangle,
                                GestureImage = finishImage.ToBitmap().Clone(currentContour.BoundingRectangle, finishImage.ToBitmap().PixelFormat)
                            });
                        }
                    }
                }
            }
            
            #endregion


            #region Asigning output
             returnColor = color.ToBitmap();
             returnGray  = finishImage.ToBitmap();
            #endregion
        }








        public void IdentifyContours(Bitmap colorImage, int thresholdValue, bool invert, int minPerimeter, int maxPerimeter,
                                     int Y_h, int Cr_h, int Cb_h, int Y_l, int Cr_l, int Cb_l,
                                     out Bitmap processedGray, out Bitmap processedColor, out List<RecognitionType> detectedObj)
        {
            detectedObj = new List<RecognitionType>();
            Rectangle gestureRectangle = new Rectangle(0, 0, 1, 1);
            #region Conversion To grayscale

            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);


            IColorSkinDetector skinDetection;

           
            #endregion


            #region Extracting the Contours


            skinDetection = new YCrCbSkinDetector();
            Image<Gray, byte> skin = skinDetection.DetectSkin(color, new Ycc(Y_l, Cr_l, Cb_l), new Ycc(Y_h, Cr_h, Cb_h));
         
            if (invert)
            {
                skin._Not();
            }


            using (MemStorage storage = new MemStorage())
            {

                for (Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                     Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        if (contours.Perimeter > minPerimeter && contours.Perimeter < maxPerimeter)
                        {
                            CvInvoke.cvDrawContours(skin, contours, new MCvScalar(255), new MCvScalar(255),
                                                                           -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            color.Draw(currentContour.BoundingRectangle, new Bgr(0, 255, 0), 1);

                            detectedObj.Add(new RecognitionType()
                            {
                                GesturePosition = currentContour.BoundingRectangle,
                                GestureImage = skin.ToBitmap().Clone(currentContour.BoundingRectangle, skin.ToBitmap().PixelFormat)
                            });
                        }
                    }
                }
            }


            #endregion


            #region Asigning output
            processedColor = color.ToBitmap();
            processedGray = skin.ToBitmap();
            #endregion


        }


        public void IdentifyContours(Bitmap colorImage, int thresholdValue, bool invert, int minPerimeter, int maxPerimeter,
                                    int Rl, int Gl, int Bl, int Rh, int Gh, int Bh,
                                    out List<RecognitionType> detectedObj)
        {
            detectedObj = new List<RecognitionType>();
            Rectangle gestureRectangle = new Rectangle(0, 0, 1, 1);
            #region Conversion To grayscale

            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);


            IColorSkinDetector skinDetection;

            Ycc YCrCb_min = new Ycc(Rl, Gl, Bl);
            Ycc YCrCb_max = new Ycc(Rh, Gh, Bh);

            #endregion


            #region Extracting the Contours


            skinDetection = new YCrCbSkinDetector();
            Image<Gray, byte> skin = skinDetection.DetectSkin(color, YCrCb_min, YCrCb_max);

            if (invert)
            {
                skin._Not();
            }


            using (MemStorage storage = new MemStorage())
            {

                for (Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                     Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.015, storage);

                    if (currentContour.BoundingRectangle.Width > 20)
                    {
                        if (contours.Perimeter > minPerimeter && contours.Perimeter < maxPerimeter)
                        {
                            CvInvoke.cvDrawContours(skin, contours, new MCvScalar(255), new MCvScalar(255),
                                                                           -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));
                            color.Draw(currentContour.BoundingRectangle, new Bgr(0, 255, 0), 1);

                            detectedObj.Add(new RecognitionType()
                            {
                                GesturePosition = currentContour.BoundingRectangle,
                                GestureImage = skin.ToBitmap().Clone(currentContour.BoundingRectangle, skin.ToBitmap().PixelFormat)
                            });
                        }
                    }
                }
            }


            #endregion
            
        }



        




    }
}
