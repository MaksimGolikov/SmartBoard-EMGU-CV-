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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.num_RadiusSearchArea = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.num_ColorPossibleDelta = new System.Windows.Forms.NumericUpDown();
            this.bn_SearchColor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Min = new System.Windows.Forms.NumericUpDown();
            this.max = new System.Windows.Forms.Label();
            this.num_Max = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_trashLink = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_invertImg = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num_trash = new System.Windows.Forms.NumericUpDown();
            this.num_Value_high = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.num_Satuation_high = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.num_Hue_high = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_Hue_low = new System.Windows.Forms.NumericUpDown();
            this.num_Value_low = new System.Windows.Forms.NumericUpDown();
            this.num_Satuation_low = new System.Windows.Forms.NumericUpDown();
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
            this.cb_BySkin = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RadiusSearchArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ColorPossibleDelta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_trashLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value_high)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Satuation_high)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hue_high)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hue_low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value_low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Satuation_low)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gesture_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.num_RadiusSearchArea);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.num_ColorPossibleDelta);
            this.groupBox3.Controls.Add(this.bn_SearchColor);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(448, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 97);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search color";
            // 
            // num_RadiusSearchArea
            // 
            this.num_RadiusSearchArea.Location = new System.Drawing.Point(120, 49);
            this.num_RadiusSearchArea.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_RadiusSearchArea.Name = "num_RadiusSearchArea";
            this.num_RadiusSearchArea.Size = new System.Drawing.Size(56, 20);
            this.num_RadiusSearchArea.TabIndex = 39;
            this.num_RadiusSearchArea.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_RadiusSearchArea.ValueChanged += new System.EventHandler(this.num_RadiusSearchArea_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Radius for detect";
            // 
            // num_ColorPossibleDelta
            // 
            this.num_ColorPossibleDelta.Location = new System.Drawing.Point(119, 21);
            this.num_ColorPossibleDelta.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_ColorPossibleDelta.Name = "num_ColorPossibleDelta";
            this.num_ColorPossibleDelta.Size = new System.Drawing.Size(56, 20);
            this.num_ColorPossibleDelta.TabIndex = 37;
            this.num_ColorPossibleDelta.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_ColorPossibleDelta.ValueChanged += new System.EventHandler(this.num_ColorPossibleDelta_ValueChanged);
            // 
            // bn_SearchColor
            // 
            this.bn_SearchColor.Location = new System.Drawing.Point(37, 69);
            this.bn_SearchColor.Name = "bn_SearchColor";
            this.bn_SearchColor.Size = new System.Drawing.Size(108, 22);
            this.bn_SearchColor.TabIndex = 31;
            this.bn_SearchColor.Text = "Recognize color";
            this.bn_SearchColor.UseVisualStyleBackColor = true;
            this.bn_SearchColor.Click += new System.EventHandler(this.bn_SearchColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Possible color delta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.num_Min);
            this.groupBox2.Controls.Add(this.max);
            this.groupBox2.Controls.Add(this.num_Max);
            this.groupBox2.Location = new System.Drawing.Point(448, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 40);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perimeter of correct area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
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
            this.num_Min.Location = new System.Drawing.Point(33, 18);
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
            this.max.Location = new System.Drawing.Point(92, 23);
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
            this.num_Max.Location = new System.Drawing.Point(122, 18);
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
            this.num_Max.Size = new System.Drawing.Size(59, 20);
            this.num_Max.TabIndex = 5;
            this.num_Max.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_Max.ValueChanged += new System.EventHandler(this.num_Max_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_BySkin);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.num_trashLink);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_invertImg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num_trash);
            this.groupBox1.Controls.Add(this.num_Value_high);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.num_Satuation_high);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.num_Hue_high);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num_Hue_low);
            this.groupBox1.Controls.Add(this.num_Value_low);
            this.groupBox1.Controls.Add(this.num_Satuation_low);
            this.groupBox1.Location = new System.Drawing.Point(209, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 148);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter configurations";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Blue max";
            // 
            // num_trashLink
            // 
            this.num_trashLink.Location = new System.Drawing.Point(77, 126);
            this.num_trashLink.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_trashLink.Name = "num_trashLink";
            this.num_trashLink.Size = new System.Drawing.Size(57, 20);
            this.num_trashLink.TabIndex = 19;
            this.num_trashLink.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_trashLink.ValueChanged += new System.EventHandler(this.num_trashLink_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thrash link";
            // 
            // cb_invertImg
            // 
            this.cb_invertImg.AutoSize = true;
            this.cb_invertImg.Location = new System.Drawing.Point(159, 100);
            this.cb_invertImg.Name = "cb_invertImg";
            this.cb_invertImg.Size = new System.Drawing.Size(52, 17);
            this.cb_invertImg.TabIndex = 25;
            this.cb_invertImg.Text = "invert";
            this.cb_invertImg.UseVisualStyleBackColor = true;
            this.cb_invertImg.CheckedChanged += new System.EventHandler(this.cb_invertImg_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thrash";
            // 
            // num_trash
            // 
            this.num_trash.Location = new System.Drawing.Point(76, 100);
            this.num_trash.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_trash.Name = "num_trash";
            this.num_trash.Size = new System.Drawing.Size(57, 20);
            this.num_trash.TabIndex = 18;
            this.num_trash.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_trash.ValueChanged += new System.EventHandler(this.num_trash_ValueChanged);
            // 
            // num_Value_high
            // 
            this.num_Value_high.Location = new System.Drawing.Point(185, 68);
            this.num_Value_high.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_Value_high.Name = "num_Value_high";
            this.num_Value_high.Size = new System.Drawing.Size(48, 20);
            this.num_Value_high.TabIndex = 28;
            this.num_Value_high.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.num_Value_high.ValueChanged += new System.EventHandler(this.num_Value_high_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Green max";
            // 
            // num_Satuation_high
            // 
            this.num_Satuation_high.Location = new System.Drawing.Point(185, 42);
            this.num_Satuation_high.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_Satuation_high.Name = "num_Satuation_high";
            this.num_Satuation_high.Size = new System.Drawing.Size(48, 20);
            this.num_Satuation_high.TabIndex = 27;
            this.num_Satuation_high.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.num_Satuation_high.ValueChanged += new System.EventHandler(this.num_Satuation_high_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Red max";
            // 
            // num_Hue_high
            // 
            this.num_Hue_high.Location = new System.Drawing.Point(185, 16);
            this.num_Hue_high.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.num_Hue_high.Name = "num_Hue_high";
            this.num_Hue_high.Size = new System.Drawing.Size(48, 20);
            this.num_Hue_high.TabIndex = 26;
            this.num_Hue_high.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.num_Hue_high.ValueChanged += new System.EventHandler(this.num_Hue_high_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Blue min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Green min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Red min";
            // 
            // num_Hue_low
            // 
            this.num_Hue_low.Location = new System.Drawing.Point(64, 16);
            this.num_Hue_low.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.num_Hue_low.Name = "num_Hue_low";
            this.num_Hue_low.Size = new System.Drawing.Size(48, 20);
            this.num_Hue_low.TabIndex = 22;
            this.num_Hue_low.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.num_Hue_low.ValueChanged += new System.EventHandler(this.num_Hue_low_ValueChanged);
            // 
            // num_Value_low
            // 
            this.num_Value_low.Location = new System.Drawing.Point(64, 67);
            this.num_Value_low.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_Value_low.Name = "num_Value_low";
            this.num_Value_low.Size = new System.Drawing.Size(48, 20);
            this.num_Value_low.TabIndex = 24;
            this.num_Value_low.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.num_Value_low.ValueChanged += new System.EventHandler(this.num_Value_low_ValueChanged);
            // 
            // num_Satuation_low
            // 
            this.num_Satuation_low.Location = new System.Drawing.Point(64, 42);
            this.num_Satuation_low.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_Satuation_low.Name = "num_Satuation_low";
            this.num_Satuation_low.Size = new System.Drawing.Size(48, 20);
            this.num_Satuation_low.TabIndex = 23;
            this.num_Satuation_low.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.num_Satuation_low.ValueChanged += new System.EventHandler(this.num_Satuation_low_ValueChanged);
            // 
            // bn_Stop
            // 
            this.bn_Stop.Location = new System.Drawing.Point(211, 472);
            this.bn_Stop.Name = "bn_Stop";
            this.bn_Stop.Size = new System.Drawing.Size(110, 22);
            this.bn_Stop.TabIndex = 48;
            this.bn_Stop.Text = "Stop";
            this.bn_Stop.UseVisualStyleBackColor = true;
            this.bn_Stop.Click += new System.EventHandler(this.bn_Stop_Click);
            // 
            // bn_ToMain
            // 
            this.bn_ToMain.Location = new System.Drawing.Point(476, 444);
            this.bn_ToMain.Name = "bn_ToMain";
            this.bn_ToMain.Size = new System.Drawing.Size(108, 22);
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
            this.lb_recognizeGesture.Location = new System.Drawing.Point(9, 300);
            this.lb_recognizeGesture.Name = "lb_recognizeGesture";
            this.lb_recognizeGesture.Size = new System.Drawing.Size(96, 13);
            this.lb_recognizeGesture.TabIndex = 45;
            this.lb_recognizeGesture.Text = "Recognize gesture";
            // 
            // pb_gesture_1
            // 
            this.pb_gesture_1.Location = new System.Drawing.Point(12, 318);
            this.pb_gesture_1.MaximumSize = new System.Drawing.Size(200, 185);
            this.pb_gesture_1.Name = "pb_gesture_1";
            this.pb_gesture_1.Size = new System.Drawing.Size(179, 185);
            this.pb_gesture_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_gesture_1.TabIndex = 44;
            this.pb_gesture_1.TabStop = false;
            // 
            // bn_saveToFolder
            // 
            this.bn_saveToFolder.Location = new System.Drawing.Point(346, 444);
            this.bn_saveToFolder.Name = "bn_saveToFolder";
            this.bn_saveToFolder.Size = new System.Drawing.Size(108, 22);
            this.bn_saveToFolder.TabIndex = 43;
            this.bn_saveToFolder.Text = "Save gesture";
            this.bn_saveToFolder.UseVisualStyleBackColor = true;
            this.bn_saveToFolder.Click += new System.EventHandler(this.bn_saveToFolder_Click);
            // 
            // bn_Start
            // 
            this.bn_Start.Location = new System.Drawing.Point(211, 444);
            this.bn_Start.Name = "bn_Start";
            this.bn_Start.Size = new System.Drawing.Size(110, 22);
            this.bn_Start.TabIndex = 42;
            this.bn_Start.Text = "Start";
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
            this.pb_original.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Configuration_forn_MouseClick);
            // 
            // FrameTimer
            // 
            this.FrameTimer.Tick += new System.EventHandler(this.FrameTimer_Tick);
            // 
            // cb_BySkin
            // 
            this.cb_BySkin.AutoSize = true;
            this.cb_BySkin.Location = new System.Drawing.Point(159, 123);
            this.cb_BySkin.Name = "cb_BySkin";
            this.cb_BySkin.Size = new System.Drawing.Size(60, 17);
            this.cb_BySkin.TabIndex = 36;
            this.cb_BySkin.Text = "By skin";
            this.cb_BySkin.UseVisualStyleBackColor = true;
            this.cb_BySkin.CheckedChanged += new System.EventHandler(this.cb_BySkin_CheckedChanged);
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.MaximumSize = new System.Drawing.Size(650, 550);
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_RadiusSearchArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ColorPossibleDelta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_trashLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value_high)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Satuation_high)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hue_high)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Hue_low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Value_low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Satuation_low)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gesture_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_original)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown num_RadiusSearchArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown num_ColorPossibleDelta;
        private System.Windows.Forms.Button bn_SearchColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.NumericUpDown num_Max;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_trashLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_invertImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_trash;
        private System.Windows.Forms.NumericUpDown num_Value_high;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown num_Satuation_high;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_Hue_high;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_Hue_low;
        private System.Windows.Forms.NumericUpDown num_Value_low;
        private System.Windows.Forms.NumericUpDown num_Satuation_low;
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
    }
}