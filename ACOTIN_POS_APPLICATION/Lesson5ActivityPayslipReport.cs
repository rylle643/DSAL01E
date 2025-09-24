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
    public partial class Lesson5ActivityPayslipReport : Form
    {
        public Lesson5ActivityPayslipReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lesson5ActivityPayslipReport_Load(object sender, EventArgs e)
        {
            EmployeeNumTxt.Enabled = false;
            SurnameTxt.Enabled = false;
            FirstNameTxt.Enabled = false;
            MiddleNameTxt.Enabled = false;
            DepartmentTxt.Enabled= false;
            textBox1.Enabled = false;
            PaydateTxt.Enabled = false;
            BasicNoofHoursTxt.Enabled = false;
            BasicIncomeTxt.Enabled = false;
            BasicRateHourTxt.Enabled = false;
            OtherNoofHoursTxt.Enabled = false;
            OtherIncomeTxt.Enabled = false;
            OtherRateHourTxt.Enabled = false;
            HonorariumNoofHoursTxt.Enabled = false;
            HonorariumIncomeTxt.Enabled = false;
            HonorariumRateHourTxt.Enabled = false;
            textBox2.Enabled = false;
            textBox2.Text = "0.00";
            textBox9.Enabled = false;
            textBox9.Text = "0.00";
            textBox6.Enabled = false;
            textBox6.Text = "0.00";
            textBox3.Enabled = false;
            textBox3.Text = "0.00";
            textBox10.Enabled = false;
            textBox10.Text = "0.00";
            textBox7.Enabled = false;
            textBox7.Text = "0.00";
            textBox4.Enabled = false;
            textBox4.Text = "0.00";
            textBox11.Enabled = false;
            textBox11.Text = "0.00";
            textBox8.Enabled = false;
            textBox8.Text = "0.00";
            textBox12.Enabled = false;
            TotalDeductionTxt.Enabled = false;
            IncomeTaxTxt.Enabled = false;
            SSSContributionTxt.Enabled = false;
            PagibigContributionsTxt.Enabled = false;
            PhilhealthContributionsTxt.Enabled = false;

            SSSLoanTxt.Text = "750.00";
            SSSLoanTxt.Enabled = false;

            textBox13.Text = "Lyceum of the Philippines University - Cavite";
            textBox13.Enabled = false;

            GrossIncomeTxt.Enabled = false;
            textBox5.Enabled = false;
            NetIncomeTxt.Enabled = false;
        }
    }
}
