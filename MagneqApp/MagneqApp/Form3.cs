using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagneqApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        public static string display1 = "";
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        //Form3 f3 = new Form3();
        studentlogin sl = new studentlogin();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)//guest
        {
            guestshow1 gs = new guestshow1();
            this.Hide();
            gs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                // MessageBox.Show("Connected");
                // string query = "select * from users where username=@tusername and password=@tpassword";
                string query = "select * from users where username='" + textBox1.Text + "' and password='" + textBox2.Text.Trim(' ') + "'";
                SqlCommand cmd = new SqlCommand(query, cn);
                //cmd.Parameters.AddWithValue("@tusername", textBox1.Text);
                //cmd.Parameters.AddWithValue("@tpassword", textBox2.Text);
                //cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                //MessageBox.Show("successfully");
                if (dr.Read() == true)
                {
                    adminpage ad = new adminpage();
                    //display1 = textBox1.Text;
                    this.Hide();
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("invalid user id pawd");
                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentlogin sl = new studentlogin();
            this.Hide();
            sl.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
