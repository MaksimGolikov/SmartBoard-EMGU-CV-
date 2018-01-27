using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search_.Forms;
using Search_.NeuralNet;
using System.IO;
using Search_.WorkWithVideoStream;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Search_.Presenters
{
   public class ConfigurationPresenter
    {

        fSettings form;

        Capture camera;
        FindContours processor;
               
     

        private NetOfNeuron netOfNeurons;
        private int[,] mass;

        bool   saveGestureToFolder;
        string pathToSaveFolder;
        int    image_count;

        bool workBySkin;

        decimal minPerimeter;
        decimal maxPerimeter;
        decimal trash;
        decimal trashLink;
        List<decimal> Red;  // first min, second max
        List<decimal> Green;// first min, second max
        List<decimal> Blue; // first min, second max
        bool shouldInvert;

        double deltaBetweenMinMaxColorCode;
        double radiusOfSearchColorArea;

           
        
        public string GetPathToFolder { get => pathToSaveFolder; }


        public ConfigurationPresenter(fSettings newForm)
        {
            Red = new List<decimal>();
            Green = new List<decimal>();
            Blue = new List<decimal>();

            netOfNeurons = new NetOfNeuron();
            processor = new FindContours();

            form = newForm;

            deltaBetweenMinMaxColorCode = 0;
            image_count = 0;
            saveGestureToFolder = false;


            try
            {
                LoadSettings();

                if (Red.Count == 0)
                {
                    DefaultSettings();
                }
            }
            catch
            {
                DefaultSettings();
            }
        }


        public void  GetSystemConfigurations(out List<decimal> decemalValues,
                                             out bool invertImage, out bool bySkin )
        {
            decemalValues = new List<decimal>();

            decemalValues.Add( (int)maxPerimeter);
            decemalValues.Add((int)minPerimeter);
            decemalValues.Add((int)trash);
            decemalValues.Add((int)trashLink);

            decemalValues.Add((int)Red[0]);
            decemalValues.Add((int)Green[0]);
            decemalValues.Add((int)Blue[0]);
            decemalValues.Add((int)Red[1]);
            decemalValues.Add((int)Green[1]);
            decemalValues.Add((int)Blue[1]);

            decemalValues.Add((int)deltaBetweenMinMaxColorCode);
            decemalValues.Add((int)radiusOfSearchColorArea);

            invertImage = shouldInvert;
            bySkin = workBySkin;
        }

        public void GetSystemConfigurationsForNewForm(out List<int> decemalValues,
                                                      out bool invertImage,
                                                      out bool bySkin,
                                                      out Capture cam)
        {
            decemalValues = new List<int>();

            decemalValues.Add((int)minPerimeter);
            decemalValues.Add((int)maxPerimeter);
            decemalValues.Add((int)trash);
            decemalValues.Add((int)trashLink);

            decemalValues.Add((int)Red[0]);
            decemalValues.Add((int)Red[1]);
            decemalValues.Add((int)Green[0]);
            decemalValues.Add((int)Green[1]);
            decemalValues.Add((int)Blue[0]);          
            decemalValues.Add((int)Blue[1]);

            invertImage = shouldInvert;
            bySkin = workBySkin;

            cam = camera;
        }

        public void LounchHeper()
        {
            System.Diagnostics.Process.Start("Helper.exe");
        }



        #region Filter configurations
        public void SetNew_Red(decimal low, decimal high)
        {
            if (low >= 0 && high >= 0)
            {
                Red[0] = low;
                Red[1] = high;
            }           
        }

        public void SetNew_Green(decimal low, decimal high)
        {
            if (low >= 0 && high >= 0)
            {
                Green[0] = low;
                Green[1] = high;
            }
        }

        public void SetNew_Blue(decimal low, decimal high)
        {
            if (low >= 0 && high >= 0)
            {
                Blue[0] = low;
                Blue[1] = high;
            }
        }

        
        public void SetNew_Trash(decimal value)
        {
            if (value >= 0)
            {
                trash = value;
            }
        }

        public void SetNew_TrashLink(decimal value)
        {
            if (value >= 0)
            {
                trashLink = value;
            }
        }

        public void SetNew_InvertImage(bool invert)
        {
            shouldInvert = invert;
        }


        public void SkinMode(bool mode)
        {
            workBySkin = mode;
        }
        #endregion

        #region Correct area
        public void SetNew_minPerimeter(decimal perimeter)
        {
            if (perimeter > 0)
            {
                minPerimeter = perimeter;
            }
        }
        public void SetNew_maxPerimeter(decimal perimeter)
        {
            if (perimeter > 0)
            {
                maxPerimeter = perimeter;
            }
        }

        #endregion

        #region Search color

        public void SetNew_DeltaSearchColor(decimal value)
        {
            if (value > 0)
            {
                deltaBetweenMinMaxColorCode = (double)value;
            }
        }
        public void SetNew_RadiusSearchColor(decimal value)
        {
            if (value > 0)
            {
                radiusOfSearchColorArea = (double)value;
            }
        }


        public void SearchColor(Image image, Point mousePosition)
        {
            Image<Ycc, byte> My_Image = new Image<Ycc, byte>(new Bitmap(image));

            int minX = mousePosition.X - (int)radiusOfSearchColorArea;
            int maxX = mousePosition.X + (int)radiusOfSearchColorArea;

            int minY = mousePosition.Y - (int)radiusOfSearchColorArea;
            int maxY = mousePosition.Y + (int)radiusOfSearchColorArea;
            
            int countOfPoints = (maxX - minX) * (maxY - minY);

            Ycc rgb = new Ycc( 0, 0, 0);

            for (int i = minX; i< maxX; i++)
            {
                for (int j = minY; j < maxY; j++)
                {
                    rgb.Y += My_Image[i, j].Y;
                    rgb.Cb += My_Image[i, j].Cb;
                    rgb.Cr += My_Image[i, j].Cr;
                }
            }

            rgb.Y = rgb.Y / countOfPoints;
            rgb.Cb = rgb.Cb / countOfPoints;
            rgb.Cr = rgb.Cr / countOfPoints;


            SetNew_Red( (decimal)(0),
                        (decimal)(rgb.Y) );
            SetNew_Green((decimal)(0),
                             (decimal)(rgb.Cb ));
            SetNew_Blue((decimal)(0),
                         (decimal)(rgb.Cr ));


        }
        #endregion



        #region Work with video stream

        public void StartToTakeVideo()
        {
            if (camera == null)
            {
                camera = new Emgu.CV.Capture();
            }
        }
        public void StopToTakeVideo()
        {
            camera = null;
        }

        public void SaveGesture()
        {
            saveGestureToFolder = !saveGestureToFolder;
        }
        public void SaveGesture_Process(Image image)
        {
            if (saveGestureToFolder)
            {
               
                image.Save(pathToSaveFolder +"/"+ image_count + ".jpg");
                image_count++;
            }
        }
        

        public void NewFrame(out Bitmap color, out Bitmap gray, out Bitmap gesture, out string recognizedGesture)
        {
            List<RecognitionType> findedHands = new List<RecognitionType>();

            
            if (workBySkin)
            {
                processor.IdentifyContours(this.camera.QueryFrame().ToBitmap(), (int)trash, shouldInvert, (int)minPerimeter, (int)maxPerimeter,
                                           out gray, out color, out findedHands);
            }
            else
            {
                //processor.IdentifyContours(this.camera.QueryFrame().ToBitmap(), (int)minPerimeter, (int)maxPerimeter,
                //                      out gray, out color, out findedHands,
                //                      (int)trash, (int)trashLink,
                //                      (int)Red[0], (int)Green[0], (int)Blue[0],
                //                      (int)Red[1], (int)Green[1], (int)Blue[1],
                //                      shouldInvert);
                processor.IdentifyContours(this.camera.QueryFrame().ToBitmap(), (int)trash, shouldInvert, (int)minPerimeter, (int)maxPerimeter,
                                           (int)Red[0], (int)Green[0], (int)Blue[0],
                                           (int)Red[1], (int)Green[1], (int)Blue[1],
                                           out gray, out color, out findedHands);



            }



           

            if (findedHands.Count > 0)
            {
                gesture = findedHands[0].GestureImage;
                recognizedGesture = RecognizeGesture(findedHands[0].GestureImage);

                SaveGesture_Process(gesture);
            }
            else
            {
                gesture = new Bitmap(1, 1);
                recognizedGesture = "NONE";
            }          
        }


        private string RecognizeGesture(Bitmap img)
        {
            Bitmap bitmap = img;
            string neuralNetAnser = "";

            int[,] clipArr = ImageConvert.CutImageToArray(bitmap, new Point(bitmap.Width, bitmap.Height));
            if (clipArr != null)
            {
                mass = ImageConvert.LeadArray(clipArr, new int[NetOfNeuron.neironInArrayWidth, NetOfNeuron.neironInArrayHeight]);

                string symbbvol = netOfNeurons.CheckLitera(mass);
                if (symbbvol == null) symbbvol = "gesture don`t find";

                neuralNetAnser = symbbvol;
            }

            return neuralNetAnser;
        }

        #endregion





        #region Save/Load settings

        public void SaveSettings()
        {
            StreamWriter write = new StreamWriter("settings.svSt");

            write.WriteLine("Max perimeter:" + maxPerimeter);
            write.WriteLine("Min perimeter:" + minPerimeter);
            write.WriteLine("tr:" + trash);
            write.WriteLine("trL:" + trashLink);
            write.WriteLine("Red_low:" + Red[0]);
            write.WriteLine("Green_low:" + Green[0]);
            write.WriteLine("Blue_low:" + Blue[0]);
            write.WriteLine("Red_high:" + Red[1]);
            write.WriteLine("Green_high:" + Green[1]);
            write.WriteLine("Blue_high:" + Blue[1]);
            write.WriteLine("Invert:" + shouldInvert);
            write.WriteLine("By skin:" + workBySkin);
            write.WriteLine("Delta_colos_Search:" + deltaBetweenMinMaxColorCode);
            write.WriteLine("Radius_color_Search:"+ radiusOfSearchColorArea);
            write.WriteLine(pathToSaveFolder);

            write.Close();
        }
        
        private void LoadSettings()
        {
            if (File.Exists("settings.svSt"))
            {
                Red.Add(0);
                Red.Add(0);
                Green.Add(0);
                Green.Add(0);
                Blue.Add(0);
                Blue.Add(0);


                StreamReader reader = new StreamReader("settings.svSt");
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var m = line.Split(':');

                    switch ((m[0]))
                    {
                        case "Max perimeter":
                            maxPerimeter = Convert.ToDecimal(m[1]);
                            break;
                        case "Min perimeter":
                            minPerimeter = Convert.ToDecimal(m[1]);
                            break;
                        case "tr":
                            trash = Convert.ToDecimal(m[1]);
                            break;
                        case "trL":
                            trashLink = Convert.ToDecimal(m[1]);
                            break;
                        case "Red_low":
                            Red[0] = Convert.ToDecimal(m[1]);
                            break;
                        case "Green_low":
                           Green[0] = Convert.ToDecimal(m[1]);
                            break;
                        case "Blue_low":
                           Blue[0] = Convert.ToDecimal(m[1]);
                            break;
                        case "Red_high":
                            Red[1] = Convert.ToDecimal(m[1]);
                            break;
                        case "Green_high":
                            Green[1] = Convert.ToDecimal(m[1]);
                            break;
                        case "Blue_high":
                           Blue[1] = Convert.ToDecimal(m[1]);
                            break;
                        case "Invert":
                           shouldInvert = Convert.ToBoolean(m[1]);
                            break;
                        case "By skin":
                            workBySkin = Convert.ToBoolean(m[1]);
                            break;
                        case "Delta_colos_Search":
                            deltaBetweenMinMaxColorCode = Convert.ToDouble(m[1]);
                            break;
                        case "Radius_color_Search":
                            radiusOfSearchColorArea = Convert.ToDouble(m[1]);
                            break;

                        default:
                            pathToSaveFolder = m[0]+':'+m[1];
                            break;

                    }
                }
                reader.Close();
            }
        }

        private void DefaultSettings()
        {
            Red.Add(0);
            Red.Add(0);
            Green.Add(0);
            Green.Add(0);
            Blue.Add(0);
            Blue.Add(0);

            maxPerimeter = 100;
            minPerimeter = 200;
            trash = 100;
            trashLink = 100;
            Red[0] = 0;
            Red[1] = 100;
            Green[0] = 0;
            Green[1] = 100;
            Blue[0] = 0;
            Blue[1] = 100;
            shouldInvert = false;
            workBySkin = true;

            deltaBetweenMinMaxColorCode = 10;
            radiusOfSearchColorArea = 1;
        }

        #endregion

    }
}
