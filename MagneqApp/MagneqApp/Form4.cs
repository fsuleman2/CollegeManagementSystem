using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MagneqApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //in srno we have passed a roll no. of the student from studentlogin page;
        public static double srno = studentlogin.rno;
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(srno);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from students where rno=" + srno,cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read().Equals(true))
                {
                    tpassword.Text = dr["password"].ToString();
                    tstudent.Text = dr["sname"].ToString();
                    tcourse.Text = dr["course"].ToString();
                    maskedTextBox1.Text = dr["mobileno"].ToString();
                    temail.Text = dr["email"].ToString();
                    tcity.Text = dr["city"].ToString();
                }
                
            }
            catch(SqlException ex) { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }
    }
}
