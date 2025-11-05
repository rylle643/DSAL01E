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

        // NEW: Helper method to get discount percentage for each item (2% to 5%)
        private double GetDiscountPercent(int itemNumber)
        {
            // Different discount for each item between 2% and 5%
            double[] discounts = { 2.0, 3.5, 2.5, 4.0, 3.0, 2.0, 4.5, 3.0, 5.0, 2.5,
                                   3.5, 4.0, 2.0, 3.0, 5.0, 2.5, 4.0, 3.5, 2.0, 4.5 };

            if (itemNumber >= 1 && itemNumber <= 20)
            {
                return discounts[itemNumber - 1];
            }
            return 0;
        }

        // CheckBox event handlers
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) return;
            UncheckAllCheckboxes();
            checkBox1.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(1);

            // Calculate discount (2% for item 1)
            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(1);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox1.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            // FIXED: Show picture in DisplayPictureBox
            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[0]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox2.Checked) return;
            UncheckAllCheckboxes();
            checkBox2.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(2);

            // Calculate discount (3.5% for item 2)
            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(2);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox2.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            // FIXED: Show picture in DisplayPictureBox
            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[1]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox3.Checked) return;
            UncheckAllCheckboxes();
            checkBox3.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(3);

            // Calculate discount (2.5% for item 3)
            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(3);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox3.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            // FIXED: Show picture in DisplayPictureBox
            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[2]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox4_CheckedChanged_2(object sender, EventArgs e)
        {
            if (!checkBox4.Checked) return;
            UncheckAllCheckboxes();
            checkBox4.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(4);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(4);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox4.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[3]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox5_CheckedChanged_2(object sender, EventArgs e)
        {
            if (!checkBox5.Checked) return;
            UncheckAllCheckboxes();
            checkBox5.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(5);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(5);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox5.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[4]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox6.Checked) return;
            UncheckAllCheckboxes();
            checkBox6.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(6);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(6);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox6.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[5]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox7.Checked) return;
            UncheckAllCheckboxes();
            checkBox7.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(7);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(7);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox7.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[6]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox8.Checked) return;
            UncheckAllCheckboxes();
            checkBox8.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(8);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(8);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox8.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[7]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox9.Checked) return;
            UncheckAllCheckboxes();
            checkBox9.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(9);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(9);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox9.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[8]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox10.Checked) return;
            UncheckAllCheckboxes();
            checkBox10.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(10);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(10);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox10.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[9]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox11.Checked) return;
            UncheckAllCheckboxes();
            checkBox11.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(11);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(11);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox11.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[10]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox12_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox12.Checked) return;
            UncheckAllCheckboxes();
            checkBox12.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(12);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(12);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox12.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[11]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox13_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox13.Checked) return;
            UncheckAllCheckboxes();
            checkBox13.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(13);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(13);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox13.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[12]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox14_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox14.Checked) return;
            UncheckAllCheckboxes();
            checkBox14.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(14);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(14);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox14.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[13]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox15_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox15.Checked) return;
            UncheckAllCheckboxes();
            checkBox15.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(15);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(15);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox15.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[14]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox16.Checked) return;
            UncheckAllCheckboxes();
            checkBox16.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(16);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(16);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox16.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[15]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox17_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox17.Checked) return;
            UncheckAllCheckboxes();
            checkBox17.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(17);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(17);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox17.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[16]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox18_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox18.Checked) return;
            UncheckAllCheckboxes();
            checkBox18.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(18);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(18);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox18.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[17]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox19_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox19.Checked) return;
            UncheckAllCheckboxes();
            checkBox19.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(19);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(19);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox19.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[18]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
        }

        private void checkBox20_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkBox20.Checked) return;
            UncheckAllCheckboxes();
            checkBox20.Checked = true;

            priceTxtBox.Text = GetPriceFromDatabase(20);

            double price = Convert.ToDouble(priceTxtBox.Text);
            double discountPercent = GetDiscountPercent(20);
            double discountAmount = price * (discountPercent / 100);
            discountAmountTxtbox.Text = discountAmount.ToString("0.00");

            displayListbox.Items.Add(checkBox20.Text + " - " + priceTxtBox.Text + " (Discount: " + discountPercent + "%)");

            try { DisplayPictureBox.Image = Image.FromFile(picturePaths[19]); }
            catch { }

            qtyTxtbox.Clear();
            qtyTxtbox.Focus();
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
                displayListbox.Items.Add(foodARdbtn.Text + " - " + priceTxtBox.Text + " ");
                displayListbox.Items.Add("Discount Amount:       " + discountAmountTxtbox.Text);

                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Food A: " + ex.Message, "Error");
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

                displayListbox.Items.Add(foodBRdbtn.Text + " - " + priceTxtBox.Text);
                displayListbox.Items.Add("Discount Amount:        " + discountAmountTxtbox.Text);

                qtyTxtbox.Text = "0";
                qtyTxtbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Food B: " + ex.Message, "Error");
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

                displayListbox.Items.Add("Total no. of Items:    " + totalQtyTxtbox.Text);
                displayListbox.Items.Add("Total Bills:           " + totalBillsTxtbox.Text);
                displayListbox.Items.Add("Cash Given:            " + cash_given.ToString("n"));
                displayListbox.Items.Add("Change:                " + changeTxtbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check your entries.", "Error");
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
            catch (Exception ex)
            {
                MessageBox.Show("Error opening transfer form.", "Error");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
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

                print.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening transfer form.", "Error");
            }
        }

        private void DisplayPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}