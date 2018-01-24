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






        public void IdentifyContours(Bitmap colorImage, int thresholdValue, bool invert, int minPerimeter, int maxPerimeter,
                                     int Rl, int Gl, int Bl, int Rh, int Gh, int Bh,
                                     out Bitmap processedGray, out Bitmap processedColor, out List<RecognitionType> detectedObj)
        {
            detectedObj = new List<RecognitionType>();
            Rectangle gestureRectangle = new Rectangle(0, 0, 1, 1);
            #region Conversion To grayscale

            colorImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Image<Gray, byte> grayImage = new Image<Gray, byte>(colorImage);
            Image<Bgr, byte> color = new Image<Bgr, byte>(colorImage);


            IColorSkinDetector skinDetection;

            Ycc YCrCb_min = new Ycc(Bl, Gl, Rl);
            Ycc YCrCb_max = new Ycc(Bh, Gh, Rh);

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

            Ycc YCrCb_min = new Ycc(Bl, Gl, Rl);
            Ycc YCrCb_max = new Ycc(Bh, Gh, Rh);

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
