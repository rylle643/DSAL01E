using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


using System;
using System.Drawing;
using System.Windows.Forms;
using ACOTIN_POS_APPLICATION.Properties;

namespace ACOTIN_POS_APPLICATION
{
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;

        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void POS_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide(); picpathTxtbox4.Hide(); picpathTxtbox5.Hide();
                picpathTxtbox6.Hide(); picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide(); picpathTxtbox10.Hide();
                picpathTxtbox11.Hide(); picpathTxtbox12.Hide(); picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
                picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide(); picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void cleartextboxes()
        {
            try
            {
                pic = Resources.no_image_available_icon_vector;
                picpathTxtbox1.Clear(); picpathTxtbox2.Clear(); picpathTxtbox3.Clear(); picpathTxtbox4.Clear(); picpathTxtbox5.Clear();
                picpathTxtbox6.Clear(); picpathTxtbox7.Clear(); picpathTxtbox8.Clear(); picpathTxtbox9.Clear(); picpathTxtbox10.Clear();
                picpathTxtbox11.Clear(); picpathTxtbox12.Clear(); picpathTxtbox13.Clear(); picpathTxtbox14.Clear(); picpathTxtbox15.Clear();
                picpathTxtbox16.Clear(); picpathTxtbox17.Clear(); picpathTxtbox18.Clear(); picpathTxtbox19.Clear(); picpathTxtbox20.Clear();
                pictureBox1.Image = pic; pictureBox2.Image = pic; pictureBox3.Image = pic; pictureBox4.Image = pic; pictureBox5.Image = pic;
                pictureBox6.Image = pic; pictureBox7.Image = pic; pictureBox8.Image = pic; pictureBox9.Image = pic; pictureBox10.Image = pic;
                pictureBox11.Image = pic; pictureBox12.Image = pic; pictureBox13.Image = pic; pictureBox14.Image = pic; pictureBox15.Image = pic;
                pictureBox16.Image = pic; pictureBox17.Image = pic; pictureBox18.Image = pic; pictureBox19.Image = pic; pictureBox20.Image = pic;
                priceTxtbox1.Clear(); priceTxtbox2.Clear(); priceTxtbox3.Clear(); priceTxtbox4.Clear(); priceTxtbox5.Clear();
                priceTxtbox6.Clear(); priceTxtbox7.Clear(); priceTxtbox8.Clear(); priceTxtbox9.Clear(); priceTxtbox10.Clear();
                priceTxtbox11.Clear(); priceTxtbox12.Clear(); priceTxtbox13.Clear(); priceTxtbox14.Clear(); priceTxtbox15.Clear();
                priceTxtbox16.Clear(); priceTxtbox17.Clear(); priceTxtbox18.Clear(); priceTxtbox19.Clear(); priceTxtbox20.Clear();
                nameTxtbox1.Clear(); nameTxtbox2.Clear(); nameTxtbox3.Clear(); nameTxtbox4.Clear(); nameTxtbox5.Clear();
                nameTxtbox6.Clear(); nameTxtbox7.Clear(); nameTxtbox8.Clear(); nameTxtbox9.Clear(); nameTxtbox10.Clear();
                nameTxtbox11.Clear(); nameTxtbox12.Clear(); nameTxtbox13.Clear(); nameTxtbox14.Clear(); nameTxtbox15.Clear();
                nameTxtbox16.Clear(); nameTxtbox17.Clear(); nameTxtbox18.Clear(); nameTxtbox19.Clear(); nameTxtbox20.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void open_file_image()
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.bmp";
            OpenFileDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }
    }
}
