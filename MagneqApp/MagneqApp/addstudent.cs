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
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void addstudent_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            try
            {
                cn.Open();
                string q = "select cname from course";
                SqlCommand cmd = new SqlCommand(q, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    comboBox1.Items.Add(dr["cname"].ToString());
                }
                cn.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); };
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void label2_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            this.Hide();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Add Button
                cn.Open();
                //MessageBox.Show("Connected");
                if (textBox3.Text.Equals("") || comboBox1.Text.Equals("") || textBox5.Text.Equals("") || maskedTextBox1.Text.Equals("") || textBox7.Text.Equals("") || textBox8.Text.Equals(""))
                {
                    MessageBox.Show("Please Fill All the Details");
                }
                else
                {
                    string query = "insert into students(sname,course,collegename,mobileno,email,city) values (@tsname,@tcourse,@tcollegename,@tmobileno,@temail,@tcity)";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    //cmd.Parameters.AddWithValue("@trno", textBox1.Text);
                    // cmd.Parameters.AddWithValue("@tpassword", textBox2.Text);
                    cmd.Parameters.AddWithValue("@tsname", textBox3.Text);
                    cmd.Parameters.AddWithValue("@tcourse", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@tcollegename", textBox5.Text);
                    cmd.Parameters.AddWithValue("@tmobileno", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@temail", textBox7.Text);
                    cmd.Parameters.AddWithValue("@tcity", textBox8.Text);
                    //cmd.Parameters.AddWithValue("@tplacementstatus", textBox9.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Inserted Successfully");
                    string q2 = "select max(rno) from students";
                    SqlCommand cmd2 = new SqlCommand(q2, cn);
                    //cmd.ExecuteScalar();
                    int trno = Convert.ToInt32(cmd2.ExecuteScalar());
                    label5.Text = "Roll is: " + trno.ToString() + " " + " and " + "Default Password is: " + "12345";

                }
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
            finally { cn.Close(); }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            comboBox1.Text="";
            textBox5.Clear();
            maskedTextBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();
            label5.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
