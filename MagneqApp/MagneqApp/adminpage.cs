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
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            viewstudent vs = new viewstudent();
            this.Hide();
            vs.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            updatestudent us = new updatestudent();
            us.Close();
            this.Close();
            f3.Show();
           
        }
      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            addstudent af = new addstudent();
            this.Hide();
            af.Show();
        }

        private void adminpage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            deletedetails ds = new deletedetails();
            this.Hide();
            ds.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           coadmin ca = new coadmin();
            this.Hide();
            ca.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            updatestudent us = new updatestudent();
           // this.Close();
            us.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            updateplace up = new updateplace();
            this.Close();
            up.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            addcourses ac = new addcourses();
            this.Close();
            ac.Show();

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
