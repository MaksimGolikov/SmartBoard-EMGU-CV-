using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search_.Forms;
using Search_.Objects;
using System.Drawing;
using Search_.NeuralNet;
using System.Windows.Forms;
using Search_.ServersOperation;
using Search_.WorkWithVideoStream;

namespace Search_.Presenters
{
    class ObjectControlPresenter
    {
        fDisplay form;




        ControlsObject controlObject;


        #region Filter configuration
        int minPerimeter;
        int maxPerimeter;
        int thr;
        int thrL;
        int Red_low;
        int Green_low;
        int Blue_low;
        int Red_high;
        int Green_high;
        int Blue_high;


        int intensity;
        bool invert;
        #endregion

        #region Objects for recognize

        Emgu.CV.Capture camera;
        FindContours processor;
        Bitmap colorImage;
        private NetOfNeuron netOfNeurons;
        private int[,] mass;

        #endregion

        #region For logic of work

        bool isRecognezeByColor;

        double deltaCoefficient_X;
        double deltaCoefficient_Y;



        Operations operationForFilter;
        string lastReadOperation;
        int countChange;
        Point middleOfGesture;
        Point startPosition;

        bool isGestureCanBeChange;
        string path;

        Size screenSize;

        WorkWithImage serverImage;
        PictureBox mouse;

        #endregion
        
        public Size    GetScreenSize {get =>screenSize;}   
        public string GetNameOfCurrentOperation { get => controlObject.LastOperations.ToString();  }





        public ObjectControlPresenter(fDisplay newForm, ConfigurationPresenter tmpPresenter, string new_path)
        {
            form = newForm;
            path = new_path;


            controlObject = new ControlsObject();
            netOfNeurons = new NetOfNeuron();
            processor = new FindContours();
            mouse = new PictureBox();
            serverImage = new WorkWithImage(new_path);


            List<int> configurations;
            Emgu.CV.Capture c;

            tmpPresenter.GetSystemConfigurationsForNewForm(out configurations, out invert, out isRecognezeByColor, out c);

            minPerimeter = configurations[0];
            maxPerimeter = configurations[1];

            thr = configurations[2];
            thrL = configurations[3];
            Red_low = configurations[4];
            Red_high = configurations[5];
            Green_low = configurations[6];
            Green_high = configurations[7];
            Blue_low = configurations[8];
            Blue_high = configurations[9];


            operationForFilter = Operations.NONE;
            lastReadOperation = "";
            countChange = 0;


            screenSize = new Size(SystemInformation.VirtualScreen.Width,
                                  SystemInformation.VirtualScreen.Height);           

            if (c == null)
            {
                camera = new Emgu.CV.Capture();
            }
            else
            {
                camera = c;
            }
            

            var forCalculateCoeffisient = colorImage = camera.QueryFrame().ToBitmap();
            deltaCoefficient_X = (float)screenSize.Width  / forCalculateCoeffisient.Width;
            deltaCoefficient_Y = (float)screenSize.Height / forCalculateCoeffisient.Height;

            isGestureCanBeChange = false;
        }

        public void LounchHelper()
        {
            System.Diagnostics.Process.Start("Helper.exe");
        }

