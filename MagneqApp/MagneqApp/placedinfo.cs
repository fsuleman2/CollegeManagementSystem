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
    public partial class placedinfo : Form
    {
        public placedinfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Form3 f3 = new Form3(); ;
            this.Close();
            //f3.Show();
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "select * from placementinfo";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "placementinfo");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void placedinfo_Load(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "select * from placementinfo";
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataSet ds = new DataSet();
                da.Fill(ds, "placementinfo");
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
            finally { cn.Close(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
