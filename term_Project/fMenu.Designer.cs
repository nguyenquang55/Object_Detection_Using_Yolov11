namespace term_Project
{
    partial class fMenu
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
            ImageBtn = new Button();
            videoBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ImageBtn
            // 
            ImageBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImageBtn.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ImageBtn.ForeColor = Color.RoyalBlue;
            ImageBtn.Location = new Point(171, 238);
            ImageBtn.Name = "ImageBtn";
            ImageBtn.Size = new Size(121, 50);
            ImageBtn.TabIndex = 0;
            ImageBtn.Text = "Image Detection";
            ImageBtn.UseCompatibleTextRendering = true;
            ImageBtn.UseVisualStyleBackColor = true;
            ImageBtn.Click += ImageBtn_Click;
            // 
            // videoBtn
            // 
            videoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            videoBtn.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            videoBtn.ForeColor = Color.RoyalBlue;
            videoBtn.Location = new Point(494, 238);
            videoBtn.Name = "videoBtn";
            videoBtn.Size = new Size(121, 50);
            videoBtn.TabIndex = 1;
            videoBtn.Text = "Video Detection";
            videoBtn.UseVisualStyleBackColor = true;
            videoBtn.Click += videoBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(260, 88);
            label1.Name = "label1";
            label1.Size = new Size(270, 33);
            label1.TabIndex = 2;
            label1.Text = "Object Detection ";
            // 
            // fMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(videoBtn);
            Controls.Add(ImageBtn);
            MaximizeBox = false;
            Name = "fMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ImageBtn;
        private Button videoBtn;
        private Label label1;
    }
}