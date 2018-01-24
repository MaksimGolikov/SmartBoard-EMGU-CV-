using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
using System.IO;


namespace Search_.ServersOperation
{
    class WorkWithImage
    {

        string pathImageStorage;
        WebClient thisClient;


        public WorkWithImage(string path)
        {
            pathImageStorage = path;
            thisClient = new WebClient();
        }




        public Bitmap LoadImageFromServer()
        {
            Bitmap res = new Bitmap(1, 1);

            //thisClient.DownloadFileAsync(new Uri(pathImageStorage), "Resourse/" + System.IO.Path.GetFileName(pathImageStorage));

            try
            {              
                using (var s = new FileStream("Resourse/img.png", FileMode.Open))
                {
                    res = (Bitmap)Image.FromStream(s);
                }
            }
            catch
            {

            }

            return res;
        }


        public void ClearImage()
        {
            if (File.Exists("Resourse/img.png"))
            {
                File.Delete("Resourse/img.png");
            }
        }


    }
}
