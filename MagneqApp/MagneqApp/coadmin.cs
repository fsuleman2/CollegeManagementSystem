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
    public partial class coadmin : Form
    {
        public coadmin()
        {
            InitializeComponent();
        }
        
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
    

       

        private void coadmin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            this.Hide();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill All the Details");
                }
                else
                {
                    cn.Open();

                    //MessageBox.Show("Connected");
                    string query = "insert into users values(@tusername,@tpassword)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@tusername", textBox1.Text);
                    cmd.Parameters.AddWithValue("@tpassword", textBox2.Text);
                    if (textBox2.Text.Equals(textBox3.Text))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sign up Success!! please go back to login form");
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct password");
                    }
                }
                

            }


            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }
    }
}
