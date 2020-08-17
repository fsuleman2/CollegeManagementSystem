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
    public partial class viewcourses : Form
    {
        public viewcourses()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"server=SULEMAN; initial catalog=magneqapp;integrated security=true");

        private void label2_Click(object sender, EventArgs e)
        {
           // Form3 f3 = new Form3();
            this.Close();
            //f3.Show();
        }

        private void viewcourses_Load(object sender, EventArgs e)
        {
            cn.Open();
            string query = "SELECT * from course";
            SqlDataAdapter da = new SqlDataAdapter(query, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "course");
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
