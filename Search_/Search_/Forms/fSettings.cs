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
        bool needToSearchColor;



              

        public fSettings()
        {
            InitializeComponent();

            presenter = new ConfigurationPresenter(this);

            LoadSettings();
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
            needToSearchColor = true;         
            MessageBox.Show("Set mouse to necessary color at color image and press lest button");
            pb_original.SizeMode = PictureBoxSizeMode.Normal;

        }
        #endregion

        #region numerics
        private void num_Hue_low_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Red(num_Hue_low.Value, num_Hue_high.Value);
        }
        private void num_Hue_high_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Red(num_Hue_low.Value, num_Hue_high.Value);
        }

        private void num_Satuation_low_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Green(num_Satuation_low.Value, num_Satuation_high.Value);
        }
        private void num_Satuation_high_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Green(num_Satuation_low.Value, num_Satuation_high.Value);
        }

        private void num_Value_low_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Blue(num_Value_low.Value, num_Value_high.Value);
        }
        private void num_Value_high_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Blue(num_Value_low.Value, num_Value_high.Value);
        }


        private void num_trash_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_Trash(num_trash.Value);
        }
        private void num_trashLink_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_TrashLink(num_trashLink.Value);
        }


        private void num_ColorPossibleDelta_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_DeltaSearchColor(num_ColorPossibleDelta.Value);
        }
        private void num_RadiusSearchArea_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_RadiusSearchColor(num_RadiusSearchArea.Value);
        }


        private void num_Min_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_minPerimeter(num_Min.Value);
        }
        private void num_Max_ValueChanged(object sender, EventArgs e)
        {
            presenter.SetNew_maxPerimeter(num_Max.Value);
        }
        #endregion

        #region check box
        private void cb_invertImg_CheckedChanged(object sender, EventArgs e)
        {
            presenter.SetNew_InvertImage(cb_invertImg.Checked);
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

        private void Configuration_forn_MouseClick(object sender, MouseEventArgs e)
        {
            if (needToSearchColor && e.Button == MouseButtons.Left)
            {
                FrameTimer.Enabled = false;
               
                presenter.SearchColor(pb_original.Image, e.Location);
                LoadSettings();
                MessageBox.Show("color detected");
                needToSearchColor = false;


                // pb_gesture_1.Image = img;
                FrameTimer.Enabled = true;
                pb_original.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }





        private void LoadSettings()
        {
            List<decimal> valuesForNumeric;
            bool invertImage;
            bool workWithSkin;

            presenter.GetSystemConfigurations(out valuesForNumeric, out invertImage, out workWithSkin);


            num_Max.Value = (int)valuesForNumeric[0];
            num_Min.Value = (int)valuesForNumeric[1];
            num_trash.Value = (int)valuesForNumeric[2];
            num_trashLink.Value = (int)valuesForNumeric[3];
            num_Hue_low.Value = (int)valuesForNumeric[4];
            num_Satuation_low.Value = (int)valuesForNumeric[5];
            num_Value_low.Value = (int)valuesForNumeric[6];
            num_Hue_high.Value = (int)valuesForNumeric[7];
            num_Satuation_high.Value = (int)valuesForNumeric[8];
            num_Value_high.Value = (int)valuesForNumeric[9];
            num_ColorPossibleDelta.Value = (int)valuesForNumeric[10];
            num_RadiusSearchArea.Value = (int)valuesForNumeric[11];

            cb_invertImg.Checked = invertImage;

            needToSearchColor = false;
        }

        private void cb_BySkin_CheckedChanged(object sender, EventArgs e)
        {
            presenter.SkinMode(cb_BySkin.Checked);
        }
    }
}
