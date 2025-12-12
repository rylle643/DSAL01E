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
        public LoginFrm_Database()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginFrm1_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
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
                Activity2 cashierfrm = new Activity2();
                cashierfrm.Show();
                UsernameTxt.Clear();
                PasswordTxt.Clear();
            }
            else if (UsernameTxt.Text == "Cashier1" && PasswordTxt.Text == "22222")
            {
                MessageBox.Show("Welcome Cashier Ordering POS Page!");
                Activity4 cashier1frm = new Activity4();
                cashier1frm.Show();
                UsernameTxt.Clear();
                PasswordTxt.Clear();
            }
            else if (UsernameTxt.Text == "Payroll" && PasswordTxt.Text == "11111")
            {
                MessageBox.Show("Welcome Payroll Page!");
                Lesson5Activity payrollfrm = new Lesson5Activity();
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
