namespace StadyNeuronNet
{
    partial class Form1
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
            this.tb_ResultOfNeuroNet = new System.Windows.Forms.TextBox();
            this.bn_LoadImage = new System.Windows.Forms.Button();
            this.pb_ImageForStudy = new System.Windows.Forms.PictureBox();
            this.LB1 = new System.Windows.Forms.Label();
            this.bn_RecognizeImage = new System.Windows.Forms.Button();
            this.bn_Stady = new System.Windows.Forms.Button();
            this.tb_adressForFolder = new System.Windows.Forms.TextBox();
            this.bn_stadyFromFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageForStudy)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ResultOfNeuroNet
            // 
            this.tb_ResultOfNeuroNet.Location = new System.Drawing.Point(328, 148);
            this.tb_ResultOfNeuroNet.Name = "tb_ResultOfNeuroNet";
            this.tb_ResultOfNeuroNet.Size = new System.Drawing.Size(100, 20);
            this.tb_ResultOfNeuroNet.TabIndex = 0;
            // 
            // bn_LoadImage
            // 
            this.bn_LoadImage.Location = new System.Drawing.Point(328, 12);
            this.bn_LoadImage.Name = "bn_LoadImage";
            this.bn_LoadImage.Size = new System.Drawing.Size(210, 29);
            this.bn_LoadImage.TabIndex = 1;
            this.bn_LoadImage.Text = "Load image";
            this.bn_LoadImage.UseVisualStyleBackColor = true;
            this.bn_LoadImage.Click += new System.EventHandler(this.bn_LoadImage_Click);
            // 
            // pb_ImageForStudy
            // 
            this.pb_ImageForStudy.Location = new System.Drawing.Point(12, 12);
            this.pb_ImageForStudy.Name = "pb_ImageForStudy";
            this.pb_ImageForStudy.Size = new System.Drawing.Size(294, 279);
            this.pb_ImageForStudy.TabIndex = 2;
            this.pb_ImageForStudy.TabStop = false;
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(325, 122);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(37, 13);
            this.LB1.TabIndex = 3;
            this.LB1.Text = "Result";
            // 
            // bn_RecognizeImage
            // 
            this.bn_RecognizeImage.Location = new System.Drawing.Point(328, 73);
            this.bn_RecognizeImage.Name = "bn_RecognizeImage";
            this.bn_RecognizeImage.Size = new System.Drawing.Size(210, 29);
            this.bn_RecognizeImage.TabIndex = 4;
            this.bn_RecognizeImage.Text = "Recognize igesture";
            this.bn_RecognizeImage.UseVisualStyleBackColor = true;
            this.bn_RecognizeImage.Click += new System.EventHandler(this.bn_RecognizeImage_Click);
            // 
            // bn_Stady
            // 
            this.bn_Stady.Location = new System.Drawing.Point(328, 186);
            this.bn_Stady.Name = "bn_Stady";
            this.bn_Stady.Size = new System.Drawing.Size(210, 29);
            this.bn_Stady.TabIndex = 5;
            this.bn_Stady.Text = "Stady";
            this.bn_Stady.UseVisualStyleBackColor = true;
            this.bn_Stady.Click += new System.EventHandler(this.bn_Stady_Click);
            // 
            // tb_adressForFolder
            // 
            this.tb_adressForFolder.Location = new System.Drawing.Point(328, 236);
            this.tb_adressForFolder.Name = "tb_adressForFolder";
            this.tb_adressForFolder.Size = new System.Drawing.Size(210, 20);
            this.tb_adressForFolder.TabIndex = 6;
            // 
            // bn_stadyFromFolder
            // 
            this.bn_stadyFromFolder.Location = new System.Drawing.Point(328, 262);
            this.bn_stadyFromFolder.Name = "bn_stadyFromFolder";
            this.bn_stadyFromFolder.Size = new System.Drawing.Size(210, 29);
            this.bn_stadyFromFolder.TabIndex = 7;
            this.bn_stadyFromFolder.Text = "Stady from folder";
            this.bn_stadyFromFolder.UseVisualStyleBackColor = true;
            this.bn_stadyFromFolder.Click += new System.EventHandler(this.bn_stadyFromFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 303);
            this.Controls.Add(this.bn_stadyFromFolder);
            this.Controls.Add(this.tb_adressForFolder);
            this.Controls.Add(this.bn_Stady);
            this.Controls.Add(this.bn_RecognizeImage);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.pb_ImageForStudy);
            this.Controls.Add(this.bn_LoadImage);
            this.Controls.Add(this.tb_ResultOfNeuroNet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImageForStudy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ResultOfNeuroNet;
        private System.Windows.Forms.Button bn_LoadImage;
        private System.Windows.Forms.PictureBox pb_ImageForStudy;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Button bn_RecognizeImage;
        private System.Windows.Forms.Button bn_Stady;
        private System.Windows.Forms.TextBox tb_adressForFolder;
        private System.Windows.Forms.Button bn_stadyFromFolder;
    }
}

