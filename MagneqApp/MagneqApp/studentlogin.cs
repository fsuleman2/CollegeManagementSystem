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
    public partial class studentlogin : Form
    {
        public studentlogin()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        public static string display2 = "";
        public static double rno;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
                {
                    MessageBox.Show("Fields can't be Kept Empty");
                }
                else
                {
                    cn.Open();

                    string query = "select sname from students where rno='" + Convert.ToDouble(textBox1.Text) + "' and password='" + textBox2.Text.Trim(' ') + "'";
                    //string query = "select * from students where sname='" + textBox1.Text + "' and password='" + textBox2.Text+ "'";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    //SqlCommand cmd1 = new SqlCommand(q1, cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        studentpage sp = new studentpage();
                        display2 = dr["sname"].ToString();
                        rno = Convert.ToDouble(textBox1.Text);
                        this.Hide();
                        sp.Show();
                    }
                    else
                    {
                        MessageBox.Show("invalid user id pawd");
                    }
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void studentlogin_Load(object sender, EventArgs e)
        {
           // textBox1.Focus();
        }
    }
}
