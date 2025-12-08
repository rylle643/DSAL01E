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
    public partial class useraccount_report : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public useraccount_report()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void useraccount_select()
        {
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();
        }

        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }

        private void sales_reports_Load(object sender, EventArgs e)
        {
            optionCombo.Items.Add("Select search option");
            optionCombo.Items.Add("transaction_id");
            optionCombo.Items.Add("terminal_number");
            optionCombo.Items.Add("date and time");
            optionCombo.Items.Add("product name");
            optionCombo.Items.Add("employee_number");
            optionCombo.Items.Add("pay_date");

            optionCombo.SelectedIndex = 0;
            optionCombo.Focus();

            try
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl";
                posdb_connect.pos_cmd(); posdb_connect.pos_sqladapterSelect(); posdb_connect.pos_sqldatasetSELECTSALES(); dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (optionCombo.Text == "transaction_id")
                {
                    posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE transaction_id = '" + optionInputTxtbox.Text + "'";
                    pos_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "terminal_number")
                {
                    posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE terminal_no = '" + optionInputTxtbox.Text + "'";
                    pos_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "date and time")
                {
                    posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE time_date = '" + optionInputTxtbox.Text + "'";
                    pos_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "product name")
                {
                    posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE product_name = '" + optionInputTxtbox.Text + "'";
                    pos_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "employee_number")
                {
                    posdb_connect.pos_sql = "SELECT * FROM salesTbl WHERE emp_id = '" + optionInputTxtbox.Text + "'";
                    pos_select();
                    cleartextboxes1();
                }
                else
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl";
                pos_select();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
