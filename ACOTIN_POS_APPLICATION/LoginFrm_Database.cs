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
    public partial class LoginFrm_Database : Form
    {
        private String username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnections login_db_connect = new loginDb_dbconnections();
        public LoginFrm_Database()
        {
            InitializeComponent();
            login_db_connect.login_connString();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginFrm1_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cleartextboxes()
        {
            UsernameTxt.Clear();
            UsernameTxt.Focus();
            PasswordTxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                login_db_connect.login_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE username = '" + UsernameTxt.Text + "' AND password = '" + PasswordTxt.Text + "'";
                login_db_connect.login_cmd();
                login_db_connect.login_sqladapterSelect();
                login_db_connect.login_sqldatasetSELECT();

                // Check if any rows were returned
                if (login_db_connect.login_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    string username1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][3].ToString();
                    string password1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][4].ToString();
                    string user_level = login_db_connect.login_sql_dataset.Tables[0].Rows[0][5].ToString();

                    if ((username1 == UsernameTxt.Text) && (password1 == PasswordTxt.Text))
                    {
                        if (user_level == "Administrator")
                        {
                            MessageBox.Show("Access granted");
                            MainFrm_Database myform = new MainFrm_Database();
                            myform.Show();
                            cleartextboxes();
                            this.Hide();
                        }
                        else if (user_level == "Cashier1")
                        {
                            MessageBox.Show("Access granted");
                            POS2_DataBase myform = new POS2_DataBase();
                            cleartextboxes();
                            myform.Show();
                            this.Hide();
                        }
                        else if (user_level == "Cashier2")
                        {
                            MessageBox.Show("Access granted");
                            POS1_DataBase myform = new POS1_DataBase();
                            myform.terminal_nolabel.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][6].ToString();
                            myform.emp_idLabel.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][0].ToString();
                            myform.emp_fnameLabel.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][1].ToString();
                            myform.emp_surnameLabel.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][2].ToString();
                            DateTime dateTime = DateTime.Now;
                            myform.time_dateLabel.Text = dateTime.ToString("MMMM dd, yyyy");
                            cleartextboxes();
                            myform.Show();
                            this.Hide();
                        }
                        else if (user_level == "HR Staff")
                        {
                            MessageBox.Show("Access granted");
                            employee_registration myform = new employee_registration();
                            myform.DeleteButton.Enabled = false;
                            cleartextboxes();
                            myform.Show();
                            this.Hide();
                        }
                        else if (user_level == "Accounting Staff")
                        {
                            MessageBox.Show("Access granted");
                            Payrol_Database myform = new Payrol_Database();
                            myform.Search_EditButton.Hide();
                            myform.EDITbutton.Hide();
                            myform.DELETEbutton.Hide();
                            cleartextboxes();
                            myform.Show();
                            this.Hide();
                        }
                        else if (user_level == "IT Staff")
                        {
                            MessageBox.Show("Access granted");
                            user_accounts myform = new user_accounts();
                            myform.SearchforUpdate.Hide();
                            myform.UpdateBTN.Hide();
                            myform.Delete.Hide();
                            cleartextboxes();
                            myform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Access Denied");
                            cleartextboxes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Access Denied");
                        cleartextboxes();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    cleartextboxes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please contact your administrator");
                cleartextboxes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2dqf_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
