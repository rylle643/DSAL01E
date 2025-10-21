using ACOTIN_POS_APPLICATION.Properties;
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

namespace ACOTIN_POS_APPLICATION
{
    public partial class SampleDatabaseDb : Form
    {
        string picpath;
        string connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
        

        public SampleDatabaseDb()
        {
            connectionString = "Data Source=C203-34;Initial Catalog=SampleDatabaseDb; user id=  SA; password=B1Admin123@";
            connection = new SqlConnection(connectionString);
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SampleDatabaseDb_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES ('"
      + student_idtextBox.Text + "', '"
      + Student_nametextBox.Text + "', '"
      + DepartmenttextBox.Text + "', '"
      + picpathtextBox.Text + "')";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];

            pictureBox1.Image = Resources.Saved;
            student_idtextBox.Clear();
            Student_nametextBox.Clear();
            DepartmenttextBox.Clear();
            picpathtextBox.Clear();

            connection.Close();

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "SELECT * FROM studentTbl WHERE student_id = '" +
                student_idtextBox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];

            Student_nametextBox.Text = dset.Tables[0].Rows[0][1].ToString();
            DepartmenttextBox.Text = dset.Tables[0].Rows[0][2].ToString();
            picpathtextBox.Text = dset.Tables[0].Rows[0][3].ToString();
            picpath = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(picpath);

            connection.Close();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "DELETE FROM studentTbl WHERE student_id = '" + student_idtextBox.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];
            pictureBox1.Image = Resources.no_image_available_icon_vector;

            connection.Close();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            connection.Open();

            sql = "UPDATE studentTbl SET student_name = '" + Student_nametextBox.Text +
                  "', department = '" + DepartmenttextBox.Text +
                  "', picpath = '" + picpathtextBox.Text +
                  "' WHERE student_id = '" + student_idtextBox.Text + "'";

            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl";
            command = new SqlCommand(sql, connection);
            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];

            connection.Close();
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.no_image_available_icon_vector;
            student_idtextBox.Clear();
            Student_nametextBox.Clear();
            DepartmenttextBox.Clear();
            picpathtextBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Image File | *.gif; *.jif; *.png; *.bmp;";

            OpenFileDialog.ShowDialog();

            picpath = OpenFileDialog.FileName;
            picpathtextBox.Text = picpath;
            pictureBox1.Image = Image.FromFile(picpath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "Image File | *.gif; *.jif; *.png; *.bmp;";
            OpenFileDialog.ShowDialog();
            picpath = OpenFileDialog.FileName;
            picpathtextBox.Text = picpath;
            pictureBox1.Image = Image.FromFile(picpath);
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.no_image_available_icon_vector;
            student_idtextBox.Clear();
            Student_nametextBox.Clear();
            DepartmenttextBox.Clear();
            picpathtextBox.Clear();
        }
    }
}