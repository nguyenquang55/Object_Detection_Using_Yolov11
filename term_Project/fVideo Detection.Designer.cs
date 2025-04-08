namespace term_Project
{
    partial class fVideo_Detection
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
            label1 = new Label();
            pbVideo = new PictureBox();
            BtnUpLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)pbVideo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(475, 43);
            label1.Name = "label1";
            label1.Size = new Size(350, 47);
            label1.TabIndex = 3;
            label1.Text = "Video Detection";
            label1.Click += label1_Click;
            // 
            // pbVideo
            // 
            pbVideo.BackColor = SystemColors.ActiveBorder;
            pbVideo.Location = new Point(12, 142);
            pbVideo.Name = "pbVideo";
            pbVideo.Size = new Size(947, 550);
            pbVideo.SizeMode = PictureBoxSizeMode.Zoom;
            pbVideo.TabIndex = 5;
            pbVideo.TabStop = false;
            // 
            // BtnUpLoad
            // 
            BtnUpLoad.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUpLoad.ForeColor = Color.RoyalBlue;
            BtnUpLoad.Location = new Point(12, 71);
            BtnUpLoad.Name = "BtnUpLoad";
            BtnUpLoad.Size = new Size(124, 54);
            BtnUpLoad.TabIndex = 6;
            BtnUpLoad.Text = "Up Load";
            BtnUpLoad.UseVisualStyleBackColor = true;
            BtnUpLoad.Click += BtnUpLoad_Click;
            // 
            // fVideo_Detection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 716);
            Controls.Add(BtnUpLoad);
            Controls.Add(pbVideo);
            Controls.Add(label1);
            Name = "fVideo_Detection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video_Detection";
            ((System.ComponentModel.ISupportInitialize)pbVideo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbVideo;
        private Button BtnUpLoad;
    }
}