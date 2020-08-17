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
    public partial class viewstudent : Form
    {
        public viewstudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            this.Close();
            ad.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "select* from students where rno =" + Convert.ToDouble(comboBox1.Text);
                //string query = "select * from students";for displaying whole table
                //SqlCommand cmd = new SqlCommand(query, cn);
                //cmd.Parameters.AddWithValue("@trno", Convert.ToDouble(comboBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "students");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void button5_Click(object sender, EventArgs e) //show all button
        {
            try
            {
                cn.Open();
                string query = "select * from students";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "student");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void viewstudent_Load(object sender, EventArgs e)
        {
            cn.Open();
            //label3.Text = Form1.display1;
            //Form1 f3 = new Form3();
            //f3.Hide();
            //cn.Open();
            SqlCommand cmd1 = new SqlCommand("select rno from students", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables[0].Rows[i][0]);
                //comboBox2.Items.Add(ds.Tables[0].Rows[i][0]);
            }
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
