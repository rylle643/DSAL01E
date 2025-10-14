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
    public partial class POS1_Functions : Form
    {
        private double qty_total = 0;
        private double discount_totalgiven = 0;
        private double discounted_total = 0;
        private int qty;
        private double price;
        private double discount_amt;
        private double discounted_amt;
        public POS1_Functions()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(1.3f, 1.25f));
            };
        }
        private void ClearQuantity()

        {
            quantitytextbox.Clear();
            quantitytextbox.Focus();
        }

        private void quantity_price_Convert()
        {
        qty = Convert.ToInt32(quantitytextbox.Text);
        price = Convert.ToDouble(pricetextbox.Text);
        }

        private void computation_formula_and_DisplayData()
        {
            discounted_amt = (qty * price) - discount_amt;
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        private void price_item_TextValue(string itemname, string price)
        {
            itemnametxtbox.Text = itemname;
            pricetextbox.Text = price;
        }

        private void ClearAll()
        {
            // Clear textboxes
            itemnametxtbox.Clear();
            quantitytextbox.Clear();
            pricetextbox.Clear();
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            cashre_renderedtxtbox.Clear();
            changetxtbox.Clear();
            qty_totaltxtbox.Clear();
            discount_totaltxtbox.Clear();
            discounted_totaltxtbox.Clear();

            // Uncheck radio buttons
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

            // Enable radio buttons
            radioButton1.Enabled = true;
            regularRbtn.Enabled = true;
            EmployeeRdbtn.Enabled = true;
            noTaxRdbtn.Enabled = true;

            // Reset variables
            qty_total = 0;
            discount_totalgiven = 0;
            discounted_total = 0;
            qty = 0;
            price = 0;
            discount_amt = 0;
            discounted_amt = 0;

            quantitytextbox.Focus();
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

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                change = cash_rendered - discounted_amt;

                qty_totaltxtbox.Text = qty_total.ToString("n");
                discount_totaltxtbox.Text = discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = discounted_total.ToString("n");
                changetxtbox.Text = change.ToString("n");
                cashre_renderedtxtbox.Text = cash_rendered.ToString("n");
            }
            catch (Exception)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label2.Text, "167.00");
            ClearQuantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label7.Text, "251.00");
            ClearQuantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label16.Text, "59.00");
            ClearQuantity();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label19.Text, "55.00");
            ClearQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label17.Text, "69.00");
            ClearQuantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label26.Text, "140.00");
            ClearQuantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label24.Text, "130.00");
            ClearQuantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label22.Text, "79.00");
            ClearQuantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label9.Text, "150.00");
            ClearQuantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label4.Text, "255.00");
            ClearQuantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label32.Text, "73.00");
            ClearQuantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label31.Text, "82.00");
            ClearQuantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label30.Text, "42.00");
            ClearQuantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label12.Text, "134.00");
            ClearQuantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label3.Text, "47.00");
            ClearQuantity();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label33.Text, "73.00");
            ClearQuantity();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label28.Text, "140.00");
            ClearQuantity();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label21.Text, "55.00");
            ClearQuantity();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label14.Text, "150.00");
            ClearQuantity();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_TextValue(label5.Text, "50.00");
            ClearQuantity();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ClearAll();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.30;
                computation_formula_and_DisplayData();

                regularRbtn.Enabled = false;
                EmployeeRdbtn.Enabled = false;
                noTaxRdbtn.Enabled = false;
            }
            catch (Exception)
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
            if (!regularRbtn.Checked) return;

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.10;
                computation_formula_and_DisplayData();

                radioButton1.Enabled = false;
                EmployeeRdbtn.Enabled = false;
                noTaxRdbtn.Enabled = false;
            }
            catch (Exception)
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
            if (!EmployeeRdbtn.Checked) return;

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0.15;
                computation_formula_and_DisplayData();

                radioButton1.Enabled = false;
                regularRbtn.Enabled = false;
                noTaxRdbtn.Enabled = false;
            }
            catch (Exception)
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
            if (!noTaxRdbtn.Checked) return;

            try
            {
                quantity_price_Convert();
                discount_amt = (qty * price) * 0;
                computation_formula_and_DisplayData();

                radioButton1.Enabled = false;
                regularRbtn.Enabled = false;
                EmployeeRdbtn.Enabled = false;
            }
            catch (Exception)
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