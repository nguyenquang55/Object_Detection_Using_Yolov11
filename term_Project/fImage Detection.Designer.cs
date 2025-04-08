namespace term_Project
{
    partial class fImage_Detection
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
            PbOriginalImages = new PictureBox();
            BtnUpLoad = new Button();
            label1 = new Label();
            BtnDetect = new Button();
            BtnSave = new Button();
            PbDetectedImages = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PbOriginalImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbDetectedImages).BeginInit();
            SuspendLayout();
            // 
            // PbOriginalImages
            // 
            PbOriginalImages.BackColor = SystemColors.ActiveBorder;
            PbOriginalImages.Location = new Point(45, 130);
            PbOriginalImages.Name = "PbOriginalImages";
            PbOriginalImages.Size = new Size(444, 373);
            PbOriginalImages.SizeMode = PictureBoxSizeMode.Zoom;
            PbOriginalImages.TabIndex = 0;
            PbOriginalImages.TabStop = false;
            // 
            // BtnUpLoad
            // 
            BtnUpLoad.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpLoad.ForeColor = Color.RoyalBlue;
            BtnUpLoad.Location = new Point(209, 535);
            BtnUpLoad.Name = "BtnUpLoad";
            BtnUpLoad.Size = new Size(102, 54);
            BtnUpLoad.TabIndex = 1;
            BtnUpLoad.Text = "Up Load";
            BtnUpLoad.UseVisualStyleBackColor = true;
            BtnUpLoad.Click += BtnUpLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(431, 39);
            label1.Name = "label1";
            label1.Size = new Size(350, 47);
            label1.TabIndex = 2;
            label1.Text = "Image Detection";
            label1.Click += label1_Click;
            // 
            // BtnDetect
            // 
            BtnDetect.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDetect.ForeColor = Color.RoyalBlue;
            BtnDetect.Location = new Point(546, 280);
            BtnDetect.Name = "BtnDetect";
            BtnDetect.Size = new Size(102, 54);
            BtnDetect.TabIndex = 3;
            BtnDetect.Text = "Detect";
            BtnDetect.UseVisualStyleBackColor = true;
            BtnDetect.Click += BtnDetect_Click;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.ForeColor = Color.RoyalBlue;
            BtnSave.Location = new Point(884, 535);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(102, 54);
            BtnSave.TabIndex = 4;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // PbDetectedImages
            // 
            PbDetectedImages.BackColor = SystemColors.ActiveBorder;
            PbDetectedImages.Location = new Point(706, 130);
            PbDetectedImages.Name = "PbDetectedImages";
            PbDetectedImages.Size = new Size(444, 373);
            PbDetectedImages.SizeMode = PictureBoxSizeMode.Zoom;
            PbDetectedImages.TabIndex = 5;
            PbDetectedImages.TabStop = false;
            // 
            // fImage_Detection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 614);
            Controls.Add(PbDetectedImages);
            Controls.Add(BtnSave);
            Controls.Add(BtnDetect);
            Controls.Add(label1);
            Controls.Add(BtnUpLoad);
            Controls.Add(PbOriginalImages);
            MaximizeBox = false;
            Name = "fImage_Detection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image_Detection";
            ((System.ComponentModel.ISupportInitialize)PbOriginalImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbDetectedImages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbOriginalImages;
        private Button BtnUpLoad;
        private Label label1;
        private Button BtnDetect;
        private Button BtnSave;
        private PictureBox PbDetectedImages;
    }
}