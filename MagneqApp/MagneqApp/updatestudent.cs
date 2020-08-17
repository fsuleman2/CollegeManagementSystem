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
    public partial class updatestudent : Form
    {
        public updatestudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //adminpage ad = new adminpage();
            this.Close();
            //ad.Show();

        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                
                    cn.Open();
                    string query = "update students set password=@tpassword,sname=@tsname,course=@tcourse,collegename=@tcollegename,mobileno=@tmobileno,email=@temail,city=@tcity,placementstatus=@tplacementstatus where rno=@trno";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@trno", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@tpassword", textBox11.Text);
                    cmd.Parameters.AddWithValue("@tsname", textBox12.Text);
                    cmd.Parameters.AddWithValue("@tcourse", textBox13.Text);
                    cmd.Parameters.AddWithValue("@tcollegename", textBox14.Text);
                    cmd.Parameters.AddWithValue("@tmobileno", maskedTextBox1.Text);
                    cmd.Parameters.AddWithValue("@temail", textBox16.Text);
                    cmd.Parameters.AddWithValue("@tcity", textBox17.Text);
                    cmd.Parameters.AddWithValue("@tplacementstatus", textBox18.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated SuccessFully");
                
              

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            maskedTextBox1.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
        }

        private void updatestudent_Load(object sender, EventArgs e)
        {   //comoboc roll no. show
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select *from students",cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read() == true)
                {
                    comboBox1.Items.Add(dr["rno"].ToString());
                }
                //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
                // private System.Windows.Forms.Label label2;

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            //textBox10.Clear();
        }

        private void textBox10_TabIndexChanged(object sender, EventArgs e)
        {
            //cn.Open();
           // string q = "select * from students where rno=@trno";
           // SqlDataReader dr = new SqlDataReader();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from students where rno="+comboBox1.Text,cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read()==true)
                {
                    textBox11.Text = dr["password"].ToString();
                    textBox12.Text = dr["sname"].ToString();
                    textBox13.Text = dr["course"].ToString();
                    textBox14.Text = dr["collegename"].ToString();
                    maskedTextBox1.Text = dr["mobileno"].ToString();
                    textBox16.Text = dr["email"].ToString();
                    textBox17.Text = dr["city"].ToString();
                    textBox18.Text = dr["placementstatus"].ToString();
                }    

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
