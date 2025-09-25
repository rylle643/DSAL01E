using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACOTIN_POS_APPLICATION
{
    public partial class Lesson5Activity : Form
    {
        public Lesson5Activity()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Lesson5Activity_Load(object sender, EventArgs e)
        {
            BasicIncomeTxt.Enabled = false;
            HonorariumIncomeTxt.Enabled = false;
            OtherIncomeTxt.Enabled = false;
            GrossIncomeTxt.Enabled = false;
            NetIncomeTxt.Enabled = false;
            TotalDeductionTxt.Enabled = false;
            SSSContributionTxt.Enabled = false;
            PhilhealthContributionsTxt.Enabled = false;
            PagibigContributionsTxt.Enabled = false;
            IncomeTaxTxt.Enabled = false;
        }

        // GROSS INCOME Button Click (button1_Click) - SIMPLE VERSION
        private void button1_Click(object sender, EventArgs e)
        {
            // Basic Income
            BasicIncomeTxt.Text = (Convert.ToDecimal(BasicRateHourTxt.Text) * Convert.ToDecimal(BasicNoofHoursTxt.Text)).ToString();

            // Honorarium Income
            HonorariumIncomeTxt.Text = (Convert.ToDecimal(HonorariumRateHourTxt.Text) * Convert.ToDecimal(HonorariumNoofHoursTxt.Text)).ToString();

            // Other Income
            OtherIncomeTxt.Text = (Convert.ToDecimal(OtherRateHourTxt.Text) * Convert.ToDecimal(OtherNoofHoursTxt.Text)).ToString();

            // Gross Income
            GrossIncomeTxt.Text = (Convert.ToDecimal(BasicIncomeTxt.Text) + Convert.ToDecimal(HonorariumIncomeTxt.Text) + Convert.ToDecimal(OtherIncomeTxt.Text)).ToString();

            // SSS Contribution (Divided by 2)
            decimal grossAmount = Convert.ToDecimal(GrossIncomeTxt.Text);
            decimal sssAmount = 0;

            if (grossAmount < 10700)
                sssAmount = ((grossAmount * 0.15m) + 10) / 2;
            else
                sssAmount = ((grossAmount * 0.15m) + 30) / 2;

            SSSContributionTxt.Text = sssAmount.ToString();

            // PhilHealth Contribution (Divided by 2)
            decimal monthlyGross = grossAmount * 2;
            decimal philhealthAmount = 0;

            if (monthlyGross <= 10000)
                philhealthAmount = 500 / 2;
            else if (monthlyGross <= 99999.99m)
                philhealthAmount = (monthlyGross * 0.05m) / 2;
            else
                philhealthAmount = 5000 / 2;

            PhilhealthContributionsTxt.Text = philhealthAmount.ToString();

            // Pag-IBIG Contribution (Divided by 2)
            PagibigContributionsTxt.Text = "100";

            // Income Tax (Monthly and Divided by 2)
            decimal netTaxable = grossAmount - (sssAmount + philhealthAmount + 100);
            decimal yearlyAmount = netTaxable * 12;
            decimal yearlyTax = 0;

            if (yearlyAmount <= 250000)
                yearlyTax = 0;
            else if (yearlyAmount <= 400000)
                yearlyTax = (yearlyAmount - 250000) * 0.15m;
            else if (yearlyAmount <= 800000)
                yearlyTax = 22500 + ((yearlyAmount - 400000) * 0.20m);
            else if (yearlyAmount <= 2000000)
                yearlyTax = 102500 + ((yearlyAmount - 800000) * 0.25m);
            else if (yearlyAmount <= 8000000)
                yearlyTax = 402500 + ((yearlyAmount - 2000000) * 0.30m);
            else
                yearlyTax = 2202500 + ((yearlyAmount - 8000000) * 0.35m);

            decimal monthlyTax = (yearlyTax / 12) / 2;
            IncomeTaxTxt.Text = monthlyTax.ToString();
        }

        // NET INCOME Button Click (button2_Click)
        private void button2_Click(object sender, EventArgs e)
        {
            // Calculate Total Deductions
            TotalDeductionTxt.Text = (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + Convert.ToDecimal(PagibigContributionsTxt.Text) + Convert.ToDecimal(IncomeTaxTxt.Text) + Convert.ToDecimal(SSSLoanTxt.Text) + Convert.ToDecimal(PagibigLoansTxt.Text) + Convert.ToDecimal(FacultySavingsDepositTxt.Text) + Convert.ToDecimal(FacultySavingsLoansTxt.Text) + Convert.ToDecimal(SalaryLoanTxt.Text) + Convert.ToDecimal(OtherLoanTxt.Text)).ToString();

            // Calculate Net Income
            NetIncomeTxt.Text = (Convert.ToDecimal(GrossIncomeTxt.Text) - Convert.ToDecimal(TotalDeductionTxt.Text)).ToString();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeNumTxt.Clear();
            DepartmentTxt.Clear();
            BasicRateHourTxt.Clear();
            BasicNoofHoursTxt.Clear();
            BasicIncomeTxt.Clear();
            HonorariumRateHourTxt.Clear();
            HonorariumNoofHoursTxt.Clear();
            HonorariumIncomeTxt.Clear();
            OtherRateHourTxt.Clear();
            OtherNoofHoursTxt.Clear();
            OtherIncomeTxt.Clear();
            GrossIncomeTxt.Clear();
            NetIncomeTxt.Clear();
            FirstNameTxt.Clear();
            MiddleNameTxt.Clear();
            SurnameTxt.Clear();
            CivilStatusTxt.Clear();
            QualifiedDependentsStatusTxt.Clear();
            PaydateTxt.Clear();
            EmployeeStatusTxt.Clear();
            DesignationTxt.Clear();
            SSSContributionTxt.Clear();
            PhilhealthContributionsTxt.Clear();
            PagibigContributionsTxt.Clear();
            IncomeTaxTxt.Clear();
            SSSLoanTxt.Clear();
            PagibigLoansTxt.Clear();
            FacultySavingsDepositTxt.Clear();
            FacultySavingsLoansTxt.Clear();
            SalaryLoanTxt.Clear();
            OtherLoanTxt.Clear();
            TotalDeductionTxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lesson5ActivityPayslipReport print = new Lesson5ActivityPayslipReport();

            print.EmployeeNumTxt.Text = this.EmployeeNumTxt.Text;
            print.SurnameTxt.Text = this.SurnameTxt.Text;
            print.FirstNameTxt.Text = this.FirstNameTxt.Text;
            print.MiddleNameTxt.Text = this.MiddleNameTxt.Text;
            print.DepartmentTxt.Text = this.DepartmentTxt.Text;
            print.textBox1.Text = this.PaydateTxt.Text;
            print.PaydateTxt.Text = this.PaydateTxt.Text;

            print.BasicNoofHoursTxt.Text = this.BasicNoofHoursTxt.Text;
            print.BasicRateHourTxt.Text = this.BasicRateHourTxt.Text;  
            print.BasicIncomeTxt.Text = this.BasicIncomeTxt.Text;
            print.HonorariumNoofHoursTxt.Text = this.HonorariumNoofHoursTxt.Text;
            print.HonorariumRateHourTxt.Text = this.HonorariumRateHourTxt.Text;
            print.HonorariumIncomeTxt.Text = this.HonorariumIncomeTxt.Text;
            print.OtherNoofHoursTxt.Text = this.OtherNoofHoursTxt.Text;
            print.OtherRateHourTxt.Text = this.OtherRateHourTxt.Text;
            print.OtherIncomeTxt.Text = this.OtherIncomeTxt.Text;

            print.IncomeTaxTxt.Text = this.IncomeTaxTxt.Text;
            print.SSSContributionTxt.Text = this.SSSContributionTxt.Text;
            print.PhilhealthContributionsTxt.Text = this.PhilhealthContributionsTxt.Text;
            print.PagibigContributionsTxt.Text = this.PagibigContributionsTxt.Text;

            print.textBox12.Text = this.GrossIncomeTxt.Text;
            print.TotalDeductionTxt.Text = this.TotalDeductionTxt.Text;

            print.GrossIncomeTxt.Text = this.GrossIncomeTxt.Text;
            print.textBox5.Text = this.TotalDeductionTxt.Text;
            print.NetIncomeTxt.Text = this.NetIncomeTxt.Text;

            print.Show();

        }
    }
}
