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
    public partial class MainFrm_Database : Form
    {
        public MainFrm_Database()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            // Set the form to full screen
            this.WindowState = FormWindowState.Maximized;

        }

        private void pOSCasierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void jeePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS2_DataBase cashier1 = new POS2_DataBase();
            cashier1.MdiParent = this;
            cashier1.StartPosition = FormStartPosition.CenterParent;
            cashier1.WindowState = FormWindowState.Maximized;
            cashier1.Show();
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS1_DataBase cashier2 = new POS1_DataBase();
            cashier2.MdiParent = this;
            cashier2.StartPosition = FormStartPosition.CenterParent;
            cashier2.WindowState = FormWindowState.Maximized;
            cashier2.Show();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm1 login = new LoginFrm1();
            login.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void pOSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Admin pos_admin = new POS_Admin();
            pos_admin.MdiParent = this;
            pos_admin.StartPosition = FormStartPosition.CenterParent;
            pos_admin.WindowState = FormWindowState.Maximized;
            pos_admin.Show();
        }

        private void payrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payrol_Database payrol = new Payrol_Database();
            payrol.MdiParent = this;
            payrol.StartPosition = FormStartPosition.CenterParent;
            payrol.WindowState = FormWindowState.Maximized;
            payrol.Show();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_registration employee_Registration = new employee_registration();
            employee_Registration.MdiParent = this;
            employee_Registration.StartPosition = FormStartPosition.CenterParent;
            employee_Registration.WindowState = FormWindowState.Maximized;
            employee_Registration.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_accounts user_Accounts = new user_accounts();
            user_Accounts.MdiParent = this;
            user_Accounts.StartPosition = FormStartPosition.CenterParent;
            user_Accounts.WindowState = FormWindowState.Maximized;
            user_Accounts.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee_reports employee_Reports = new employee_reports();
            employee_Reports.MdiParent = this;
            employee_Reports.StartPosition = FormStartPosition.CenterParent;
            employee_Reports.WindowState = FormWindowState.Maximized;
            employee_Reports.Show();
        }

        private void payrolReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payrol_reports payrol_Reports = new payrol_reports();
            payrol_Reports.MdiParent = this;
            payrol_Reports.StartPosition = FormStartPosition.CenterParent;
            payrol_Reports.WindowState = FormWindowState.Maximized;
            payrol_Reports.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_reports sales_Reports = new sales_reports();
            sales_Reports.MdiParent = this;
            sales_Reports.StartPosition = FormStartPosition.CenterParent;
            sales_Reports.WindowState = FormWindowState.Maximized;
            sales_Reports.Show();
        }

        private void userAccountReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            useraccount_report useraccount_Report = new useraccount_report();
            useraccount_Report.MdiParent = this;
            useraccount_Report.StartPosition = FormStartPosition.CenterParent;
            useraccount_Report.WindowState = FormWindowState.Maximized;
            useraccount_Report.Show();
        }
    }
}