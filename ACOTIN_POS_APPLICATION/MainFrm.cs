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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            // Set the form to full screen
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pOSCasierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void jeePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 cashier1 = new Activity2();
            cashier1.MdiParent = this;
            cashier1.StartPosition = FormStartPosition.CenterParent;
            cashier1.WindowState = FormWindowState.Maximized;
            cashier1.Show();
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 cashier2 = new Activity4();
            cashier2.MdiParent = this;
            cashier2.StartPosition = FormStartPosition.CenterParent;
            cashier2.WindowState = FormWindowState.Maximized;
            cashier2.Show();
        }

        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5Activity payrol = new Lesson5Activity();
            payrol.MdiParent = this;
            payrol.StartPosition = FormStartPosition.CenterParent;
            payrol.WindowState = FormWindowState.Maximized;
            payrol.Show();
        }

        private void jeePOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity1 admin = new Activity1();
            admin.MdiParent = this;
            admin.StartPosition = FormStartPosition.CenterParent;
            admin.WindowState = FormWindowState.Maximized;
            admin.Show();
        }

        private void jeePOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity3 ordering = new Activity3();
            ordering.MdiParent = this;
            ordering.StartPosition = FormStartPosition.CenterParent;
            ordering.WindowState = FormWindowState.Maximized;
            ordering.Show();
        }

        private void payrolReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5ActivityPayslipReport payslipreport = new Lesson5ActivityPayslipReport();
            payslipreport.MdiParent = this;
            payslipreport.StartPosition = FormStartPosition.CenterParent;
            payslipreport.WindowState = FormWindowState.Maximized;
            payslipreport.Show();
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enrollment enrollment = new Enrollment();
            enrollment.MdiParent = this;
            enrollment.StartPosition = FormStartPosition.CenterParent;
            enrollment.WindowState = FormWindowState.Maximized;
            enrollment.Show();
        }
    }
}