using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StadyNeuronNet.Presenter;
using System.IO;

namespace StadyNeuronNet
{
    public partial class Form1 : Form
    {
        NetPresenter presenter;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            presenter = new NetPresenter(this);

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.SaveMemory();
        }







        private void bn_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // openFileDialog1.InitialDirectory = "c:\\";
            ofd.Title = "select necessary image";
            ofd.Filter = " (*.jpg)|*.jpg| (*.bmp)|*.bmp";         
            ofd.Multiselect = false;

            if ((ofd.ShowDialog() == DialogResult.OK))
            {
                pb_ImageForStudy.ImageLocation = ofd.FileName;
                presenter.SetPathImage(ofd.FileName);
            }
        }
               

        private void bn_RecognizeImage_Click(object sender, EventArgs e)
        {
            presenter.RecognizeGesture(tb_ResultOfNeuroNet.Text);
        }

        private void bn_Stady_Click(object sender, EventArgs e)
        {
            presenter.Stady(tb_ResultOfNeuroNet.Text);
        }

        private void bn_stadyFromFolder_Click(object sender, EventArgs e)
        {
            presenter.StadyFromFolder(tb_adressForFolder.Text, tb_ResultOfNeuroNet.Text);
        }


        public void ShowMessage(string text)
        {
            if (text.Length != 0)
            {
                MessageBox.Show(text);
            }
        }

        public void ShowDialog(string text)
        {
            if (text.Length != 0)
            {
                if (MessageBox.Show(text, "Is it correct?", MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }

        public void SetResult(string result)
        {
            if (result.Length != 0)
            {
                tb_ResultOfNeuroNet.Text = result;
                MessageBox.Show("Result is " + result);
            }
        }

        
    }
}
