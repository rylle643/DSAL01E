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
    public partial class POS2_Functions : Form
    {
        private double total_amount = 0;
        private int total_qty = 0;

        public POS2_Functions()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) => { this.Scale(new SizeF(1.28f, 1.07f)); };
        }



        private void ClearAndFocusQty()
        {
            qtyTxtbox.Clear();
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void item_priceValue(string discount, string price)
        {
            double priceValue = Convert.ToDouble(price);
            double discountValue = priceValue * 0.05;

            priceTxtBox.Text = price;
            discountAmountTxtbox.Text = discountValue.ToString("0.00");

            int totalWidth = 40;
            int spacing = totalWidth - "Item".Length - price.Length;
            string spacer = new string(' ', Math.Max(spacing, 1));
            displayListbox.Items.Add("Item" + spacer + price);
        }

        private void ClearMealCheckboxes()
        {
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
        }

        private void ClearAllItemCheckboxes()
        {
            CheckBox[] checkboxes = {
                checkBox1, checkBox2, checkBox3, checkBox4, checkBox5,
                checkBox6, checkBox7, checkBox8, checkBox9, checkBox10,
                checkBox11, checkBox12, checkBox13, checkBox14, checkBox15,
                checkBox16, checkBox17, checkBox18, checkBox19, checkBox20
            };
            foreach (CheckBox cb in checkboxes) cb.Checked = false;
        }

        private void ResetForm()
        {
            try
            {
                displayListbox.Items.Clear();

                foodARdbtn.Checked = false;
                foodBRdbtn.Checked = false;

                ClearMealCheckboxes();
                ClearAllItemCheckboxes();

                priceTxtBox.Text = "";
                qtyTxtbox.Text = "";
                discountAmountTxtbox.Text = "";
                discountedAmountTxtbox.Text = "";
                totalBillsTxtbox.Text = "";
                totalQtyTxtbox.Text = "";
                cashGivenTxtbox.Text = "";
                changeTxtbox.Text = "";

                total_amount = 0;
                total_qty = 0;

                displayListbox.Items.Clear();

                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\no-image-available-icon-vector.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qtyTxtbox.Text == "" || qtyTxtbox.Text == "0") return;

                double price = Convert.ToDouble("0" + priceTxtBox.Text);
                int qty = Convert.ToInt32(qtyTxtbox.Text);
                double discount_amount = Convert.ToDouble("0" + discountAmountTxtbox.Text);
                double discounted_amount = (price * qty) - discount_amount;

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                displayListbox.Items.Clear();
                this.BackColor = Color.Goldenrod;
                foodBRdbtn.Checked = false;
                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\Untitled design (1).png");
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

                item_priceValue("144.00", "720.00");
                ClearAndFocusQty();
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
                DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\Untitled design (2).png");
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

                item_priceValue("67.50", "450.00");
                ClearAndFocusQty();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Food B. Please check the image path.", "Error");
            }
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Goldenrod;
            displayListbox.Items.Clear();

            priceTxtBox.Enabled = false;
            discountedAmountTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;
            totalBillsTxtbox.Enabled = false;
            discountAmountTxtbox.Enabled = false;
            totalQtyTxtbox.Enabled = false;

            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            ClearMealCheckboxes();
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

                double cash_given = Convert.ToDouble(cashGivenTxtbox.Text);
                double total_bills = double.Parse(totalBillsTxtbox.Text.Replace(",", ""));
                double change = cash_given - total_bills;

                if (change < 0)
                {
                    MessageBox.Show("Insufficient cash given.", "Error");
                    cashGivenTxtbox.Focus();
                    return;
                }

                changeTxtbox.Text = change.ToString("n");
                int totalWidth = 40;
                string totalItemsLine = ("Total no. of Items:").PadRight(totalWidth - totalQtyTxtbox.Text.Length) + totalQtyTxtbox.Text;
                string totalBillsLine = ("Total Bills:").PadRight(totalWidth - totalBillsTxtbox.Text.Length) + totalBillsTxtbox.Text;
                string cashGivenLine = ("Cash Given:").PadRight(totalWidth - cash_given.ToString("n").Length) + cash_given.ToString("n");
                string changeLine = ("Change:").PadRight(totalWidth - changeTxtbox.Text.Length) + changeTxtbox.Text;

                displayListbox.Items.Add(totalBillsLine);
                displayListbox.Items.Add(totalItemsLine);
                displayListbox.Items.Add(cashGivenLine);
                displayListbox.Items.Add(changeLine);

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
                Activity4_PrintFrm print = new Activity4_PrintFrm();
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
            ResetForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "167.00");
            ClearAndFocusQty();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "251.00");
            ClearAndFocusQty();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "59.00");
            ClearAndFocusQty();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            item_priceValue("0.00", "79.00");
            ClearAndFocusQty();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            item_priceValue("0.00", "42.00");
            ClearAndFocusQty();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "255.00");
            ClearAndFocusQty();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "150.00");
            ClearAndFocusQty();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "69.00");
            ClearAndFocusQty();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "130.00");
            ClearAndFocusQty();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "82.00");
            ClearAndFocusQty();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "47.00");
            ClearAndFocusQty();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "134.00");
            ClearAndFocusQty();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "55.00");
            ClearAndFocusQty();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "140.00");
            ClearAndFocusQty();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "73.00");
            ClearAndFocusQty();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "50.00");
            ClearAndFocusQty();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "150.00");
            ClearAndFocusQty();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "55.00");
            ClearAndFocusQty();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "140.00");
            ClearAndFocusQty();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            item_priceValue("0.00", "73.00");
            ClearAndFocusQty();
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label36_Click(object sender, EventArgs e) { }
        private void label37_Click(object sender, EventArgs e) { }
        private void label38_Click(object sender, EventArgs e) { }
        private void label39_Click(object sender, EventArgs e) { }
        private void label41_Click(object sender, EventArgs e) { }
        private void label42_Click(object sender, EventArgs e) { }
        private void label43_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void checkBox4_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox5_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox21_CheckedChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void A_ChickenMcDoBox_CheckedChanged(object sender, EventArgs e) { }
        private void A_BFFFriesBox_CheckedChanged(object sender, EventArgs e) { }
        private void A_DrinksBox_CheckedChanged(object sender, EventArgs e) { }
        private void A_RiceBox_CheckedChanged(object sender, EventArgs e) { }
        private void A_Gravy_CheckedChanged(object sender, EventArgs e) { }
        private void B_ApplePieBox_CheckedChanged(object sender, EventArgs e) { }
        private void B_BFFFriesBox_CheckedChanged(object sender, EventArgs e) { }
        private void B_BurgerMcDoBox_CheckedChanged(object sender, EventArgs e) { }
        private void B_ChickenSandwichBox_CheckedChanged(object sender, EventArgs e) { }
        private void B_QuarterPounderBox_CheckedChanged(object sender, EventArgs e) { }

        private void displayListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}