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
    public partial class addcourses : Form
    {
        public addcourses()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");

        private void addcourses_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox4.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill All the Details");
                }
                else
                {
                    cn.Open();
                    string query = "insert into course values(@tcid,@tcname,@tduration,@tfee)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("tcid", textBox1.Text);
                    cmd.Parameters.AddWithValue("tcname", textBox2.Text);
                    cmd.Parameters.AddWithValue("tduration", textBox3.Text);
                    cmd.Parameters.AddWithValue("tfee", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successfully Updated");
                }


            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally { cn.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            this.Close();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewcourses vc = new viewcourses();
            //this.Close();
            vc.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
