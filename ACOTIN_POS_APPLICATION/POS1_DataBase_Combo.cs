using ACOTIN_POS_APPLICATION.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ACOTIN_POS_APPLICATION
{
    public partial class POS1_DataBase_Combo : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        public POS1_DataBase_Combo()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void GetPriceItemValue()
        {
            itemnametxtbox.Text = price_item_value.GetItemName();
            pricetextbox.Text = price_item_value.GetPrice();
        }

        private void quantityTxtbox()
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

        private void cleartextboxes()
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytextbox.Clear();
            discountedtxtbox.Clear();
            discounttxtbox.Clear();
            changetxtbox.Clear();
            cashre_renderedtxtbox.Clear();
        }

        private void Activity2_Load(object sender, EventArgs e)
        {
            try
            {
                itemnametxtbox.Enabled = false;
                pricetextbox.Enabled = false;
                discountedtxtbox.Enabled = false;
                qty_totaltxtbox.Enabled = false;
                discount_totaltxtbox.Enabled = false;
                discounted_totaltxtbox.Enabled = false;
                changetxtbox.Enabled = false;
                discounttxtbox.Enabled = false;

                picpathTxtbox1.Hide(); picpathTxtbox2.Hide(); picpathTxtbox3.Hide();
                picpathTxtbox4.Hide(); picpathTxtbox5.Hide(); picpathTxtbox6.Hide();
                picpathTxtbox7.Hide(); picpathTxtbox8.Hide(); picpathTxtbox9.Hide();
                picpathTxtbox10.Hide(); picpathTxtbox11.Hide();
                picpathTxtbox12.Hide(); picpathTxtbox13.Hide();
                picpathTxtbox14.Hide(); picpathTxtbox15.Hide();
                picpathTxtbox16.Hide(); picpathTxtbox17.Hide();
                picpathTxtbox18.Hide(); picpathTxtbox19.Hide();
                picpathTxtbox20.Hide();

                DateTime dateTime = DateTime.Now;
                time_dateLabel.Text = dateTime.ToString("MMMM dd, yyyy");

                LoadPosIdComboBox();
                LoadCashierComboBox();

                posdb_connect.pos_select_cashier();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                // Check if data exists before accessing
                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    namelabel1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                    namelabel2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                    namelabel3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                    namelabel4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                    namelabel5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                    namelabel10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                    namelabel9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                    namelabel8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                    namelabel7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                    namelabel6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                    namelabel15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                    namelabel14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                    namelabel13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                    namelabel12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                    namelabel11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                    namelabel20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                    namelabel19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                    namelabel18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                    namelabel17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                    namelabel16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();
                    picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                    pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
                    picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                    pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);
                    picpathTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                    pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);
                    picpathTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                    pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);
                    picpathTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                    pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);
                    picpathTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                    pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);
                    picpathTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                    pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);
                    picpathTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                    pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);
                    picpathTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                    pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);
                    picpathTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                    pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);
                    picpathTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                    pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);
                    picpathTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                    pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);
                    picpathTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                    pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);
                    picpathTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                    pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);
                    picpathTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                    pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);
                    picpathTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                    pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);
                    picpathTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                    pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);
                    picpathTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                    pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);
                    picpathTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                    pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);
                    picpathTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                    pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);
                    pricelbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                    pricelbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                    pricelbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                    pricelbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                    pricelbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                    pricelbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                    pricelbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                    pricelbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                    pricelbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                    pricelbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                    pricelbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                    pricelbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                    pricelbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                    pricelbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                    pricelbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                    pricelbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                    pricelbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                    pricelbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                    pricelbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                    pricelbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
                }

                posdb_connect.pos_select_cashier_display();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_select_cashier_SELECTdisplay();

                // Check if data exists before accessing
                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    terminal_nolabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                    emp_idLabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
                    emp_fnameLabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
                    emp_surnameLabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                variables.quantity = Convert.ToInt32(quantitytextbox.Text);
                variables.discount_amt = Convert.ToDouble(discounttxtbox.Text);
                variables.discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
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
                MessageBox.Show("Invalid input. Please check your entries.");
                cashre_renderedtxtbox.Clear();
                cashre_renderedtxtbox.Focus();
            }
        }

        private void LoadPosIdComboBox()
        {
            try
            {
                posdb_connect.pos_sql = "SELECT DISTINCT pos_id FROM pos_nameTbl";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                pos_id_comboBox.Items.Clear();
                foreach (DataRow row in posdb_connect.pos_sql_dataset.Tables[0].Rows)
                    pos_id_comboBox.Items.Add(row["pos_id"].ToString());

                if (pos_id_comboBox.Items.Count > 0)
                    pos_id_comboBox.SelectedIndex = 0;
            }
            catch { MessageBox.Show("Error loading POS IDs!"); }
        }

        private void LoadCashierComboBox()
        {
            try
            {
                posdb_connect.pos_sql = "SELECT emp_id, emp_fname, emp_surname FROM employeeTbl";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                cashier_comboBox.Items.Clear();
                foreach (DataRow row in posdb_connect.pos_sql_dataset.Tables[0].Rows)
                    cashier_comboBox.Items.Add($"{row["emp_id"]} - {row["emp_fname"]} {row["emp_surname"]}");

                if (cashier_comboBox.Items.Count > 0)
                    cashier_comboBox.SelectedIndex = 0;
            }
            catch { MessageBox.Show("Error loading cashiers!"); }
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
                MessageBox.Show("Invalid input.");
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
                MessageBox.Show("Invalid input.");
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
                MessageBox.Show("Invalid input.");
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
                MessageBox.Show("Invalid input.");
                noTaxRdbtn.Checked = false;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + quantitytextbox.Text + "', '" + pricetextbox.Text + "', '" + radioButton1.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_nolabel.Text + "', '" + time_dateLabel.Text + "', '" + emp_idLabel.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (regularRbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + quantitytextbox.Text + "', '" + pricetextbox.Text + "', '" + regularRbtn.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_nolabel.Text + "', '" + time_dateLabel.Text + "', '" + emp_idLabel.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (EmployeeRdbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + quantitytextbox.Text + "', '" + pricetextbox.Text + "', '" + EmployeeRdbtn.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_nolabel.Text + "', '" + time_dateLabel.Text + "', '" + emp_idLabel.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else if (noTaxRdbtn.Checked == true)
                {
                    posdb_connect.pos_sql = "INSERT INTO salesTbl (product_name, product_quantity_per_transaction, product_price, discount_option, discount_amount_per_transaction, discounted_amount_per_transaction, summary_total_quantity, summary_total_disc_given, summary_total_discounted_amount, terminal_no, time_date, emp_id) VALUES ('" + itemnametxtbox.Text + "', '" + quantitytextbox.Text + "', '" + pricetextbox.Text + "', '" + noTaxRdbtn.Text + "', '" + discounttxtbox.Text + "', '" + discountedtxtbox.Text + "', '" + qty_totaltxtbox.Text + "', '" + discount_totaltxtbox.Text + "', '" + discounted_totaltxtbox.Text + "', '" + terminal_nolabel.Text + "', '" + time_dateLabel.Text + "', '" + emp_idLabel.Text + "')";
                    posdb_connect.pos_cmd();
                    posdb_connect.pos_sqladapterInsert();
                    cleartextboxes();
                }
                else
                {
                    MessageBox.Show("No selected discount option");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator for this matter!!!");
            }
        }

        // When user selects a product from dropdown
        private void pos_id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get selected product ID
                string selectedPosId = pos_id_comboBox.SelectedItem.ToString();

                // Get product data from database
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl " +
                                         "INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                                         "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id " +
                                         "WHERE pos_nameTbl.pos_id = '" + selectedPosId + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                DataRow data = posdb_connect.pos_sql_dataset.Tables[0].Rows[0];

                // Update names (column 2-21)
                Label[] names = { namelabel1, namelabel2, namelabel3, namelabel4, namelabel5, namelabel6, namelabel7, namelabel8, namelabel9, namelabel10, namelabel11, namelabel12, namelabel13, namelabel14, namelabel15, namelabel16, namelabel17, namelabel18, namelabel19, namelabel20 };
                for (int i = 0; i < 20; i++)
                    names[i].Text = data[i + 2].ToString();

                // Update pictures (column 24-43)
                TextBox[] paths = { picpathTxtbox1, picpathTxtbox2, picpathTxtbox3, picpathTxtbox4, picpathTxtbox5, picpathTxtbox6, picpathTxtbox7, picpathTxtbox8, picpathTxtbox9, picpathTxtbox10, picpathTxtbox11, picpathTxtbox12, picpathTxtbox13, picpathTxtbox14, picpathTxtbox15, picpathTxtbox16, picpathTxtbox17, picpathTxtbox18, picpathTxtbox19, picpathTxtbox20 };
                PictureBox[] pics = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };
                for (int i = 0; i < 20; i++)
                {
                    paths[i].Text = data[i + 24].ToString();
                    try { pics[i].Image = Image.FromFile(paths[i].Text); } catch { }
                }

                // Update prices (column 46-65)
                Label[] prices = { pricelbl1, pricelbl2, pricelbl3, pricelbl4, pricelbl5, pricelbl6, pricelbl7, pricelbl8, pricelbl9, pricelbl10, pricelbl11, pricelbl12, pricelbl13, pricelbl14, pricelbl15, pricelbl16, pricelbl17, pricelbl18, pricelbl19, pricelbl20 };
                for (int i = 0; i < 20; i++)
                    prices[i].Text = data[i + 46].ToString();
            }
            catch
            {
                MessageBox.Show("Error loading products!");
            }
        }

        // When user selects a cashier from dropdown
        private void cashier_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get employee ID from selection (example: "123 - John Doe")
                string selectedText = cashier_comboBox.SelectedItem.ToString();
                string empId = selectedText.Split('-')[0].Trim();

                // Get employee data from database
                posdb_connect.pos_sql = "SELECT emp_id, emp_fname, emp_surname, terminal_no FROM employeeTbl WHERE emp_id = '" + empId + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                DataRow emp = posdb_connect.pos_sql_dataset.Tables[0].Rows[0];

                // Display employee info
                emp_idLabel.Text = emp["emp_id"].ToString();
                emp_fnameLabel.Text = emp["emp_fname"].ToString();
                emp_surnameLabel.Text = emp["emp_surname"].ToString();
                terminal_nolabel.Text = emp["terminal_no"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading cashier info!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel1.Text, pricelbl1.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel2.Text, pricelbl2.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel3.Text, pricelbl3.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel4.Text, pricelbl4.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel5.Text, pricelbl5.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel6.Text, pricelbl6.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel7.Text, pricelbl7.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel8.Text, pricelbl8.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel9.Text, pricelbl9.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel10.Text, pricelbl10.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel11.Text, pricelbl11.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel12.Text, pricelbl12.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel13.Text, pricelbl13.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel14.Text, pricelbl14.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel15.Text, pricelbl15.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel16.Text, pricelbl16.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel17.Text, pricelbl17.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel18.Text, pricelbl18.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel19.Text, pricelbl19.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel20.Text, pricelbl20.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}