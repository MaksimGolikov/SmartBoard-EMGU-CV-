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
        bool shouldInvert;

        decimal minPerimeter;
        decimal maxPerimeter;
       
        double upHue;
        double downHue;
        double upSati;
        double downSati;


        public string GetPathToFolder { get => pathToSaveFolder; }


        public ConfigurationPresenter(fSettings newForm)
        {
          
            netOfNeurons = new NetOfNeuron();
            processor = new FindContours();

            form = newForm;
           
            image_count = 0;
            saveGestureToFolder = false;

            DefaultSettings();
            try
            {
               // LoadSettings();

                //if (Red.Count == 0)
                //{
                //    DefaultSettings();
                //}
            }
            catch
            {
                DefaultSettings();
            }
        }

        public void GetSystemConfigurations(out List<decimal> decemalValues)
        {
            decemalValues = new List<decimal>();

          
            decemalValues.Add((int)upHue);
            decemalValues.Add((int)downHue);
            decemalValues.Add((int)upSati);
            decemalValues.Add((int)downSati);
        }


        public void  GetSystemConfigurations(out List<decimal> decemalValues,
                                             out bool bySkin )
        {
            decemalValues = new List<decimal>();

            decemalValues.Add( (int)maxPerimeter);
            decemalValues.Add((int)minPerimeter);


            decemalValues.Add((int)upHue);
            decemalValues.Add((int)downHue);
            decemalValues.Add((int)upSati);
            decemalValues.Add((int)downSati);

            bySkin = workBySkin;
        }

        public void GetSystemConfigurationsForNewForm(out List<int> decemalValues,                                                     
                                                      out bool bySkin,
                                                      out Capture cam)
        {
            decemalValues = new List<int>();

            decemalValues.Add((int)maxPerimeter);
            decemalValues.Add((int)minPerimeter);

            decemalValues.Add((int)upHue);
            decemalValues.Add((int)downHue);
            decemalValues.Add((int)upSati);
            decemalValues.Add((int)downSati);


            bySkin = workBySkin;

            cam = camera;
        }

        public void LounchHeper()
        {
            System.Diagnostics.Process.Start("Helper.exe");
        }

      


        #region Filter configurations

        public void LounchCalibrationForm()
        {
            Forms.fCalibration fCalib = new fCalibration(this.camera.QueryFrame().ToBitmap(), this);
            fCalib.ShowDialog();
        }

        public void SkinMode(bool mode)
        {
            workBySkin = mode;
        }

        public void SetNew_ColorHue(double up, double bottom)
        {
            this.upHue = up;
            this.downHue = bottom;
        }

        public void SetNew_ColorSati(double up, double bottom)
        {
            this.upSati = up;
            this.downSati = bottom;
        }

        public void SetNew_minPerimeter(decimal perimeter)
        {
            if (perimeter > 0)
            {
                minPerimeter = perimeter;
            }
        }
        public void SetNew_maxPerimeter(decimal perimeter)
        {
            if (perimeter > 0 && perimeter > minPerimeter)
            {
                maxPerimeter = perimeter;
            }            
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
                processor.IdentifyContours(this.camera.QueryFrame().ToBitmap(),0, shouldInvert, (int)minPerimeter, (int)maxPerimeter,
                                           out gray, out color, out findedHands);
            }
            else
            {
                //processor.IdentifyContours(this.camera.QueryFrame().ToBitmap(), shouldInvert, (int)minPerimeter, (int)maxPerimeter,
                //                           (int)Red[1], (int)Green[1], (int)Blue[1],
                //                           (int)Red[0], (int)Green[0], (int)Blue[0],
                //                           out gray, out color, out findedHands);
                processor.IdentifyContours(this.camera.QueryFrame().ToBitmap(), 0, 0, (int)minPerimeter, (int)maxPerimeter
                                           , out color, out gray, out findedHands);
                
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
            write.WriteLine("By skin:" + workBySkin);
          
            write.WriteLine(pathToSaveFolder);

            write.Close();
        }
        
        private void LoadSettings()
        {
            if (File.Exists("settings.svSt"))
            {
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
                        case "By skin":
                            workBySkin = Convert.ToBoolean(m[1]);
                            break;
                        case "Delta_colos_Search":
                          //  deltaBetweenMinMaxColorCode = Convert.ToDouble(m[1]);
                            break;
                        case "Radius_color_Search":
                         //   radiusOfSearchColorArea = Convert.ToDouble(m[1]);
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
            maxPerimeter = 100;
            minPerimeter = 100;
          
            shouldInvert = false;
            workBySkin   = true;
        }

        #endregion

    }
}
