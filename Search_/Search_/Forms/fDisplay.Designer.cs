namespace Search_.Forms
{
    partial class fDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDisplay));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_CurrentOperation = new System.Windows.Forms.Label();
            this.lb_position = new System.Windows.Forms.Label();
            this.pn_Display = new System.Windows.Forms.Panel();
            this.CheckImage = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToSettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backToSettingsToolStripMenuItem
            // 
            this.backToSettingsToolStripMenuItem.Name = "backToSettingsToolStripMenuItem";
            this.backToSettingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.backToSettingsToolStripMenuItem.Text = "Back to settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // showHelperToolStripMenuItem
            // 
            this.showHelperToolStripMenuItem.Name = "showHelperToolStripMenuItem";
            this.showHelperToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.showHelperToolStripMenuItem.Text = "Show helper";
            this.showHelperToolStripMenuItem.Click += new System.EventHandler(this.showHelperToolStripMenuItem_Click);
            // 
            // FrameTimer
            // 
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // lb_CurrentOperation
            // 
            this.lb_CurrentOperation.AutoSize = true;
            this.lb_CurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_CurrentOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_CurrentOperation.Location = new System.Drawing.Point(419, 4);
            this.lb_CurrentOperation.Name = "lb_CurrentOperation";
            this.lb_CurrentOperation.Size = new System.Drawing.Size(57, 20);
            this.lb_CurrentOperation.TabIndex = 2;
            this.lb_CurrentOperation.Text = "label1";
            // 
            // lb_position
            // 
            this.lb_position.AutoSize = true;
            this.lb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_position.Location = new System.Drawing.Point(550, 4);
            this.lb_position.Name = "lb_position";
            this.lb_position.Size = new System.Drawing.Size(51, 16);
            this.lb_position.TabIndex = 3;
            this.lb_position.Text = "label1";
            // 
            // pn_Display
            // 
            this.pn_Display.Location = new System.Drawing.Point(0, 27);
            this.pn_Display.Name = "pn_Display";
            this.pn_Display.Size = new System.Drawing.Size(707, 351);
            this.pn_Display.TabIndex = 5;
            // 
            // CheckImage
            // 
            this.CheckImage.Interval = 1000;
            this.CheckImage.Tick += new System.EventHandler(this.CheckImage_Tick);
            // 
            // fDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 378);
            this.Controls.Add(this.pn_Display);
            this.Controls.Add(this.lb_position);
            this.Controls.Add(this.lb_CurrentOperation);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fDisplay_FormClosed);
            this.Load += new System.EventHandler(this.fDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.Label lb_CurrentOperation;
        private System.Windows.Forms.ToolStripMenuItem showHelperToolStripMenuItem;
        private System.Windows.Forms.Label lb_position;
        private System.Windows.Forms.Panel pn_Display;
        private System.Windows.Forms.Timer CheckImage;
    }
}