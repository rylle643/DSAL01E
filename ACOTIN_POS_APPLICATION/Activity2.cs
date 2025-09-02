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
    public partial class Activity2 : Form
    {
        private double qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;
        public Activity2()
        {
            InitializeComponent();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "McCafé Iced Americano";
            pricetextbox.Text = "140.00";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Hotcakes";
            pricetextbox.Text = "73.00";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Hot Caramel Sundae";
            pricetextbox.Text = "55.00";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken McNuggets with Fries";
            pricetextbox.Text = "150.00";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "McChicken Sandwich";
            pricetextbox.Text = "50.00";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Big Mac";
            pricetextbox.Text = "167.00";
        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            itemnametxtbox.Enabled = false;
            pricetextbox.Enabled = false;
            discountedtxtbox.Enabled = false;
            qty_totaltxtbox.Enabled = false;
            discount_totaltxtbox.Enabled = false;
            discounted_totaltxtbox.Enabled = false;
            changetxtbox.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Quarter Pounder";
            pricetextbox.Text = "255.00";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Burger McDo";
            pricetextbox.Text = "47.00";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken McDo with McSpaghetti";
            pricetextbox.Text = "251.00";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Chicken McDo with Rice";
            pricetextbox.Text = "150.00";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Crispy Chicken Fillet with Rice";
            pricetextbox.Text = "134.00";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Coke McFloat";
            pricetextbox.Text = "59.00";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "McFlurry with Oreo Cookies";
            pricetextbox.Text = "69.00";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Hot Fudge Sundae";
            pricetextbox.Text = "55.00";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "McCafé Americano";
            pricetextbox.Text = "79.00";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "McCafé Premium Hot Chocolate";
            pricetextbox.Text = "130.00";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "McCafé Iced Mocha";
            pricetextbox.Text = "140.00";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Cheesy Eggdesal";
            pricetextbox.Text = "42.00";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Sausage McMuffin with Egg";
            pricetextbox.Text = "82.00";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = "Egg McMuffin";
            pricetextbox.Text = "73.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            discounttxtbox.Clear();
            quantitytextbox.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /// declare variable
            int qty;
            double price, discount_amt, discounted_amt;
            /// string to numeric
            qty = Convert.ToInt32(quantitytextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            /// formula for computation
            discount_amt = (qty * price) * 0.30;
            discounted_amt = (qty * price) - discount_amt;
            /// convert numeric to string
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            /// uncheck other
            regularRbtn.Enabled = false;
            EmployeeRdbtn.Enabled = false;
            noTaxRdbtn.Enabled = false;
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            /// declare variable
            int qty;
            double price, discount_amt, discounted_amt;
            /// string to numeric
            qty = Convert.ToInt32(quantitytextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            /// formula for computation
            discount_amt = (qty * price) * 0.10;
            discounted_amt = (qty * price) - discount_amt;
            /// convert numeric to string
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            /// uncheck other
            radioButton1.Enabled = false;
            EmployeeRdbtn.Enabled = false;
            noTaxRdbtn.Enabled = false;
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            /// declare variable
            int qty;
            double price, discount_amt, discounted_amt;
            /// string to numeric
            qty = Convert.ToInt32(quantitytextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            /// formula for computation
            discount_amt = (qty * price) * 0.15;
            discounted_amt = (qty * price) - discount_amt;
            /// convert numeric to string
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            /// uncheck other
            radioButton1.Enabled = false;
            regularRbtn.Enabled = false;
            noTaxRdbtn.Enabled = false;
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            /// declare variable
            int qty;
            double price, discount_amt, discounted_amt;
            /// string to numeric
            qty = Convert.ToInt32(quantitytextbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
            /// formula for computation
            discount_amt = (qty * price) * 0;
            discounted_amt = (qty * price) - discount_amt;
            /// convert numeric to string
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
            /// uncheck other
            radioButton1.Enabled = false;
            regularRbtn.Enabled = false;
            EmployeeRdbtn.Enabled = false;
        }
    }
}
