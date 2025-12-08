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
    public partial class POS2_DataBase : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private double total_amount = 0;
        private int total_qty = 0;

        // Store picture paths - FIXED: Now properly stores the paths
        private string[] picturePaths = new string[20];

        public POS2_DataBase()
        {
            posdb_connect.pos_connString();
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void Activity3_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.DarkOliveGreen;

                // Disable input fields
                priceTxtBox.Enabled = false;
                discountedAmountTxtbox.Enabled = false;
                changeTxtbox.Enabled = false;
                totalBillsTxtbox.Enabled = false;
                discountAmountTxtbox.Enabled = false;
                totalQtyTxtbox.Enabled = false;

                // Clear display listbox
                displayListbox.Items.Clear();
                displayListbox.Font = new Font("Courier New", 8);

                // Hide picture path textboxes
                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide();
                picpathTxtbox4.Hide(); picpathTxtbox5.Hide(); picpathTxtbox6.Hide();
                picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide();
                picpathTxtbox10.Hide(); picpathTxtbox11.Hide(); picpathTxtbox12.Hide();
                picpathTxtbox13.Hide(); picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
                picpathTxtbox16.Hide(); picpathTxtbox17.Hide(); picpathTxtbox18.Hide();
                picpathTxtbox19.Hide(); picpathTxtbox20.Hide();

                // Uncheck all checkboxes
                UncheckAllCheckboxes();

                // Load data from database
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_priceTbl ON pos_nameTbl.pos_id = pos_priceTbl.pos_id INNER JOIN pos_picTbl ON pos_priceTbl.pos_id = pos_picTbl.pos_id WHERE pos_nameTbl.pos_id = '333'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    // Set checkbox names from database
                    checkBox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                    checkBox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                    checkBox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                    checkBox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                    checkBox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                    checkBox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                    checkBox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                    checkBox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                    checkBox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                    checkBox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                    checkBox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                    checkBox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                    checkBox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                    checkBox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                    checkBox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                    checkBox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                    checkBox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                    checkBox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                    checkBox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                    checkBox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                    // FIXED: Store picture paths in the array so they can be used later
                    picturePaths[0] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                    picturePaths[1] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                    picturePaths[2] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                    picturePaths[3] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                    picturePaths[4] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                    picturePaths[5] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                    picturePaths[6] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                    picturePaths[7] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                    picturePaths[8] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                    picturePaths[9] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                    picturePaths[10] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                    picturePaths[11] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                    picturePaths[12] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                    picturePaths[13] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                    picturePaths[14] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                    picturePaths[15] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                    picturePaths[16] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                    picturePaths[17] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                    picturePaths[18] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                    picturePaths[19] = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();

                    // Load picture paths into hidden textboxes
                    picpathTxtbox1.Text = picturePaths[0];
                    pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
                    picpathTxtbox2.Text = picturePaths[1];
                    pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);
                    picpathTxtbox3.Text = picturePaths[2];
                    pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);
                    picpathTxtbox4.Text = picturePaths[3];
                    pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);
                    picpathTxtbox5.Text = picturePaths[4];
                    pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);
                    picpathTxtbox6.Text = picturePaths[5];
                    pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);
                    picpathTxtbox7.Text = picturePaths[6];
                    pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);
                    picpathTxtbox8.Text = picturePaths[7];
                    pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);
                    picpathTxtbox9.Text = picturePaths[8];
                    pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);
                    picpathTxtbox10.Text = picturePaths[9];
                    pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);
                    picpathTxtbox11.Text = picturePaths[10];
                    pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);
                    picpathTxtbox12.Text = picturePaths[11];
                    pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);
                    picpathTxtbox13.Text = picturePaths[12];
                    pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);
                    picpathTxtbox14.Text = picturePaths[13];
                    pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);
                    picpathTxtbox15.Text = picturePaths[14];
                    pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);
                    picpathTxtbox16.Text = picturePaths[15];
                    pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);
                    picpathTxtbox17.Text = picturePaths[16];
                    pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);
                    picpathTxtbox18.Text = picturePaths[17];
                    pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);
                    picpathTxtbox19.Text = picturePaths[18];
                    pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);
                    picpathTxtbox20.Text = picturePaths[19];
                    pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);
                }

                // Uncheck radio buttons
                foodARdbtn.Checked = false;
                foodBRdbtn.Checked = false;

                // Uncheck meal checkboxes
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form: " + ex.Message, "Error");
            }
        }

        // Helper method to uncheck all checkboxes
        private void UncheckAllCheckboxes()
        {
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
        }

        // Helper method to get price from database
        private string GetPriceFromDatabase(int itemNumber)
        {
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_priceTbl ON pos_nameTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '333'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    return posdb_connect.pos_sql_dataset.Tables[0].Rows[0][23 + itemNumber].ToString();
                }
            }
            catch (Exception) { }

            return "0";
        }

        private double GetDiscountPercent(int itemNumber)
        {
            double[] discounts = { 2.0, 3.5, 2.5, 4.0, 3.0, 2.0, 4.5, 3.0, 5.0, 2.5,
                                   3.5, 4.0, 2.0, 3.0, 5.0, 2.5, 4.0, 3.5, 2.0, 4.5 };

            if (itemNumber >= 1 && itemNumber <= 20)
            {
                return discounts[itemNumber - 1];
            }
            return 0;
        }


        private string FormatReceiptLine(string itemName, string price, bool includeDiscount = false, double discountPercent = 0)
        {
            int maxWidth = 50;
            if (itemName.Length > 35)
            {
                itemName = itemName.Substring(0, 32) + "...";
            }

            if (includeDiscount)
            {
                itemName = itemName + " (" + discountPercent + "%)";
            }

            string priceText =  price;

            int spacesNeeded = maxWidth - itemName.Length - priceText.Length;
            if (spacesNeeded < 1) spacesNeeded = 1;

            string spaces = new string(' ', spacesNeeded);
            return itemName + spaces + priceText;
        }


        private void HandleCheckboxSelection(CheckBox checkbox, int itemNumber, int pictureIndex)
        {
            if (!checkbox.Checked) return;
            UncheckAllCheckboxes();
            checkbox.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(itemNumber);
            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(itemNumber);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            string itemLine = FormatReceiptLine(checkbox.Text, priceTxtBox.Text, true, discountPercent);
            displayListbox.Items.Add(itemLine);

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[pictureIndex]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }




        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox1, 1, 0);
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox2, 2, 1);
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox3, 3, 2);
        }

        private void checkBox4_CheckedChanged_2(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox4, 4, 3);
        }

        private void checkBox5_CheckedChanged_2(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox5, 5, 4);
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox6, 6, 5);
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox7, 7, 6);
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox8, 8, 7);
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox9, 9, 8);
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox10, 10, 9);
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox11, 11, 10);
        }

        private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox12, 12, 11);
        }

        private void checkBox13_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox13, 13, 12);
        }

        private void checkBox14_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox14, 14, 13);
        }

        private void checkBox15_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox15, 15, 14);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox16, 16, 15);
        }

        private void checkBox17_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox17, 17, 16);
        }

        private void checkBox18_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox18, 18, 17);
        }

        private void checkBox19_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox19, 19, 18);
        }

        private void checkBox20_CheckedChanged_1(object sender, EventArgs e)
        {
            HandleCheckboxSelection(checkBox20, 20, 19);
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
                discounted_amount = (price * qty) - (discount_amount * qty);

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
                this.BackColor = Color.DarkOliveGreen;
                foodBRdbtn.Checked = false;

                try
                {
                    DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\Untitled design (1).png");
                }
                catch
                {
                    MessageBox.Show("Picture file not found. Please check the path.", "Warning");
                }

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

                // Use helper function for formatting
                displayListbox.Items.Add(FormatReceiptLine(foodARdbtn.Text, priceTxtBox.Text));
                displayListbox.Items.Add(FormatReceiptLine("Discount Amount:", discountAmountTxtbox.Text));

                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Food A");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                displayListbox.Items.Clear();
                this.BackColor = Color.DarkOliveGreen;
                foodARdbtn.Checked = false;

                try
                {
                    DisplayPictureBox.Image = Image.FromFile("C:\\Users\\C203-34\\source\\repos\\rylle643\\DSAL01E\\ACOTIN_POS_APPLICATION\\Resources\\Untitled design (2).png");
                }
                catch
                {
                    MessageBox.Show("Picture file not found. Please check the path.", "Warning");
                }

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

                // Use helper function for formatting
                displayListbox.Items.Add(FormatReceiptLine(foodBRdbtn.Text, priceTxtBox.Text));
                displayListbox.Items.Add(FormatReceiptLine("Discount Amount:", discountAmountTxtbox.Text));

                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading Food B");
            }
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

                // RECEIPT-STYLE FORMAT - aligned like a real receipt
                displayListbox.Items.Add("-----------------------------------------------------");
                displayListbox.Items.Add("Total no. of Items:".PadRight(42) + totalQtyTxtbox.Text);
                displayListbox.Items.Add("Total Bills:".PadRight(42) + totalBillsTxtbox.Text);
                displayListbox.Items.Add("Cash Given:".PadRight(42) +  cash_given.ToString("n"));
                displayListbox.Items.Add("Change:".PadRight(42) +  changeTxtbox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please check your entries.");
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

            UncheckAllCheckboxes();

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
                MessageBox.Show("Error opening transfer form.");
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
                MessageBox.Show("Error opening print form.");
            }
        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TransferButton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error opening transfer form.");
            }
        }

        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}