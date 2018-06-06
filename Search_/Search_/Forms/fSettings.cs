using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Search_.Presenters;


namespace Search_.Forms
{
    public partial class fSettings : Form
    {
        ConfigurationPresenter presenter;
       

              

        public fSettings()
        {
            InitializeComponent();

            presenter = new ConfigurationPresenter(this);

            //LoadSettings();
        }


        #region buttons
        private void bn_Start_Click(object sender, EventArgs e)
        {
            FrameTimer.Enabled = true;
            presenter.StartToTakeVideo();
        }
        private void bn_Stop_Click(object sender, EventArgs e)
        {
            FrameTimer.Enabled = false;           
        }
        private void bn_saveToFolder_Click(object sender, EventArgs e)
        {
            presenter.SaveGesture();
        }
        private void bn_ToMain_Click(object sender, EventArgs e)
        {
            fDisplay fMain = new fDisplay(presenter, presenter.GetPathToFolder);
            fMain.ShowDialog();
        }
        private void bn_SearchColor_Click(object sender, EventArgs e)
        {
            presenter.LounchCalibrationForm();
            LoadSettings();
        }
        #endregion

        #region Numerics

       
        private void num_Min_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_minPerimeter(num_Min.Value);
        }
        private void num_Max_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_maxPerimeter(num_Max.Value);
        }
      
        
        #endregion

        private void FrameTimer_Tick(object sender, EventArgs e)
        {

            Bitmap color;
            Bitmap gray;
            Bitmap gesture;
            string gest;

            presenter.NewFrame(out color, out gray, out gesture, out gest);

            pb_original.Image = color;
            pb_result.Image = gray;
            pb_gesture_1.Image = gesture;
            lb_gestVal_1.Text = gest;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrameTimer.Enabled = false;

            presenter.StopToTakeVideo();
            presenter.SaveSettings();
        }

            
        

        private void cb_BySkin_CheckedChanged(object sender, EventArgs e)
        {
            presenter.SkinMode(cb_BySkin.Checked);
        }

        private void bn_helper_Click(object sender, EventArgs e)
        {
            presenter.LounchHeper();
        }


        private void LoadSettings()
        {
            List<decimal> valuesForNumeric;           
            bool workWithSkin;

            presenter.GetSystemConfigurations(out valuesForNumeric, out workWithSkin);

            num_Max.Value = (int)valuesForNumeric[0];
            num_Min.Value = (int)valuesForNumeric[1];
            cb_BySkin.Checked = workWithSkin;
        }
    }
}
