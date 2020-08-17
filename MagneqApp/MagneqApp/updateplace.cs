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
    public partial class updateplace : Form
    {
        public updateplace()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void label2_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            this.Hide();
            ad.Show();
        }

        private void updateplace_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Add Button
                cn.Open();
                //MessageBox.Show("Connected");
                if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals("") || textBox6.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill All the Details");
                }
                else
                {
                    string query = "insert into placementinfo values(@trno,@tsname,@tcompany,@tlocation,@tpackage,@tplacementstatus)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    //cmd.Parameters.AddWithValue("@trno", textBox1.Text);
                    cmd.Parameters.AddWithValue("@trno", textBox1.Text);
                    cmd.Parameters.AddWithValue("@tsname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@tplacementstatus", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tcompany", textBox4.Text);
                    cmd.Parameters.AddWithValue("@tlocation", textBox5.Text);
                    cmd.Parameters.AddWithValue("@tpackage", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Inserted Successfully");
                }
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally { cn.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            placedinfo pi = new placedinfo();
            //this.Close();
            pi.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
