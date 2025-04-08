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
    public partial class fVideo_Detection : Form
    {
        public fVideo_Detection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string Path;
        private void BtnUpLoad_Click(object sender, EventArgs e)
        {
            Path = fileWorking.openVideoFile();
            detectVideo.VideoDetecting(Path, pbVideo);
        }
    }
}
