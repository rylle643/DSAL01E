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
    public partial class POS1_DataBase : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        Price_Item_Value price_item_value = new Price_Item_Value();
        Variables variables = new Variables();

        public POS1_DataBase()
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
            pricetextbox.Clear() ;
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


                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_priceTbl ON pos_nameTbl.pos_id = pos_priceTbl.pos_id INNER JOIN pos_picTbl ON pos_priceTbl.pos_id = pos_picTbl.pos_id WHERE pos_nameTbl.pos_id = '333'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {

                    namelabel1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                    namelabel2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                    namelabel3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                    namelabel4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                    namelabel5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                    namelabel6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                    namelabel7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                    namelabel8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                    namelabel9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                    namelabel10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                    namelabel11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                    namelabel12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                    namelabel13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                    namelabel14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                    namelabel15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                    namelabel16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                    namelabel17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                    namelabel18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                    namelabel19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                    namelabel20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();


                    pricelbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                    pricelbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                    pricelbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                    pricelbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                    pricelbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                    pricelbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                    pricelbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                    pricelbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                    pricelbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                    pricelbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                    pricelbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                    pricelbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                    pricelbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                    pricelbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                    pricelbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                    pricelbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                    pricelbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                    pricelbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                    pricelbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                    pricelbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();


                    picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                    pictureBox1.Image = Image.FromFile(picpathTxtbox1.Text);
                    picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                    pictureBox2.Image = Image.FromFile(picpathTxtbox2.Text);
                    picpathTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                    pictureBox3.Image = Image.FromFile(picpathTxtbox3.Text);
                    picpathTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                    pictureBox4.Image = Image.FromFile(picpathTxtbox4.Text);
                    picpathTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                    pictureBox5.Image = Image.FromFile(picpathTxtbox5.Text);
                    picpathTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                    pictureBox6.Image = Image.FromFile(picpathTxtbox6.Text);
                    picpathTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                    pictureBox7.Image = Image.FromFile(picpathTxtbox7.Text);
                    picpathTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                    pictureBox8.Image = Image.FromFile(picpathTxtbox8.Text);
                    picpathTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                    pictureBox9.Image = Image.FromFile(picpathTxtbox9.Text);
                    picpathTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                    pictureBox10.Image = Image.FromFile(picpathTxtbox10.Text);
                    picpathTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                    pictureBox11.Image = Image.FromFile(picpathTxtbox11.Text);
                    picpathTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                    pictureBox12.Image = Image.FromFile(picpathTxtbox12.Text);
                    picpathTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                    pictureBox13.Image = Image.FromFile(picpathTxtbox13.Text);
                    picpathTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                    pictureBox14.Image = Image.FromFile(picpathTxtbox14.Text);
                    picpathTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                    pictureBox15.Image = Image.FromFile(picpathTxtbox15.Text);
                    picpathTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                    pictureBox16.Image = Image.FromFile(picpathTxtbox16.Text);
                    picpathTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                    pictureBox17.Image = Image.FromFile(picpathTxtbox17.Text);
                    picpathTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                    pictureBox18.Image = Image.FromFile(picpathTxtbox18.Text);
                    picpathTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                    pictureBox19.Image = Image.FromFile(picpathTxtbox19.Text);
                    picpathTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
                    pictureBox20.Image = Image.FromFile(picpathTxtbox20.Text);
                }


                posdb_connect.pos_sql = "SELECT emp_id, emp_fname, emp_surname, terminal_no FROM employeeTbl WHERE emp_id = '789'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();

                if (posdb_connect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    emp_idLabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][0].ToString();
                    emp_fnameLabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][1].ToString();
                    emp_surnameLabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                    terminal_nolabel.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                }

                DateTime dateTime = DateTime.Now;
                time_dateLabel.Text = dateTime.ToString("M/d/yyyy");

            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
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

        

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void emp_surnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string dateToSave = DateTime.Now.ToString("M/d/yyyy");

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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel1.Text, pricelbl1.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel2.Text, pricelbl2.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel3.Text, pricelbl3.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel4.Text, pricelbl4.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel5.Text, pricelbl5.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel6.Text, pricelbl6.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel7.Text, pricelbl7.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel8.Text, pricelbl8.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel9.Text, pricelbl9.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel10.Text, pricelbl10.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel11.Text, pricelbl11.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel12.Text, pricelbl12.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel13.Text, pricelbl13.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel14.Text, pricelbl14.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel15.Text, pricelbl15.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel16.Text, pricelbl16.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel17.Text, pricelbl17.Text);
            GetPriceItemValue();
            quantityTxtbox();                                                                                                                                                                                                                          
        }

        private void pictureBox18_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel18.Text, pricelbl18.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel19.Text, pricelbl19.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void pictureBox20_Click_1(object sender, EventArgs e)
        {
            price_item_value.SetPriceItemValue(namelabel20.Text, pricelbl20.Text);
            GetPriceItemValue();
            quantityTxtbox();
        }

        private void emp_idLabel_Click(object sender, EventArgs e)
        {

        }
    }
}