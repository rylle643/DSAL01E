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


namespace ACOTIN_POS_APPLICATION
{
    public partial class SampleDatabaseDb : Form
    {

        public SampleDatabaseDb()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }


        private void SampleDatabaseDb_Load(object sender, EventArgs e)
        {
            string picpath;
            string connectionString = null;
            SqlConnection connection;
            SqlCommand command;
            DataSet dset;
            SqlDataAdapter adaptersql;
            string sql = null;

            connectionString = "Data Source=localhost;Initial Catalog=SampleDatabase;userid";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
