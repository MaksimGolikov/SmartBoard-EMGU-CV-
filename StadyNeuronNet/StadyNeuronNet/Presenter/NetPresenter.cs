using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StadyNeuronNet.Logic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;



namespace StadyNeuronNet.Presenter
{
    class NetPresenter
    {
        private NetOfNeuron netOfNeurons;
        private Form1 form;
        private string pathOfImageForRecognize;
        private int[,] mass;




        public NetPresenter(Form1 forms)
        {
            netOfNeurons = new NetOfNeuron();
            this.form = forms;

        }



        public void SetPathImage(string path)
        {
            pathOfImageForRecognize = path;
        }


        public void Stady(string nameImage)
        {           
            netOfNeurons.SetTraining(nameImage, mass);
            form.ShowMessage("gesture staded");
        }



        public void RecognizeGesture(string name)
        {
          
                Bitmap bitmap = (Bitmap)Image.FromFile(pathOfImageForRecognize, true);
               
                int[,] clipArr = ImageConvert.CutImageToArray(bitmap, new Point(bitmap.Width, bitmap.Height));
                if (clipArr != null)
                {
                    mass = ImageConvert.LeadArray(clipArr, new int[NetOfNeuron.neironInArrayWidth, NetOfNeuron.neironInArrayHeight]);

                    string symbbvol = netOfNeurons.CheckLitera(mass);
                    if (symbbvol == null) symbbvol = "null";

                    DialogResult askResult = MessageBox.Show("Resalt of recognize - " + symbbvol + " ?", "", MessageBoxButtons.YesNo);
                    if (askResult == DialogResult.Yes)
                    {
                        netOfNeurons.SetTraining(symbbvol, mass);
                        form.SetResult(symbbvol);
                    }
                    else
                    {
                        if( MessageBox.Show("Добавить этот образ в память нейрона '" + name + "'", "", MessageBoxButtons.YesNo) == DialogResult.Yes){
                            netOfNeurons.SetTraining(name, mass);
                            form.SetResult(name);
                        }
                    }
                   
                }
                
        }


        public void StadyFromFolder(string pathToFolder, string name)
        {
            var filePaths = Directory.GetFiles(pathToFolder + "/" + name);

            foreach (var itm in filePaths)
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(itm, true);

                int[,] clipArr = ImageConvert.CutImageToArray(bitmap, new Point(bitmap.Width, bitmap.Height));
                if (clipArr != null)
                {
                    mass = ImageConvert.LeadArray(clipArr, new int[NetOfNeuron.neironInArrayWidth, NetOfNeuron.neironInArrayHeight]);

                    string symbbvol = netOfNeurons.CheckLitera(mass);

                    if (symbbvol != name)
                    {
                        netOfNeurons.SetTraining(name, mass);
                    }
                    else
                    {
                        netOfNeurons.SetTraining(symbbvol, mass);
                    }

                }
            }
            form.ShowMessage("gesture " + name + " was staded");
        }


        public void SaveMemory()
        {
            netOfNeurons.SaveState();
            form.ShowMessage("Memory was saved");
        }



    }
}
