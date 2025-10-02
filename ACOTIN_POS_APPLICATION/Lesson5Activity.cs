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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Load += (s, e) =>
            {
                this.Scale(new SizeF(1.5f, 1.2f));
            };
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


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic Income
                BasicIncomeTxt.Text = (Convert.ToDecimal(BasicRateHourTxt.Text) * Convert.ToDecimal(BasicNoofHoursTxt.Text)).ToString();

                // Honorarium Income
                HonorariumIncomeTxt.Text = (Convert.ToDecimal(HonorariumRateHourTxt.Text) * Convert.ToDecimal(HonorariumNoofHoursTxt.Text)).ToString();

                // Other Income
                OtherIncomeTxt.Text = (Convert.ToDecimal(OtherRateHourTxt.Text) * Convert.ToDecimal(OtherNoofHoursTxt.Text)).ToString();

                // Gross Income
                decimal grossincome = Convert.ToDecimal(BasicIncomeTxt.Text) + Convert.ToDecimal(HonorariumIncomeTxt.Text) + Convert.ToDecimal(OtherIncomeTxt.Text);
                GrossIncomeTxt.Text = grossincome.ToString();

                // COMPUTE SSS CONTRIBUTION
                decimal sss_contrib = 0;

                if (grossincome < 5250)
                    sss_contrib = 250.00m / 2;
                else if (grossincome >= 5250 && grossincome < 5750)
                    sss_contrib = 275.00m / 2;
                else if (grossincome >= 5750 && grossincome < 6250)
                    sss_contrib = 300.00m / 2;
                else if (grossincome >= 6250 && grossincome < 6750)
                    sss_contrib = 325.00m / 2;
                else if (grossincome >= 6750 && grossincome < 7250)
                    sss_contrib = 350.00m / 2;
                else if (grossincome >= 7250 && grossincome < 7750)
                    sss_contrib = 375.00m / 2;
                else if (grossincome >= 7750 && grossincome < 8250)
                    sss_contrib = 400.00m / 2;
                else if (grossincome >= 8250 && grossincome < 8750)
                    sss_contrib = 425.00m / 2;
                else if (grossincome >= 8750 && grossincome < 9250)
                    sss_contrib = 450.00m / 2;
                else if (grossincome >= 9250 && grossincome < 9750)
                    sss_contrib = 475.00m / 2;
                else if (grossincome >= 9750 && grossincome < 10250)
                    sss_contrib = 500.00m / 2;
                else if (grossincome >= 10250 && grossincome < 10750)
                    sss_contrib = 525.00m / 2;
                else if (grossincome >= 10750 && grossincome < 11250)
                    sss_contrib = 550.00m / 2;
                else if (grossincome >= 11250 && grossincome < 11750)
                    sss_contrib = 575.00m / 2;
                else if (grossincome >= 11750 && grossincome < 12250)
                    sss_contrib = 600.00m / 2;
                else if (grossincome >= 12250 && grossincome < 12750)
                    sss_contrib = 625.00m / 2;
                else if (grossincome >= 12750 && grossincome < 13250)
                    sss_contrib = 650.00m / 2;
                else if (grossincome >= 13250 && grossincome < 13750)
                    sss_contrib = 675.00m / 2;
                else if (grossincome >= 13750 && grossincome < 14250)
                    sss_contrib = 700.00m / 2;
                else if (grossincome >= 14250 && grossincome < 14750)
                    sss_contrib = 725.00m / 2;
                else if (grossincome >= 14750 && grossincome < 15250)
                    sss_contrib = 750.00m / 2;
                else if (grossincome >= 15250 && grossincome < 15750)
                    sss_contrib = 775.00m / 2;
                else if (grossincome >= 15750 && grossincome < 16250)
                    sss_contrib = 800.00m / 2;
                else if (grossincome >= 16250 && grossincome < 16750)
                    sss_contrib = 825.00m / 2;
                else if (grossincome >= 16750 && grossincome < 17250)
                    sss_contrib = 850.00m / 2;
                else if (grossincome >= 17250 && grossincome < 17750)
                    sss_contrib = 875.00m / 2;
                else if (grossincome >= 17750 && grossincome < 18250)
                    sss_contrib = 900.00m / 2;
                else if (grossincome >= 18250 && grossincome < 18750)
                    sss_contrib = 925.00m / 2;
                else if (grossincome >= 18750 && grossincome < 19250)
                    sss_contrib = 950.00m / 2;
                else if (grossincome >= 19250 && grossincome < 19750)
                    sss_contrib = 975.00m / 2;
                else if (grossincome >= 19750 && grossincome < 20250)
                    sss_contrib = 1000.00m / 2;
                else if (grossincome >= 20250 && grossincome < 20750)
                    sss_contrib = 1025.00m / 2;
                else if (grossincome >= 20750 && grossincome < 21250)
                    sss_contrib = 1050.00m / 2;
                else if (grossincome >= 21250 && grossincome < 21750)
                    sss_contrib = 1075.00m / 2;
                else if (grossincome >= 21750 && grossincome < 22250)
                    sss_contrib = 1100.00m / 2;
                else if (grossincome >= 22250 && grossincome < 22750)
                    sss_contrib = 1125.00m / 2;
                else if (grossincome >= 22750 && grossincome < 23250)
                    sss_contrib = 1150.00m / 2;
                else if (grossincome >= 23250 && grossincome < 23750)
                    sss_contrib = 1175.00m / 2;
                else if (grossincome >= 23750 && grossincome < 24250)
                    sss_contrib = 1200.00m / 2;
                else if (grossincome >= 24250 && grossincome < 24750)
                    sss_contrib = 1225.00m / 2;
                else if (grossincome >= 24750 && grossincome < 25250)
                    sss_contrib = 1250.00m / 2;
                else if (grossincome >= 25250 && grossincome < 25750)
                    sss_contrib = 1275.00m / 2;
                else if (grossincome >= 25750 && grossincome < 26250)
                    sss_contrib = 1300.00m / 2;
                else if (grossincome >= 26250 && grossincome < 26750)
                    sss_contrib = 1325.00m / 2;
                else if (grossincome >= 26750 && grossincome < 27250)
                    sss_contrib = 1350.00m / 2;
                else if (grossincome >= 27250 && grossincome < 27750)
                    sss_contrib = 1375.00m / 2;
                else if (grossincome >= 27750 && grossincome < 28250)
                    sss_contrib = 1400.00m / 2;
                else if (grossincome >= 28250 && grossincome < 28750)
                    sss_contrib = 1425.00m / 2;
                else if (grossincome >= 28750 && grossincome < 29250)
                    sss_contrib = 1450.00m / 2;
                else if (grossincome >= 29250 && grossincome < 29750)
                    sss_contrib = 1475.00m / 2;
                else if (grossincome >= 29750 && grossincome < 30250)
                    sss_contrib = 1500.00m / 2;
                else if (grossincome >= 30250 && grossincome < 30750)
                    sss_contrib = 1525.00m / 2;
                else if (grossincome >= 30750 && grossincome < 31250)
                    sss_contrib = 1550.00m / 2;
                else if (grossincome >= 31250 && grossincome < 31750)
                    sss_contrib = 1575.00m / 2;
                else if (grossincome >= 31750 && grossincome < 32250)
                    sss_contrib = 1600.00m / 2;
                else if (grossincome >= 32250 && grossincome < 32750)
                    sss_contrib = 1625.00m / 2;
                else if (grossincome >= 32750 && grossincome < 33250)
                    sss_contrib = 1650.00m / 2;
                else if (grossincome >= 33250 && grossincome < 33750)
                    sss_contrib = 1675.00m / 2;
                else if (grossincome >= 33750 && grossincome < 34250)
                    sss_contrib = 1700.00m / 2;
                else if (grossincome >= 34250 && grossincome < 34750)
                    sss_contrib = 1725.00m / 2;
                else if (grossincome >= 34750)
                    sss_contrib = 1750.00m / 2;

                SSSContributionTxt.Text = sss_contrib.ToString();

                // Pag-IBIG Contribution (200.00)
                decimal pagibig_contrib = 200.00m;
                PagibigContributionsTxt.Text = pagibig_contrib.ToString();

                // PhilHealth Contribution (2.5% of gross income)
                decimal philhealth_contrib = grossincome * 0.025m;
                PhilhealthContributionsTxt.Text = philhealth_contrib.ToString();

                // COMPUTE MONTHLY TAXABLE INCOME FIRST
                decimal monthly_taxable_income = grossincome - sss_contrib - philhealth_contrib - pagibig_contrib;
                decimal tax_contrib = 0;

                if (monthly_taxable_income <= 20833)
                    tax_contrib = 0.00m;
                else if (monthly_taxable_income > 20833 && monthly_taxable_income <= 33333)
                    tax_contrib = (monthly_taxable_income - 20833) * 0.15m;
                else if (monthly_taxable_income > 33333 && monthly_taxable_income <= 66667)
                    tax_contrib = 1875 + ((monthly_taxable_income - 33333) * 0.20m);
                else if (monthly_taxable_income > 66667 && monthly_taxable_income <= 166667)
                    tax_contrib = 8541.80m + ((monthly_taxable_income - 66667) * 0.25m);
                else if (monthly_taxable_income > 166667 && monthly_taxable_income <= 666667)
                    tax_contrib = 33541.80m + ((monthly_taxable_income - 166667) * 0.30m);
                else if (monthly_taxable_income > 666667)
                    tax_contrib = 183541.80m + ((monthly_taxable_income - 666667) * 0.35m);

                // DIVIDE TAX CONTRIBUTION BY 2 FOR SEMI-MONTHLY
                tax_contrib = tax_contrib / 2;

                IncomeTaxTxt.Text = tax_contrib.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check rate and hours entries.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate Total Deductions
                TotalDeductionTxt.Text = (Convert.ToDecimal(SSSContributionTxt.Text) + Convert.ToDecimal(PhilhealthContributionsTxt.Text) + Convert.ToDecimal(PagibigContributionsTxt.Text) + Convert.ToDecimal(IncomeTaxTxt.Text) + Convert.ToDecimal(SSSLoanTxt.Text) + Convert.ToDecimal(PagibigLoansTxt.Text) + Convert.ToDecimal(FacultySavingsDepositTxt.Text) + Convert.ToDecimal(FacultySavingsLoansTxt.Text) + Convert.ToDecimal(SalaryLoanTxt.Text) + Convert.ToDecimal(OtherLoanTxt.Text)).ToString();

                // Calculate Net Income
                NetIncomeTxt.Text = (Convert.ToDecimal(GrossIncomeTxt.Text) - Convert.ToDecimal(TotalDeductionTxt.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please compute income first and check loan entries.", "Error");
            }
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error opening payslip report.", "Error");
            }
        }

        private void BasicRateHourTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}