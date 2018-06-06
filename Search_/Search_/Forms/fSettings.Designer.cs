namespace Search_.Forms
{
    partial class fSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.bn_SearchColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Min = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.Label();
            this.num_Max = new System.Windows.Forms.NumericUpDown();
            this.cb_BySkin = new System.Windows.Forms.CheckBox();
            this.bn_Stop = new System.Windows.Forms.Button();
            this.bn_ToMain = new System.Windows.Forms.Button();
            this.lb_gestVal_1 = new System.Windows.Forms.Label();
            this.lb_recognizeGesture = new System.Windows.Forms.Label();
            this.pb_gesture_1 = new System.Windows.Forms.PictureBox();
            this.bn_saveToFolder = new System.Windows.Forms.Button();
            this.bn_Start = new System.Windows.Forms.Button();
            this.pb_result = new System.Windows.Forms.PictureBox();
            this.pb_original = new System.Windows.Forms.PictureBox();
            this.FrameTimer = new System.Windows.Forms.Timer(this.components);
            this.bn_helper = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gesture_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bn_SearchColor
            // 
            this.bn_SearchColor.Location = new System.Drawing.Point(111, 19);
            this.bn_SearchColor.Name = "bn_SearchColor";
            this.bn_SearchColor.Size = new System.Drawing.Size(121, 38);
            this.bn_SearchColor.TabIndex = 31;
            this.bn_SearchColor.Text = "Recognize color";
            this.bn_SearchColor.UseVisualStyleBackColor = true;
            this.bn_SearchColor.Click += new System.EventHandler(this.bn_SearchColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.num_Min);
            this.groupBox2.Controls.Add(this.max);
            this.groupBox2.Controls.Add(this.num_Max);
            this.groupBox2.Location = new System.Drawing.Point(14, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 40);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perimeter of correct area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Min";
            // 
            // num_Min
            // 
            this.num_Min.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Min.Location = new System.Drawing.Point(32, 18);
            this.num_Min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Min.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Min.Name = "num_Min";
            this.num_Min.Size = new System.Drawing.Size(59, 20);
            this.num_Min.TabIndex = 4;
            this.num_Min.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Min.ValueChanged += new System.EventHandler(this.num_Min_ValueChanged);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(121, 23);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(27, 13);
            this.max.TabIndex = 7;
            this.max.Text = "Max";
            // 
            // num_Max
            // 
            this.num_Max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Max.Location = new System.Drawing.Point(154, 18);
            this.num_Max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Max.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Max.Name = "num_Max";
            this.num_Max.Size = new System.Drawing.Size(58, 20);
            this.num_Max.TabIndex = 5;
            this.num_Max.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Max.ValueChanged += new System.EventHandler(this.num_Max_ValueChanged);
            // 
            // cb_BySkin
            // 
            this.cb_BySkin.AutoSize = true;
            this.cb_BySkin.Location = new System.Drawing.Point(22, 32);
            this.cb_BySkin.Name = "cb_BySkin";
            this.cb_BySkin.Size = new System.Drawing.Size(60, 17);
            this.cb_BySkin.TabIndex = 36;
            this.cb_BySkin.Text = "By skin";
            this.cb_BySkin.UseVisualStyleBackColor = true;
            this.cb_BySkin.CheckedChanged += new System.EventHandler(this.cb_BySkin_CheckedChanged);
            // 
            // bn_Stop
            // 
            this.bn_Stop.Location = new System.Drawing.Point(448, 347);
            this.bn_Stop.Name = "bn_Stop";
            this.bn_Stop.Size = new System.Drawing.Size(172, 40);
            this.bn_Stop.TabIndex = 48;
            this.bn_Stop.Text = "Stop\r\ncamera";
            this.bn_Stop.UseVisualStyleBackColor = true;
            this.bn_Stop.Click += new System.EventHandler(this.bn_Stop_Click);
            // 
            // bn_ToMain
            // 
            this.bn_ToMain.Location = new System.Drawing.Point(448, 407);
            this.bn_ToMain.Name = "bn_ToMain";
            this.bn_ToMain.Size = new System.Drawing.Size(172, 52);
            this.bn_ToMain.TabIndex = 47;
            this.bn_ToMain.Text = "To Control";
            this.bn_ToMain.UseVisualStyleBackColor = true;
            this.bn_ToMain.Click += new System.EventHandler(this.bn_ToMain_Click);
            // 
            // lb_gestVal_1
            // 
            this.lb_gestVal_1.AutoSize = true;
            this.lb_gestVal_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_gestVal_1.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_gestVal_1.Location = new System.Drawing.Point(124, 295);
            this.lb_gestVal_1.Name = "lb_gestVal_1";
            this.lb_gestVal_1.Size = new System.Drawing.Size(19, 20);
            this.lb_gestVal_1.TabIndex = 46;
            this.lb_gestVal_1.Text = "  ";
            // 
            // lb_recognizeGesture
            // 
            this.lb_recognizeGesture.AutoSize = true;
            this.lb_recognizeGesture.Location = new System.Drawing.Point(9, 287);
            this.lb_recognizeGesture.Name = "lb_recognizeGesture";
            this.lb_recognizeGesture.Size = new System.Drawing.Size(96, 13);
            this.lb_recognizeGesture.TabIndex = 45;
            this.lb_recognizeGesture.Text = "Recognize gesture";
            // 
            // pb_gesture_1
            // 
            this.pb_gesture_1.Location = new System.Drawing.Point(12, 304);
            this.pb_gesture_1.MaximumSize = new System.Drawing.Size(200, 185);
            this.pb_gesture_1.Name = "pb_gesture_1";
            this.pb_gesture_1.Size = new System.Drawing.Size(176, 153);
            this.pb_gesture_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_gesture_1.TabIndex = 44;
            this.pb_gesture_1.TabStop = false;
            // 
            // bn_saveToFolder
            // 
            this.bn_saveToFolder.Location = new System.Drawing.Point(323, 422);
            this.bn_saveToFolder.Name = "bn_saveToFolder";
            this.bn_saveToFolder.Size = new System.Drawing.Size(119, 37);
            this.bn_saveToFolder.TabIndex = 43;
            this.bn_saveToFolder.Text = "Save gesture";
            this.bn_saveToFolder.UseVisualStyleBackColor = true;
            this.bn_saveToFolder.Click += new System.EventHandler(this.bn_saveToFolder_Click);
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(448, 304);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(172, 37);
            this.bn_Start.TabIndex = 42;
            this.bn_Start.Text = "Lounch camera";
            this.bn_Start.UseVisualStyleBackColor = true;
            this.bn_Start.Click += new System.EventHandler(this.bn_Start_Click);
            // 
            // pb_result
            // 
            this.pb_result.Location = new System.Drawing.Point(346, 12);
            this.pb_result.Name = "pb_result";
            this.pb_result.Size = new System.Drawing.Size(274, 272);
            this.pb_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_result.TabIndex = 41;
            this.pb_result.TabStop = false;
            // 
            // pb_original
            // 
            this.pb_original.Location = new System.Drawing.Point(12, 12);
            this.pb_original.Name = "pb_original";
            this.pb_original.Size = new System.Drawing.Size(298, 272);
            this.pb_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_original.TabIndex = 40;
            this.pb_original.TabStop = false;
            // 
            // FrameTimer
            // 
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // bn_helper
            // 
            this.bn_helper.Location = new System.Drawing.Point(194, 422);
            this.bn_helper.Name = "bn_helper";
            this.bn_helper.Size = new System.Drawing.Size(123, 37);
            this.bn_helper.TabIndex = 52;
            this.bn_helper.Text = "Help";
            this.bn_helper.UseVisualStyleBackColor = true;
            this.bn_helper.Click += new System.EventHandler(this.bn_helper_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cb_BySkin);
            this.groupBox1.Controls.Add(this.bn_SearchColor);
            this.groupBox1.Location = new System.Drawing.Point(194, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 112);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter configurations";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bn_helper);
            this.Controls.Add(this.bn_Stop);
            this.Controls.Add(this.bn_ToMain);
            this.Controls.Add(this.lb_gestVal_1);
            this.Controls.Add(this.lb_recognizeGesture);
            this.Controls.Add(this.pb_gesture_1);
            this.Controls.Add(this.bn_saveToFolder);
            this.Controls.Add(this.bn_Start);
            this.Controls.Add(this.pb_result);
            this.Controls.Add(this.pb_original);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 510);
            this.MinimumSize = new System.Drawing.Size(650, 510);
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gesture_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_SearchColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.NumericUpDown num_Max;
        private System.Windows.Forms.Button bn_Stop;
        private System.Windows.Forms.Button bn_ToMain;
        private System.Windows.Forms.Label lb_gestVal_1;
        private System.Windows.Forms.Label lb_recognizeGesture;
        private System.Windows.Forms.PictureBox pb_gesture_1;
        private System.Windows.Forms.Button bn_saveToFolder;
        private System.Windows.Forms.Button bn_Start;
        private System.Windows.Forms.PictureBox pb_result;
        private System.Windows.Forms.PictureBox pb_original;
        private System.Windows.Forms.Timer FrameTimer;
        private System.Windows.Forms.CheckBox cb_BySkin;
        private System.Windows.Forms.Button bn_helper;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}