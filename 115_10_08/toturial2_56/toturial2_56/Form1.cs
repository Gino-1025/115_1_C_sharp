using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toturial2_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            BackpictureBox.Visible= true;
            FacepictureBox.Visible = false;

        }

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            BackpictureBox.Visible = false;
            FacepictureBox.Visible = true;
        }
    }
}
