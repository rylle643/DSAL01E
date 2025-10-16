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
    public partial class Activity1_Function : Form
    {
        private double cash_given;
        private double amount_paid;
        private double change;
        private double price;
        private double quantity;

        public Activity1_Function()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ClearQuantity()
        {
            QuantitytextBox.Clear();
            QuantitytextBox.Focus();
        }
        private void displayTxtbox(string itemname, string price)
        {
            itemnameTextbox.Text = itemname;
            priceTxtbox.Text = price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangetextBox.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayTxtbox("Big Mac", "167.00");
            ClearQuantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displayTxtbox("Quarter Pounder", "255.00");
            ClearQuantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displayTxtbox("Burger McDo", "47.00");
            ClearQuantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayTxtbox("Chicken McDo with McSpaghetti", "251.00");
            ClearQuantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayTxtbox("Chicken McDo with Rice", "150.00");
            ClearQuantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displayTxtbox("Crispy Chicken Fillet with Rice", "134.00");
            ClearQuantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayTxtbox("Coke McFloat", "59.00");
            ClearQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayTxtbox("McFlurry with Oreo Cookies", "69.00");
            ClearQuantity();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayTxtbox("Hot Fudge Sundae", "55.00");
            ClearQuantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displayTxtbox("McCafé Americano", "79.00");
            ClearQuantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displayTxtbox("McCafé Premium Hot Chocolate", "130.00");
            ClearQuantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displayTxtbox("McCafé Iced Mocha", "140.00");
            ClearQuantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displayTxtbox("Cheesy Eggdesal", "42.00");
            ClearQuantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displayTxtbox("Sausage McMuffin with Egg", "82.00");
            ClearQuantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displayTxtbox("Egg McMuffin", "73.00");
            ClearQuantity();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            try
            {
                itemnameTextbox.Clear();
                priceTxtbox.Clear();
                QuantitytextBox.Clear();
                AmountPaidtextBox.Clear();
                CashGiventextBox.Clear();
                ChangetextBox.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemnameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void priceTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (QuantitytextBox.Text == "") return;

                price = Convert.ToDouble(priceTxtbox.Text);
                quantity = Convert.ToDouble(QuantitytextBox.Text);
                amount_paid = price * quantity;
                AmountPaidtextBox.Text = amount_paid.ToString("C");
                CashGiventextBox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Input");
                QuantitytextBox.Clear();
                QuantitytextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cash_given = Convert.ToDouble(CashGiventextBox.Text);
                change = cash_given - amount_paid;

                ChangetextBox.Text = change.ToString("C");
                CashGiventextBox.Text = cash_given.ToString("C");

                MessageBox.Show("Successfully Computed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CashGiventextBox.Clear();
                CashGiventextBox.Focus();
            }
            finally
            { }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AmountPaidtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
