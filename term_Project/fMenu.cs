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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImageBtn_Click(object sender, EventArgs e)
        {
            openForm(new fImage_Detection());
        }
        private void openForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void videoBtn_Click(object sender, EventArgs e)
        {
            openForm(new fVideo_Detection());
        }
    }
}
