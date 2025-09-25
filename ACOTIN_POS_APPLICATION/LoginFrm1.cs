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
    public partial class LoginFrm1 : Form
    {
        public LoginFrm1()
        {
            InitializeComponent();
        }

        private void LoginFrm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (UsernameTxt.Text == "admin" && PasswordTxt.Text == "rylle")
            {
                MessageBox.Show("Welcome Admin Page!");
                MainFrm adminfrm = new MainFrm();
                adminfrm.Show();
                this.Hide();
            }
            else if (UsernameTxt.Text == "Cashier" && PasswordTxt.Text == "12345")
            {
                MessageBox.Show("Welcome Cashier Point of Sale Page!");
                MainFrm cashierfrm = new MainFrm();
                cashierfrm.Show();
                UsernameTxt.Clear();
                PasswordTxt.Clear();
            }
            else if (UsernameTxt.Text == "Cashier1" && PasswordTxt.Text == "22222")
            {
                MessageBox.Show("Welcome Cashier Ordering POS Page!");
                MainFrm cashier1frm = new MainFrm();
                cashier1frm.Show();
                UsernameTxt.Clear();
                PasswordTxt.Clear();
            }
            else if (UsernameTxt.Text == "Payroll" && PasswordTxt.Text == "11111")
            {
                MessageBox.Show("Welcome Payroll Page!");
                MainFrm payrollfrm = new MainFrm();
                payrollfrm.Show();
                UsernameTxt.Clear();
                PasswordTxt.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password! Please try again.");
                UsernameTxt.Clear();
                PasswordTxt.Clear();
                UsernameTxt.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
