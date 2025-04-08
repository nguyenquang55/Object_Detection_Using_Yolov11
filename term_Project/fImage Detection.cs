using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace term_Project
{
    public partial class fImage_Detection : Form
    {
        public fImage_Detection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string filePath;
        List<Image> images=detectImage.getListImage();
        List<string> objectName = detectImage.getObjectImage();
        List<string> objectConf = detectImage.getObjectConf();
        private void BtnUpLoad_Click(object sender, EventArgs e)
        {
            images.Clear();
            objectName.Clear();
            objectConf.Clear();
            filePath = fileWorking.openImageFile();
            if (filePath == null) MessageBox.Show("Error loading image");
            else PbOriginalImages.Image = new Bitmap(filePath);
        }

        private void BtnDetect_Click(object sender, EventArgs e)
        {
            images.Clear();
            objectName.Clear();
            objectConf.Clear();
            if (!string.IsNullOrEmpty(filePath)) detectImage.detecting(filePath, PbDetectedImages);
            else MessageBox.Show("No image loaded to detect.");

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (PbDetectedImages != null) fileWorking.saveImages(images);
            else MessageBox.Show("No image to save");
        }
    }
}
