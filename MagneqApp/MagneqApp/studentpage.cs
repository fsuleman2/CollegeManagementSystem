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
    public partial class studentpage : Form
    {
        public studentpage()
        {
            InitializeComponent();
        }
        
        private void studentpage_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to Student Panel" + " " +studentlogin.display2;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            studentlogin sl = new studentlogin();
            this.Close();
            sl.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            placedinfo pi = new placedinfo();
            //this.Close();
            pi.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            viewcourses vc = new viewcourses();
            //this.Close();
            vc.Show();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
