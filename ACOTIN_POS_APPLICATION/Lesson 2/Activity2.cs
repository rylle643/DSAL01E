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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(1.3f, 1.25f));
            };
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
            discounttxtbox.Enabled = false;
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
            try
            {
                /// declare variable
                int qty;
                double discount_amt, discounted_amt, cash_rendered, change;
                qty = Convert.ToInt32(quantitytextbox.Text);

                /// Parse numbers that might have commas
                discount_amt = double.Parse(discounttxtbox.Text.Replace(",", ""));
                discounted_amt = double.Parse(discountedtxtbox.Text.Replace(",", ""));
                cash_rendered = Convert.ToDouble(cashre_renderedtxtbox.Text);

                /// check if cash rendered is enough
                if (cash_rendered < discounted_amt)
                {
                    MessageBox.Show("Not enough cash rendered.", "Error");
                    cashre_renderedtxtbox.Clear();
                    cashre_renderedtxtbox.Focus();
                    return;
                }

                /// code to accumulate the value
                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;
                /// convert numeric to string
                qty_totaltxtbox.Text = qty_total.ToString("n");
                discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cashre_renderedtxtbox.Text = cash_rendered.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check your entries.", "Error");
            }
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
            
            quantitytextbox.Text = "0";
            pricetextbox.Text = "0";
            discounttxtbox.Text = "0";
            discountedtxtbox.Text = "0";
            cashre_renderedtxtbox.Text = "0";

            /// uncheck
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

            /// clear
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            discounttxtbox.Clear();
            quantitytextbox.Clear();
            cashre_renderedtxtbox.Clear();
            discountedtxtbox.Clear();
            changetxtbox.Clear();

            /// enable radio button
            radioButton1.Enabled = true;
            regularRbtn.Enabled = true;
            EmployeeRdbtn.Enabled = true;
            noTaxRdbtn.Enabled = true;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return; // Exit if unchecking

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!regularRbtn.Checked) return; // Exit if unchecking

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!EmployeeRdbtn.Checked) return; // Exit if unchecking

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!noTaxRdbtn.Checked) return; // Exit if unchecking

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                radioButton1.Checked = false;
                regularRbtn.Checked = false;
                EmployeeRdbtn.Checked = false;
                noTaxRdbtn.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}