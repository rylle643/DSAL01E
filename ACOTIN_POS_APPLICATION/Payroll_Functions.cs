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
        public Payroll_Functions()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

 
        }

        private decimal ComputeSSS(decimal grossIncome)
        {
            decimal sss_contrib;

            if (grossIncome < 5250)
                sss_contrib = 250.00m / 2;
            else
            {
                int bracket = (int)((grossIncome - 5250) / 500) + 1;
                decimal contribution = 250.00m + (bracket * 25.00m);
                sss_contrib = contribution / 2;
            }

            SSSContributionTxt.Text = sss_contrib.ToString();
            return sss_contrib;
        }

        private decimal ComputePagibig() => 200.00m;

        private decimal ComputePhilHealth(decimal grossIncome) => grossIncome * 0.025m;

        private decimal ComputeTax(decimal monthlyTaxable)
        {
            if (monthlyTaxable <= 20833) return 0;
            if (monthlyTaxable <= 33333) return (monthlyTaxable - 20833) * 0.15m;
            if (monthlyTaxable <= 66667) return 1875 + (monthlyTaxable - 33333) * 0.20m;
            if (monthlyTaxable <= 166667) return 8541.80m + (monthlyTaxable - 66667) * 0.25m;
            if (monthlyTaxable <= 666667) return 33541.80m + (monthlyTaxable - 166667) * 0.30m;
            return 183541.80m + (monthlyTaxable - 666667) * 0.35m;
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
                // Income Computation
                decimal basicIncome = Convert.ToDecimal(BasicRateHourTxt.Text) * Convert.ToDecimal(BasicNoofHoursTxt.Text);
                decimal honorIncome = Convert.ToDecimal(HonorariumRateHourTxt.Text) * Convert.ToDecimal(HonorariumNoofHoursTxt.Text);
                decimal otherIncome = Convert.ToDecimal(OtherRateHourTxt.Text) * Convert.ToDecimal(OtherNoofHoursTxt.Text);

                BasicIncomeTxt.Text = basicIncome.ToString("n2");
                HonorariumIncomeTxt.Text = honorIncome.ToString("n2");
                OtherIncomeTxt.Text = otherIncome.ToString("n2");

                decimal grossIncome = basicIncome + honorIncome + otherIncome;
                GrossIncomeTxt.Text = grossIncome.ToString("n2");

                // Contributions
                decimal sss = ComputeSSS(grossIncome);
                decimal pagibig = ComputePagibig();
                decimal philHealth = ComputePhilHealth(grossIncome);

                SSSContributionTxt.Text = sss.ToString("n2");
                PagibigContributionsTxt.Text = pagibig.ToString("n2");
                PhilhealthContributionsTxt.Text = philHealth.ToString("n2");

                // Tax
                decimal taxable = grossIncome - (sss + pagibig + philHealth);
                decimal tax = ComputeTax(taxable) / 2; // semi-monthly
                IncomeTaxTxt.Text = tax.ToString("n2");
                
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

        private void ClearAllTextboxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                    txt.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearAllTextboxes();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert current total deduction text to double
                double totalDeduction = 0;
                double.TryParse(this.TotalDeductionTxt.Text, out totalDeduction);

                // Add ₱750 (SSS Loan)
                totalDeduction += 750;

                // Update the textbox in this form
                this.TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                // Create the print form
                Lesson5ActivityPayslipReport print = new Lesson5ActivityPayslipReport();

                // Transfer all text values
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

                // Updated total deduction (with +750)
                print.textBox12.Text = this.GrossIncomeTxt.Text;
                print.TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                print.GrossIncomeTxt.Text = this.GrossIncomeTxt.Text;
                print.textBox5.Text = totalDeduction.ToString("0.00");
                print.NetIncomeTxt.Text = this.NetIncomeTxt.Text;

                // Show print form
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

        private void EmployeeNumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}