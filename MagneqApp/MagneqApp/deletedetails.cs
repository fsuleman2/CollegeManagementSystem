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
    public partial class deletedetails : Form
    {
        public deletedetails()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "delete from students where rno=@trno";
                //string query1 = "delete students,placementinfo from students inner join placementinfo on placementinfo.ref=students.id where students.id=@trno";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@trno", Convert.ToDouble(comboBox2.Text));
                //cmd.Parameters.AddWithValue("@tsname", comboBox2.Text);

                cmd.ExecuteNonQuery();
                if (MessageBox.Show("Are you sure delete? ", "EXIT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Deleted successfully");
                    cn.Close();
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }

        private void deletedetails_Load(object sender, EventArgs e)
        {
            cn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from students", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
               comboBox2.Items.Add(ds.Tables[0].Rows[i][0]);
                //comboBox2.Items.Add(ds.Tables[0].Rows[i][0] + " " + ds.Tables[0].Rows[i][1] + " " + ds.Tables[0].Rows[i][2]);

            }
            cn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            adminpage ad = new adminpage();
            this.Hide();
            ad.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select rno,sname,email from students where rno =" + Convert.ToDouble(comboBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "students");
            dataGridView1.DataSource = ds.Tables[0];
            ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
