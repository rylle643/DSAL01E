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
    public partial class Activity4 : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;
        public Activity4()
        {
            InitializeComponent();
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
            this.BackColor = Color.LightGoldenrodYellow;

            double price;


            foodBRdbtn.Checked = false;
            DisplayPictureBox.Image = Image.FromFile ("C:\\Users\\Rylle\\Downloads\\ACOTIN-DSAL\\Untitled design (1).png");

            A_ChickenMcDoBox.Checked = true;
            A_BFFFriesBox.Checked = true;
            A_DrinksBox.Checked = true;
            A_RiceBox.Checked = true;
            A_Gravy.Checked = true;

            B_ApplePieBox.Checked = false;
            B_BFFFriesBox.Checked = false;
            B_BurgerMcDoBox.Checked = false;
            B_ChickenSandwichBox.Checked = false;
            B_QuarterPounderBox.Checked = false;

            priceTxtBox.Text = "₱720.00";
            discountAmountTxtbox.Text = "₱144.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            //insert data from textbox
            displayListbox.Items.Add(foodBRdbtn.Text + priceTxtBox.Text);
            displayListbox.Items.Add("Discount Amount: " + discountAmountTxtbox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
            foodARdbtn.Checked = false; 
            DisplayPictureBox.Image = Image.FromFile ("C:\\Users\\Rylle\\Downloads\\ACOTIN-DSAL\\Untitled design (2).png");

            A_ChickenMcDoBox.Checked = false;
            A_BFFFriesBox.Checked = false;
            A_DrinksBox.Checked = false;
            A_RiceBox.Checked = false;
            A_Gravy.Checked = false;

            B_ApplePieBox.Checked = true;
            B_BFFFriesBox.Checked = true;
            B_BurgerMcDoBox.Checked = true;
            B_ChickenSandwichBox.Checked = true;
            B_QuarterPounderBox.Checked = true;

            priceTxtBox.Text = "₱450.00";
            qtyTxtbox.Text = "(15% of the Price) ₱40.50";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile ("C:\\Users\\Rylle\\Downloads\\ACOTIN-DSAL\\no-image-available-icon-vector.jpg");

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
            qtyTxtbox.Clear();
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            priceTxtBox.Enabled = false;
            discountedAmountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountAmountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;

            A_BFFFriesBox.Checked = false;
            A_ChickenMcDoBox.Checked = false;
            A_DrinksBox.Checked = false;
            A_RiceBox.Checked = false;
            A_Gravy.Checked = false;

            B_ApplePieBox.Checked = false;
            B_BFFFriesBox.Checked = false;
            B_BurgerMcDoBox.Checked = false;
            B_ChickenSandwichBox.Checked = false;
            B_QuarterPounderBox.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_BurgerMcDoBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
