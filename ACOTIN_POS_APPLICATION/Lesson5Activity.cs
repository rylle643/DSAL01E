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

        private void button2_Click(object sender, EventArgs e)
        {
            // Total Deductions
            TotalDeductionTxt.Text = (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + Convert.ToDecimal(PagibigContributionsTxt.Text) + Convert.ToDecimal(IncomeTaxTxt.Text) + Convert.ToDecimal(SSSLoanTxt.Text) + Convert.ToDecimal(PagibigLoansTxt.Text) + Convert.ToDecimal(FacultySavingsDepositTxt.Text) + Convert.ToDecimal(FacultySavingsLoansTxt.Text) + Convert.ToDecimal(SalaryLoanTxt.Text) + Convert.ToDecimal(OtherLoanTxt.Text)).ToString("0.00");

            // Calculate Net Income
            NetIncomeTxt.Text = (Convert.ToDecimal(GrossIncomeTxt.Text) - Convert.ToDecimal(TotalDeductionTxt.Text)).ToString("0.00");
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Basic Income
            BasicIncomeTxt.Text = (Convert.ToDecimal(BasicRateHourTxt.Text) * Convert.ToDecimal(BasicNoofHoursTxt.Text)).ToString("0.00");

            // Honorarium Income
            HonorariumIncomeTxt.Text = (Convert.ToDecimal(HonorariumRateHourTxt.Text) * Convert.ToDecimal(HonorariumNoofHoursTxt.Text)).ToString("0.00");

            // Other Income
            OtherIncomeTxt.Text = (Convert.ToDecimal(OtherRateHourTxt.Text) * Convert.ToDecimal(OtherNoofHoursTxt.Text)).ToString("0.00");

            // Gross Income
            GrossIncomeTxt.Text = (Convert.ToDecimal(BasicIncomeTxt.Text) + Convert.ToDecimal(HonorariumIncomeTxt.Text) + Convert.ToDecimal(OtherIncomeTxt.Text)).ToString("0.00");

            // SSS Contribution
            if (Convert.ToDecimal(GrossIncomeTxt.Text) < 10700)
                SSSContributionTxt.Text = ((Convert.ToDecimal(GrossIncomeTxt.Text) * 0.15m) + 10).ToString("0.00");
            else
                SSSContributionTxt.Text = ((Convert.ToDecimal(GrossIncomeTxt.Text) * 0.15m) + 30).ToString("0.00");

            // PhilHealth Contribution
            if ((Convert.ToDecimal(GrossIncomeTxt.Text) * 2) <= 10000)
                PhilhealthContributionsTxt.Text = "500.00";
            else if ((Convert.ToDecimal(GrossIncomeTxt.Text) * 2) >= 10000.01m && (Convert.ToDecimal(GrossIncomeTxt.Text) * 2) <= 99999.99m)
                PhilhealthContributionsTxt.Text = ((Convert.ToDecimal(GrossIncomeTxt.Text) * 2) * 0.05m).ToString("0.00");
            else if ((Convert.ToDecimal(GrossIncomeTxt.Text) * 2) >= 100000)
                PhilhealthContributionsTxt.Text = "5000.00";

            // Pag-IBIG Contribution
            PagibigContributionsTxt.Text = "200.00";

            // Income Tax
            if (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) <= 250000)
                IncomeTaxTxt.Text = "0.00";
            else if (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) > 250000 && ((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) <= 400000)
                IncomeTaxTxt.Text = (((((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) - 250000) * 0.15m) / 24).ToString("0.00");
            else if (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) > 400000 && ((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) <= 800000)
                IncomeTaxTxt.Text = (((22500 + (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) - 400000) * 0.20m)) / 24).ToString("0.00");
            else if (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) > 800000 && ((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) <= 2000000)
                IncomeTaxTxt.Text = (((102500 + (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) - 800000) * 0.25m)) / 24).ToString("0.00");
            else if (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) > 2000000 && ((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) <= 8000000)
                IncomeTaxTxt.Text = (((402500 + (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) - 2000000) * 0.30m)) / 24).ToString("0.00");
            else
                IncomeTaxTxt.Text = (((2202500 + (((Convert.ToDecimal(GrossIncomeTxt.Text) - (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + 200)) * 24) - 8000000) * 0.35m)) / 24).ToString("0.00");
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
