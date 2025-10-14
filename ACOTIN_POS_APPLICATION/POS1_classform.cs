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
    public partial class POS1_classform : Form
    {
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        public POS1_classform()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(1.3f, 1.25f));
            };
        }

        private void GetPriceItemValue()
        {
            itemnametxtbox.Text = price_item_value.GetItemName();
            pricetextbox.Text = price_item_value.GetPrice();
        }

        private void ClearQuantity()
        {
            quantitytextbox.Clear();
            quantitytextbox.Focus();
        }

        private void quantity_price_Convert()
        {
            variables.quantity = Convert.ToInt32(quantitytextbox.Text);
            variables.price = Convert.ToDouble(pricetextbox.Text);
        }

        private void computation_Formula_and_DisplayData()
        {
            variables.discounted_amt = (variables.quantity * variables.price) - variables.discount_amt;
            discounttxtbox.Text = variables.discount_amt.ToString("n");
            discountedtxtbox.Text = variables.discounted_amt.ToString("n");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                variables.cash_given = Convert.ToDouble(cashre_renderedtxtbox.Text);

                if (variables.cash_given < variables.discounted_amt)
                {
                    MessageBox.Show("Not enough cash rendered.", "Error");
                    cashre_renderedtxtbox.Clear();
                    cashre_renderedtxtbox.Focus();
                    return;
                }

                variables.change = variables.cash_given - variables.discounted_amt;
                changetxtbox.Text = variables.change.ToString("n");
                cashre_renderedtxtbox.Text = variables.cash_given.ToString("n");

                variables.qty_total += variables.quantity;
                variables.discount_totalgiven += variables.discount_amt;
                variables.discounted_total += variables.discounted_amt;

                qty_totaltxtbox.Text = variables.qty_total.ToString();
                discount_totaltxtbox.Text = variables.discount_totalgiven.ToString("n");
                discounted_totaltxtbox.Text = variables.discounted_total.ToString("n");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please check your entries.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quantitytextbox.Text = "0";
            pricetextbox.Text = "0";
            discounttxtbox.Text = "0";
            discountedtxtbox.Text = "0";
            cashre_renderedtxtbox.Text = "0";

            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;

            itemnametxtbox.Clear();
            pricetextbox.Clear();
            discounttxtbox.Clear();
            quantitytextbox.Clear();
            cashre_renderedtxtbox.Clear();
            discountedtxtbox.Clear();
            changetxtbox.Clear();

            radioButton1.Enabled = true;
            regularRbtn.Enabled = true;
            EmployeeRdbtn.Enabled = true;
            noTaxRdbtn.Enabled = true;

            variables.quantity = 0;
            variables.price = 0;
            variables.discount_amt = 0;
            variables.discounted_amt = 0;

            quantitytextbox.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Big Mac", "167.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Chicken McDo with McSpaghetti", "251.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Coke McFloat", "59.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Hot Fudge Sundae", "55.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("McFlurry with Oreo Cookies", "69.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("McCafé Iced Mocha", "140.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("McCafé Premium Hot Chocolate", "130.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("McCafé Americano", "79.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Chicken McDo with Rice", "150.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Quarter Pounder", "255.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Egg McMuffin", "73.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Sausage McMuffin with Egg", "82.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Cheesy Eggdesal", "42.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Crispy Chicken Fillet with Rice", "134.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Burger McDo", "47.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Hotcakes", "73.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("McCafé Iced Americano", "140.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Hot Caramel Sundae", "55.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("Chicken McNuggets with Fries", "150.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue("McChicken Sandwich", "50.00");
            GetPriceItemValue();
            ClearQuantity();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;

            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.30;
                computation_Formula_and_DisplayData();

                regularRbtn.Enabled = false;
                EmployeeRdbtn.Enabled = false;
                noTaxRdbtn.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                radioButton1.Checked = false;
            }
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!regularRbtn.Checked) return;

            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.10;
                computation_Formula_and_DisplayData();

                radioButton1.Enabled = false;
                EmployeeRdbtn.Enabled = false;
                noTaxRdbtn.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                regularRbtn.Checked = false;
            }
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!EmployeeRdbtn.Checked) return;

            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0.15;
                computation_Formula_and_DisplayData();

                radioButton1.Enabled = false;
                regularRbtn.Enabled = false;
                noTaxRdbtn.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                EmployeeRdbtn.Checked = false;
            }
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!noTaxRdbtn.Checked) return;

            try
            {
                quantity_price_Convert();
                variables.discount_amt = (variables.quantity * variables.price) * 0;
                computation_Formula_and_DisplayData();

                radioButton1.Enabled = false;
                regularRbtn.Enabled = false;
                EmployeeRdbtn.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please enter quantity.", "Error");
                noTaxRdbtn.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label19_Click(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void label22_Click(object sender, EventArgs e) { }
        private void label34_Click(object sender, EventArgs e) { }
        private void label35_Click(object sender, EventArgs e) { }
        private void label36_Click(object sender, EventArgs e) { }
        private void label41_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void label37_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void label43_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void label42_Click(object sender, EventArgs e) { }
        private void label44_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_2(object sender, EventArgs e) { }
        private void label46_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void textBox2_TextChanged_2(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
    }
}