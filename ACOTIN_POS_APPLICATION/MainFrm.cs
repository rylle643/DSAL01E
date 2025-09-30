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
        }

        private void pOSCasierToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void jeePOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity2 cashier1 = new Activity2();
            cashier1.MdiParent = this; 
            cashier1.Show();
        }

        private void jeePOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activity4 cashier2 = new Activity4();
            cashier2.MdiParent = this; 
            cashier2.Show();
        }

        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5Activity payrol = new Lesson5Activity();
            payrol.MdiParent = this; 
            payrol.Show();
        }

        private void jeePOSIncToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity1 admin = new Activity1();
            admin.MdiParent = this; 
            admin.Show();
        }

        private void jeePOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Activity3 ordering = new Activity3();
            ordering.MdiParent = this;
            ordering.Show();
        }

        private void payrolReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lesson5ActivityPayslipReport payslipreport = new Lesson5ActivityPayslipReport();
            payslipreport.MdiParent = this;
            payslipreport.Show();
        }

        private void userAccountPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            enrollment.Show();
        }
    }
}
