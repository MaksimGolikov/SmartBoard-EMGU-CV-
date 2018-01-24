using System;
using System.Drawing;
using System.Windows.Forms;
using Search_.Presenters;



namespace Search_.Forms
{
    public partial class fDisplay : Form
    {

        ObjectControlPresenter presenter;  





        public fDisplay(ConfigurationPresenter tmpPresenter, string new_path)
        {
            InitializeComponent();




            presenter = new ObjectControlPresenter(this, tmpPresenter, new_path);

            this.Size = presenter.GetScreenSize;
            pn_Display.Size = presenter.GetScreenSize;
            

            FrameTimer.Enabled = true;
            CheckImage.Enabled = true;


            presenter.LoadObjects();
                     
        }

        private void fDisplay_Load(object sender, EventArgs e)
        {
            presenter.DrawObjects(pn_Display);
        }



        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            presenter.NewFrame(pn_Display);
            lb_CurrentOperation.Text = presenter.GetNameOfCurrentOperation;
        }

        private void CheckImage_Tick(object sender, EventArgs e)
        {
            presenter.AddNewObject();
        }



        private void fDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            presenter.EndProcess();
            FrameTimer.Enabled = false;           
        }

        private void showHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      
        }











       

        





    }
}
