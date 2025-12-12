using ACOTIN_POS_APPLICATION.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACOTIN_POS_APPLICATION
{
    public partial class Activity3 : Form
    {
        public Activity3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(1.5f, 1.5f));
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = Resources.Untitleddesign1;

            A_ChickenMcDoBox.Checked = true;
            A_BFFFriesBox.Checked = true;
            A_DrinksBox.Checked = true;
            A_RiceBox.Checked = true;

            B_ApplePieBox.Checked = false;
            B_BFFFriesBox.Checked = false;
            B_BurgerMcDoBox.Checked = false;
            B_ChickenSandwichBox.Checked = false;
            B_QuarterPounderBox.Checked = false;

            priceTxtBox.Text = "₱720.00";
            discountTxtBox.Text = "(20% of the Price) ₱144.00";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
            foodARdbtn.Checked = false;
            DisplayPictureBox.Image = Resources.Untitleddesign2;

            A_ChickenMcDoBox.Checked = false;
            A_BFFFriesBox.Checked = false;
            A_DrinksBox.Checked = false;
            A_RiceBox.Checked = false;

            B_ApplePieBox.Checked = true;
            B_BFFFriesBox.Checked = true;
            B_BurgerMcDoBox.Checked = true;
            B_ChickenSandwichBox.Checked = true;
            B_QuarterPounderBox.Checked = true;

            priceTxtBox.Text = "₱450.00";
            discountTxtBox.Text = "(15% of the Price) ₱40.50";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile ("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\no-image-available-icon-vector.jpg");

            A_ChickenMcDoBox.Checked = false;
            A_BFFFriesBox.Checked = false;
            A_DrinksBox.Checked = false;
            A_RiceBox.Checked = false;

            B_ApplePieBox.Checked = false;
            B_BFFFriesBox.Checked = false;
            B_BurgerMcDoBox.Checked = false;
            B_ChickenSandwichBox.Checked = false;
            B_QuarterPounderBox.Checked = false;

            priceTxtBox.Clear();
            discountTxtBox.Clear();
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
