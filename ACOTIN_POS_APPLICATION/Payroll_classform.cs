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
    public partial class Payroll_Functions : Form
    {
        PayrollVariables data = new PayrollVariables();
        PayrollCalculator calc = new PayrollCalculator();

        public Payroll_Functions()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
                // Income Computation
                data.basicIncome = calc.ComputeBasicIncome(Convert.ToDecimal(BasicRateHourTxt.Text),Convert.ToDecimal(BasicNoofHoursTxt.Text));

                data.honorariumIncome = calc.ComputeBasicIncome(Convert.ToDecimal(HonorariumRateHourTxt.Text),Convert.ToDecimal(HonorariumNoofHoursTxt.Text));

                data.otherIncome = calc.ComputeBasicIncome(Convert.ToDecimal(OtherRateHourTxt.Text),Convert.ToDecimal(OtherNoofHoursTxt.Text));

                BasicIncomeTxt.Text = data.basicIncome.ToString("n2");
                HonorariumIncomeTxt.Text = data.honorariumIncome.ToString("n2");
                OtherIncomeTxt.Text = data.otherIncome.ToString("n2");

                data.grossIncome = calc.ComputeGrossIncome(data.basicIncome,data.honorariumIncome,data.otherIncome);
                GrossIncomeTxt.Text = data.grossIncome.ToString("n2");

                // Contributions
                data.sssContribution = calc.ComputeSSS(data.grossIncome);
                data.pagibigContribution = calc.ComputePagibig();
                data.philhealthContribution = calc.ComputePhilHealth(data.grossIncome);

                SSSContributionTxt.Text = data.sssContribution.ToString("n2");
                PagibigContributionsTxt.Text = data.pagibigContribution.ToString("n2");
                PhilhealthContributionsTxt.Text = data.philhealthContribution.ToString("n2");

                // Tax
                decimal taxable = data.grossIncome - (data.sssContribution + data.pagibigContribution + data.philhealthContribution);
                data.incomeTax = calc.ComputeTax(taxable);
                IncomeTaxTxt.Text = data.incomeTax.ToString("n2");
            }
            catch
            {
                MessageBox.Show("Invalid input. Please check rate and hours entries.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get loan values
                data.sssLoan = Convert.ToDecimal(SSSLoanTxt.Text);
                data.pagibigLoan = Convert.ToDecimal(PagibigLoansTxt.Text);
                data.facultySavingsDeposit = Convert.ToDecimal(FacultySavingsDepositTxt.Text);
                data.facultySavingsLoan = Convert.ToDecimal(FacultySavingsLoansTxt.Text);
                data.salaryLoan = Convert.ToDecimal(SalaryLoanTxt.Text);
                data.otherLoan = Convert.ToDecimal(OtherLoanTxt.Text);

                // Calculate Total Deductions
                data.totalDeduction = calc.ComputeTotalDeduction(data);
                TotalDeductionTxt.Text = data.totalDeduction.ToString("n2");

                // Calculate Net Income
                data.netIncome = calc.ComputeNetIncome(data.grossIncome, data.totalDeduction);
                NetIncomeTxt.Text = data.netIncome.ToString("n2");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input. Please compute income first and check loan entries.", "Error");
            }
        }

        private void ClearAllTextboxes()
        {
            BasicRateHourTxt.Clear();
            BasicNoofHoursTxt.Clear();
            HonorariumRateHourTxt.Clear();
            HonorariumNoofHoursTxt.Clear();
            OtherRateHourTxt.Clear();
            OtherNoofHoursTxt.Clear();
            BasicIncomeTxt.Clear();
            HonorariumIncomeTxt.Clear();
            OtherIncomeTxt.Clear();
            GrossIncomeTxt.Clear();
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
            NetIncomeTxt.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearAllTextboxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double totalDeduction = 0;
                double.TryParse(this.TotalDeductionTxt.Text, out totalDeduction);

                totalDeduction += 750;
                this.TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                Lesson5ActivityPayslipReport print = new Lesson5ActivityPayslipReport();

                print.EmployeeNumTxt.Text = this.EmployeeNumTxt.Text;
                print.SurnameTxt.Text = this.SurnameTxt.Text;
                print.FirstNameTxt.Text = this.FirstNameTxt.Text;
                print.MiddleNameTxt.Text = this.MiddleNameTxt.Text;
                print.DepartmentTxt.Text = this.DepartmentTxt.Text;
                print.textBox1.Text = this.PaydateTxt.Text;
                print.PaydateTxt.Text = this.PaydateTxt.Text;

                print.BasicNoofHoursTxt.Text = this.BasicNoofHoursTxt.Text;
                print.HonorariumNoofHoursTxt.Text = this.HonorariumNoofHoursTxt.Text;
                print.OtherNoofHoursTxt.Text = this.OtherNoofHoursTxt.Text;

                print.IncomeTaxTxt.Text = this.IncomeTaxTxt.Text;
                print.SSSContributionTxt.Text = this.SSSContributionTxt.Text;
                print.PhilhealthContributionsTxt.Text = this.PhilhealthContributionsTxt.Text;
                print.PagibigContributionsTxt.Text = this.PagibigContributionsTxt.Text;

                print.textBox12.Text = this.GrossIncomeTxt.Text;
                print.TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                print.GrossIncomeTxt.Text = this.GrossIncomeTxt.Text;
                print.textBox5.Text = totalDeduction.ToString("0.00");
                print.NetIncomeTxt.Text = this.NetIncomeTxt.Text;

                print.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening payslip report.", "Error");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label27_Click(object sender, EventArgs e) { }
        private void label26_Click(object sender, EventArgs e) { }
        private void label32_Click(object sender, EventArgs e) { }
        private void label30_Click(object sender, EventArgs e) { }
        private void label31_Click(object sender, EventArgs e) { }
        private void label29_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void label23_Click(object sender, EventArgs e) { }
        private void BasicRateHourTxt_TextChanged(object sender, EventArgs e) { }
        private void EmployeeNumTxt_TextChanged(object sender, EventArgs e) { }
        private void DepartmentTxt_TextChanged(object sender, EventArgs e) { }
    }
}