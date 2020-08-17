using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagneqApp
{
    public partial class guestshow1 : Form
    {
        public guestshow1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            viewcourses vc = new viewcourses();
            //this.Close();
            vc.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            viewcourses vc = new viewcourses();
            vc.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            placedinfo pi = new placedinfo();
            pi.Show();
        }
    }
}
