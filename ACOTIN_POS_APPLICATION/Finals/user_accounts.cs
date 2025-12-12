using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ACOTIN_POS_APPLICATION
{
    public partial class user_accounts : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public Button SearchforUpdate;
        public Button UpdateBTN;
        public Button Delete;
        public user_accounts()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }
        private void cleartextboxes()
        {
            emp_idTxtbox.Clear();
            userIDTxtbox.Clear();
            firstnameTxtbox.Clear();
            middlenameTxtbox.Clear();
            surnameTxtbox.Clear();
            designationTxtbox.Clear();
            usernameTxtbox.Clear();
            passwordTxtbox.Clear();
            confirmPasswordTxtbox.Clear();
            accountstatusComboBox.Text = "";
            accountTypeComboBox.Text = "";
            picpathTxtbox.Clear();
            pictureBox1.Image = null;
        }


        private void user_accounts_Load(object sender, EventArgs e)
        {
            try
            {
                
                accountstatusComboBox.Items.Add("Select...");
                accountstatusComboBox.Items.Add("Active");
                accountstatusComboBox.Items.Add("Inactive");
                accountstatusComboBox.Items.Add("Suspended");
                accountstatusComboBox.SelectedIndex= 0;
                
                accountTypeComboBox.Items.Add("Select...");
                accountTypeComboBox.Items.Add("Administrator");
                accountTypeComboBox.Items.Add("Cashier1");
                accountTypeComboBox.Items.Add("Cashier2");
                accountTypeComboBox.Items.Add("HR Staff");
                accountTypeComboBox.Items.Add("Accounting Staff");
                accountTypeComboBox.Items.Add("IT Staff");
                accountTypeComboBox.SelectedIndex = 0;

                firstnameTxtbox.Enabled = false;
                middlenameTxtbox.Enabled = false;
                surnameTxtbox.Enabled = false;
                designationTxtbox.Enabled = false;
                picpathTxtbox.Enabled = false;
                picpathTxtbox.Visible = false;

                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath FROM pos_empRegTbl WHERE emp_id = '" + emp_idTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                firstnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
                middlenameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
                designationTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
                picpathTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();

                // Load picture
                if (File.Exists(picpathTxtbox.Text))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void SearchforUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = '" + userIDTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                firstnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][1].ToString();
                middlenameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][3].ToString();
                designationTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][4].ToString();
                picpathTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][5].ToString();

                if (File.Exists(picpathTxtbox.Text))
                {
                    pictureBox1.Image = Image.FromFile(picpathTxtbox.Text);
                }

                usernameTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][7].ToString();
                passwordTxtbox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][8].ToString();
                accountstatusComboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][9].ToString();
                accountTypeComboBox.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0][10].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // Simple check: make sure user ID is a number
                int userId;
                if (!int.TryParse(userIDTxtbox.Text, out userId))
                {
                    MessageBox.Show("Please enter a valid User ID number!");
                    return;
                }

                // Check if passwords match
                if (passwordTxtbox.Text != confirmPasswordTxtbox.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }

                // FIXED: Removed quotes around user_id because it's a number in the database
                useraccount_db_connect.useraccount_sql = "UPDATE useraccountTbl SET account_type = '" + accountTypeComboBox.Text + "', username = '" + usernameTxtbox.Text + "', password = '" + passwordTxtbox.Text + "', confirm_password = '" + confirmPasswordTxtbox.Text + "', user_status = '" + accountstatusComboBox.Text + "' WHERE user_id = " + userIDTxtbox.Text;

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterUpdate();

                MessageBox.Show("Update successful!");

                // Refresh the table
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "DELETE FROM useraccountTbl WHERE user_id = '" + userIDTxtbox.Text + "'";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterDelete();

                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id) VALUES ('" + userIDTxtbox.Text + "', '" + accountTypeComboBox.Text + "', '" + usernameTxtbox.Text + "', '" + passwordTxtbox.Text + "', '" + confirmPasswordTxtbox.Text + "', '" + accountstatusComboBox.Text + "', '" + emp_idTxtbox.Text + "')";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterInsert();

                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("There is an error in this area. Please contact your administrator!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cleartextboxes();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