        public void LoadObjects()
        {
            /*mouse*/

            Bitmap img = (Bitmap)Image.FromFile("Resourse/point1.png");
            mouse.Image = img;
            mouse.Location = new Point(screenSize.Width / 2, screenSize.Height / 2);
            mouse.Size = new Size(10, 10);




            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/1.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));
            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/2.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));
            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/3.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));
            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/4.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));
            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/4.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));
            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/5.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));
            controlObject.AddNewObject((Bitmap)Image.FromFile("Resourse/6.png"),
                                      new Point(screenSize.Width / 2,
                                                screenSize.Height / 2));            

        }
        
        public void DrawObjects(Panel panel)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            panel.Controls.Add(mouse);


            var allObjects = controlObject.GetAllObjects;

            foreach (var obj in allObjects)
            {
                panel.Controls.Add(new PictureBox()
                {
                    Name = obj.Id.ToString(),
                    Image = obj.Pictire,
                    Location = obj.Position.Location,
                    Size = obj.Position.Size
                });               
            }
        }

        public void NewFrame(Panel panel)
        {
            colorImage = camera.QueryFrame().ToBitmap();

                     

            List<RecognitionType> findedobj = new List<RecognitionType>();

            if (isRecognezeByColor)
            {
                 processor.IdentifyContours(colorImage, minPerimeter, maxPerimeter, out findedobj);
            }
            else
            {
               processor.IdentifyContours(colorImage, thr, invert, minPerimeter, maxPerimeter, 
               Red_low, Green_low, Blue_low,
               Red_high, Green_high, Blue_high,
               out findedobj);
            }

            if (findedobj.Count > 0)
            {
                middleOfGesture = new Point(findedobj[0].GesturePosition.X + findedobj[0].GesturePosition.Width / 2,
                                       findedobj[0].GesturePosition.Y + findedobj[0].GesturePosition.Height / 2);
                RecognizeGesture(findedobj[0].GestureImage);


                mouse.Location = middleOfGesture;
            }
            else
            {
                mouse.Location = new Point(-10, -10);
            }
                  


            if (operationForFilter != Operations.NONE && isGestureCanBeChange)
            {
                LogicOfoperation();


                controlObject.ControlObjectState(middleOfGesture);

                if (controlObject.IsAnyObjectSelected() &&
                   (controlObject.LastOperations != Operations.TAKE && 
                    controlObject.LastOperations != Operations.BREAK &&
                    controlObject.LastOperations != Operations.NONE))
                {
                    DrawObjects(panel);
                }

            }            
           
        }
        
        public  void AddNewObject()
        {
            var tmpImg = serverImage.LoadImageFromServer();

            if (tmpImg.Size != new Size(1, 1))
            {
                controlObject.AddNewObject(tmpImg,
                                           new Point(screenSize.Width / 2,
                                           screenSize.Height / 2));
                serverImage.ClearImage();               
            }

        }

        


        public void EndProcess()
        {
            camera = null;
        }




        private void RecognizeGesture(Bitmap img)
        {
            Bitmap bitmap = img;

            int[,] clipArr = ImageConvert.CutImageToArray(bitmap, new Point(bitmap.Width, bitmap.Height));
            if (clipArr != null)
            {
                mass = ImageConvert.LeadArray(clipArr, new int[NetOfNeuron.neironInArrayWidth, NetOfNeuron.neironInArrayHeight]);

                string symbbvol = netOfNeurons.CheckLitera(mass);
                if (symbbvol == null) symbbvol = "gesture don`t find";

                DigitalFilterOfGesture(symbbvol);
            }
        }
        
        private void DigitalFilterOfGesture(string recognezedGesture)
        {
            if (recognezedGesture != lastReadOperation)
            {
                countChange = 0;
                lastReadOperation = recognezedGesture;
                isGestureCanBeChange = false;
            }
            else
            {
                if (countChange > 2)
                {
                    switch (recognezedGesture)
                    {
                        case "take":
                            operationForFilter = Operations.TAKE;
                            break;
                        case "move":
                            operationForFilter = Operations.MOVE;
                            break;
                        case "break":
                            operationForFilter = Operations.BREAK;
                            break;
                        case "scale":
                            operationForFilter = Operations.SCALE;
                            break;
                        case "delete":
                            operationForFilter = Operations.DELETE;
                            break;
                        default:
                            operationForFilter = Operations.NONE;
                            break;
                    }
                    isGestureCanBeChange = true;
                }
                countChange++;

                if (countChange > 10)
                {
                    countChange = 10;
                }
            }

            middleOfGesture.X = (int)(middleOfGesture.X * deltaCoefficient_X);
            middleOfGesture.Y = (int)(middleOfGesture.Y * deltaCoefficient_Y);

        }

        private void LogicOfoperation()
        {
            if ((controlObject.LastOperations == Operations.BREAK || controlObject.LastOperations == Operations.NONE) &&
                 operationForFilter == Operations.TAKE)
            {
                controlObject.LastOperations = Operations.TAKE;
                controlObject.SelectObject(middleOfGesture);

                if (!controlObject.IsAnyObjectSelected())
                {
                    controlObject.LastOperations = Operations.BREAK;
                }
            }

            if (controlObject.IsAnyObjectSelected() && operationForFilter == Operations.MOVE && controlObject.LastOperations != Operations.SCALE)
            {
                controlObject.LastOperations = Operations.MOVE;
            }

            if (controlObject.IsAnyObjectSelected() && operationForFilter == Operations.BREAK)
            {
                controlObject.LastOperations = Operations.BREAK;
                controlObject.DeselectObject();
            }

            if (controlObject.IsAnyObjectSelected() && operationForFilter == Operations.SCALE)
            {
                 controlObject.LastOperations = Operations.SCALE;
            }

            if (controlObject.IsAnyObjectSelected() && operationForFilter == Operations.DELETE)
            {
                  controlObject.LastOperations = Operations.DELETE;               
            }
                        
        }






    }
}
