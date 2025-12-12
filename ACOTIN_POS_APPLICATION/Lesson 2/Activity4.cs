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
    public partial class Activity4 : Form
    {

        private double total_amount = 0;
        private int total_qty = 0;
        public Activity4()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(1.28f, 1.07f));
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(qtyTxtbox.Text)) return;

                double price, discounted_amount, discount_amount;
                int qty;

                price = Convert.ToDouble("0" + priceTxtBox.Text);
                qty = Convert.ToInt32(qtyTxtbox.Text);
                discount_amount = Convert.ToDouble("0" + discountAmountTxtbox.Text);
                discounted_amount = (price * qty) - discount_amount;

                total_qty += qty;
                totalQtyTxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                totalBillsTxtbox.Text = total_amount.ToString("n");
                discountedAmountTxtbox.Text = discounted_amount.ToString("n");

                cashGivenTxtbox.Clear();
                cashGivenTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.", "Error");
                qtyTxtbox.Clear();
                qtyTxtbox.Focus();
            }
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
            try
            {
                displayListbox.Items.Clear();

                this.BackColor = Color.Goldenrod;

                double price;

                foodBRdbtn.Checked = false;
                DisplayPictureBox.Image = Resources.Untitleddesign1;

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

                priceTxtBox.Text = "720.00";
                discountAmountTxtbox.Text = "144.00";
                price = Convert.ToDouble(priceTxtBox.Text);
                displayListbox.Items.Add(foodARdbtn.Text + " - " + priceTxtBox.Text + " ");
                displayListbox.Items.Add("Discount Amount:       " + discountAmountTxtbox.Text);

                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Food A. Please check the image path.", "Error");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                displayListbox.Items.Clear();

                this.BackColor = Color.Goldenrod;

                foodARdbtn.Checked = false;
                DisplayPictureBox.Image = Resources.Untitleddesign2;

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

                priceTxtBox.Text = "450.00";
                discountAmountTxtbox.Text = "67.50";

                displayListbox.Items.Add(foodBRdbtn.Text + " - " + priceTxtBox.Text);
                displayListbox.Items.Add("Discount Amount:        " + discountAmountTxtbox.Text);

                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Food B. Please check the image path.", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foodARdbtn.Checked = false;
                foodBRdbtn.Checked = false;

                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\Rylle\\Downloads\\ACOTIN-DSAL\\no-image-available-icon-vector.jpg");

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
            catch (Exception)
            {
                MessageBox.Show("Error clearing form.", "Error");
            }
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;

            // Clear display listbox on load
            displayListbox.Items.Clear();

            priceTxtBox.Enabled = false;
            discountedAmountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountAmountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;

            // Ensure radio buttons start unchecked
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

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
            try
            {
                double price;
                priceTxtBox.Text = "59.00";
                price = Convert.ToDouble(priceTxtBox.Text);
                displayListbox.Items.Add(checkBox3.Text + " -         " + priceTxtBox.Text);
                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error selecting item.", "Error");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double price;
                priceTxtBox.Text = "130.00";
                price = Convert.ToDouble(priceTxtBox.Text);
                displayListbox.Items.Add(checkBox9.Text + " - " + priceTxtBox.Text);
                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error selecting item.", "Error");
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cashGivenTxtbox.Text))
                {
                    MessageBox.Show("Please enter cash given amount.", "Error");
                    cashGivenTxtbox.Focus();
                    return;
                }

                double cash_given, change;
                double total_bills = double.Parse(totalBillsTxtbox.Text.Replace(",", ""));

                cash_given = Convert.ToDouble(cashGivenTxtbox.Text);
                change = cash_given - total_bills;

                if (change < 0)
                {
                    MessageBox.Show("Insufficient cash given.", "Error");
                    cashGivenTxtbox.Focus();
                    return;
                }

                changeTxtbox.Text = change.ToString("n");

                displayListbox.Items.Add("Total no. of Items:    " + totalQtyTxtbox.Text);
                displayListbox.Items.Add("Total Bills:           " + totalBillsTxtbox.Text);
                displayListbox.Items.Add("Cash Given:            " + cash_given.ToString("n"));
                displayListbox.Items.Add("Change:                " + changeTxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please check your entries.", "Error");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ACOTIN_POS_APPLICATION.Activity4_PrintFrm print = new ACOTIN_POS_APPLICATION.Activity4_PrintFrm();
                print.printDisplayListbox.Items.AddRange(this.displayListbox.Items);
                print.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening print form.", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayListbox.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\no-image-available-icon-vector.jpg");

            A_ChickenMcDoBox.Checked = false;
            A_BFFFriesBox.Checked = false;
            A_DrinksBox.Checked = false;
            A_RiceBox.Checked = false;
            A_Gravy.Checked = false;

            B_ApplePieBox.Checked = false;
            B_BFFFriesBox.Checked = false;
            B_BurgerMcDoBox.Checked = false;
            B_ChickenSandwichBox.Checked = false;
            B_QuarterPounderBox.Checked = false;

            // Clear all individual checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            priceTxtBox.Clear();
            qtyTxtbox.Clear();
            discountAmountTxtbox.Clear();
            discountedAmountTxtbox.Clear();
            totalBillsTxtbox.Clear();
            totalQtyTxtbox.Clear();
            cashGivenTxtbox.Clear();
            changeTxtbox.Clear();


            total_amount = 0;
            total_qty = 0;

            displayListbox.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "140.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox19.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "73.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox20.Text + " -             " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "55.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox18.Text + " -   " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "150.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox17.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "50.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox16.Text + " -   " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "167.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox1.Text + " -              " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "255.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox6.Text + " -      " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "47.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox11.Text + " -          " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "251.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox2.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "150.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox7.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "134.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox12.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "69.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox8.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "55.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox13.Text + " -     " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "79.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox4.Text + " -     " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "140.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox14.Text + " -    " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "42.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox5.Text + " -      " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "82.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox10.Text + " - " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            double price;
            priceTxtBox.Text = "73.00";
            price = Convert.ToDouble(priceTxtBox.Text);
            displayListbox.Items.Add(checkBox15.Text + " -         " + priceTxtBox.Text);
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void A_ChickenMcDoBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void A_BFFFriesBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void A_DrinksBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void A_RiceBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void A_Gravy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B_ApplePieBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B_BFFFriesBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B_ChickenSandwichBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void B_QuarterPounderBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Activity4_Transfer print = new Activity4_Transfer();

                print.priceTxtBox.Text = this.priceTxtBox.Text;
                print.qtyTxtbox.Text = this.qtyTxtbox.Text;
                print.discountAmountTxtbox.Text = this.discountAmountTxtbox.Text;
                print.discountedAmountTxtbox.Text = this.discountedAmountTxtbox.Text;
                print.totalBillsTxtbox.Text = this.totalBillsTxtbox.Text;
                print.totalQtyTxtbox.Text = this.totalQtyTxtbox.Text;
                print.cashGivenTxtbox.Text = this.cashGivenTxtbox.Text;
                print.changeTxtbox.Text = this.changeTxtbox.Text;

                print.foodARdbtn.Checked = this.foodARdbtn.Checked;
                print.foodBRdbtn.Checked = this.foodBRdbtn.Checked;

                print.A_ChickenMcDoBox.Checked = this.A_ChickenMcDoBox.Checked;
                print.A_BFFFriesBox.Checked = this.A_BFFFriesBox.Checked;
                print.A_DrinksBox.Checked = this.A_DrinksBox.Checked;
                print.A_RiceBox.Checked = this.A_RiceBox.Checked;
                print.A_Gravy.Checked = this.A_Gravy.Checked;

                print.B_ApplePieBox.Checked = this.B_ApplePieBox.Checked;
                print.B_BFFFriesBox.Checked = this.B_BFFFriesBox.Checked;
                print.B_BurgerMcDoBox.Checked = this.B_BurgerMcDoBox.Checked;
                print.B_ChickenSandwichBox.Checked = this.B_ChickenSandwichBox.Checked;
                print.B_QuarterPounderBox.Checked = this.B_QuarterPounderBox.Checked;

                print.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening transfer form.", "Error");
            }
        }
    }
}