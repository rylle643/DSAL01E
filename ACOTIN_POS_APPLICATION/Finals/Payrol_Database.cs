using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACOTIN_POS_APPLICATION
{
    public partial class Payrol_Database : Form
    {
        public Payrol_Database()
        {
            payrol_dbconnection db = new payrol_dbconnection();
            db.payrol_connString();
            InitializeComponent();
            
        }

        private void cleartexeboxes()
        {
            empNumberTxtBox.Clear();
            firstnameTxtbox.Clear();
            MNameTxtbox.Clear();
            surnameTxtBox.Clear();
            civilStatusTxtBox.Clear();
            designationTxtBox.Clear();
            numDependentsTxtBox.Clear();
            emp_statusTxtbox.Clear();
            departmentTxtBox.Clear();
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

            others_loanCombo.Text = "Select other loan";
            payslip_viewListBox.Items.Clear();

            pictureBox1.Image = Properties.Resources.no_image;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void EDITbutton_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
                payrol_db_connect.payrol_connString();

                payrol_db_connect.payrol_sql = "UPDATE payrolTbl SET basic_rate_hr = '" + BasicRateHourTxt.Text + "', basic_no_of_hrs_cutOff = '" + BasicNoofHoursTxt.Text + "', basic_income_per_cutoff = '" + BasicIncomeTxt.Text + "', honorarium_rate_hr = '" + HonorariumRateHourTxt.Text + "', honorarium_no_of_hrs_cut0ff = '" + HonorariumNoofHoursTxt.Text + "', honorarium_income_per_cutoff = '" + HonorariumIncomeTxt.Text + "', other_rate_hr = '" + OtherRateHourTxt.Text + "', other_no_of_hrs_cutOff = '" + OtherNoofHoursTxt.Text + "', other_income_per_cutoff = '" + OtherIncomeTxt.Text + "', sss_contrib = '" + SSSContributionTxt.Text + "', philhealth_contrib = '" + PhilhealthContributionsTxt.Text + "', pagibig_contrib = '" + PagibigContributionsTxt.Text + "', tax_contrib = '" + IncomeTaxTxt.Text + "', sss_loan = '" + SSSLoanTxt.Text + "', pagibig_loan = '" + PagibigLoansTxt.Text + "', fac_savings_deposit = '" + FacultySavingsDepositTxt.Text + "', fac_savings_loan = '" + FacultySavingsLoansTxt.Text + "', salary_loan = '" + SalaryLoanTxt.Text + "', other_loans = '" + OtherLoanTxt.Text + "', total_deductions = '" + TotalDeductionTxt.Text + "', gross_income = '" + GrossIncomeTxt.Text + "', net_income = '" + NetIncomeTxt.Text + "', pay_date = '" + paydateDatePicker.Text + "' WHERE payrolTbl.emp_id = '" + empNumberTxtBox.Text + "' AND pay_date = '" + paydateDatePicker.Text + "'";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterUpdate();
                payrol_db_connect.payrol_sql_connection.Close();

                MessageBox.Show("Record updated successfully!");
                cleartexeboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void DELETEbutton_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_dbconnection payrol_db_connect = new payrol_dbconnection();

                payrol_db_connect.payrol_connString();

                payrol_db_connect.payrol_sql = "DELETE FROM payrolTbl WHERE payrolTbl.emp_id = '" + empNumberTxtBox.Text + "'";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterDelete();

                payrol_db_connect.payrol_sql_connection.Close();

                cleartexeboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
                payrol_db_connect.payrol_connString();
                payrol_db_connect.payrol_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath FROM pos_empRegTbl WHERE emp_id = '" + empNumberTxtBox.Text + "'";
                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();


                DataRow row = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0];
                firstnameTxtbox.Text = row[1].ToString();
                MNameTxtbox.Text = row[2].ToString();
                surnameTxtBox.Text = row[3].ToString();
                civilStatusTxtBox.Text = row[4].ToString();
                designationTxtBox.Text = row[5].ToString();
                numDependentsTxtBox.Text = row[6].ToString();
                emp_statusTxtbox.Text = row[7].ToString();
                departmentTxtBox.Text = row[8].ToString();

                string picpath = row[9].ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = System.Drawing.Image.FromFile(picpath);

                

                payrol_db_connect.payrol_sql_connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Search_EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_dbconnection payrol_db_connect = new payrol_dbconnection();

                payrol_db_connect.payrol_connString();

                payrol_db_connect.payrol_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath, basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutoff, honorarium_rate_hr, honorarium_no_of_hrs_cut0ff, honorarium_income_per_cutoff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutoff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, payrolTbl.emp_id, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE (payrolTbl.emp_id = '" + empNumberTxtBox.Text + "' AND payrolTbl.pay_date = '" + paydateDatePicker.Text + "')";

                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();

                firstnameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][1].ToString();
                MNameTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][3].ToString();
                civilStatusTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][4].ToString();
                designationTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][5].ToString();
                numDependentsTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][6].ToString();
                emp_statusTxtbox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][7].ToString();
                departmentTxtBox.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][8].ToString();

                string picpath = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][9].ToString();

                if (!string.IsNullOrEmpty(picpath) && File.Exists(picpath))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = System.Drawing.Image.FromFile(picpath);
                }

                BasicRateHourTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][10].ToString();
                BasicNoofHoursTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][11].ToString();
                BasicIncomeTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][12].ToString();
                HonorariumRateHourTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][13].ToString();
                HonorariumNoofHoursTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][14].ToString();
                HonorariumIncomeTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][15].ToString();
                OtherRateHourTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][16].ToString();
                OtherNoofHoursTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][17].ToString();
                OtherIncomeTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][18].ToString();
                SSSContributionTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][19].ToString();
                PhilhealthContributionsTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][20].ToString();
                PagibigContributionsTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][21].ToString();
                IncomeTaxTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][22].ToString();
                SSSLoanTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][23].ToString();
                PagibigLoansTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][24].ToString();
                FacultySavingsDepositTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][25].ToString();
                FacultySavingsLoansTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][26].ToString();
                SalaryLoanTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][27].ToString();
                OtherLoanTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][28].ToString();
                TotalDeductionTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][29].ToString();
                GrossIncomeTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][30].ToString();
                NetIncomeTxt.Text = payrol_db_connect.payrol_sql_dataset.Tables[0].Rows[0][31].ToString();

                payrol_db_connect.payrol_sql_connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void CALCULATEbutton_Click(object sender, EventArgs e)
        {
            try
            {
                PayrollCalculator calculator = new PayrollCalculator();

                decimal basicRate = decimal.Parse(BasicRateHourTxt.Text);
                decimal basicHours = decimal.Parse(BasicNoofHoursTxt.Text);
                decimal basicIncome = calculator.ComputeBasicIncome(basicRate, basicHours);
                BasicIncomeTxt.Text = basicIncome.ToString("0.00");

                decimal honorariumRate = decimal.Parse(HonorariumRateHourTxt.Text);
                decimal honorariumHours = decimal.Parse(HonorariumNoofHoursTxt.Text);
                decimal honorariumIncome = calculator.ComputeBasicIncome(honorariumRate, honorariumHours);
                HonorariumIncomeTxt.Text = honorariumIncome.ToString("0.00");

                decimal otherRate = decimal.Parse(OtherRateHourTxt.Text);
                decimal otherHours = decimal.Parse(OtherNoofHoursTxt.Text);
                decimal otherIncome = calculator.ComputeBasicIncome(otherRate, otherHours);
                OtherIncomeTxt.Text = otherIncome.ToString("0.00");

                decimal grossIncome = calculator.ComputeGrossIncome(basicIncome, honorariumIncome, otherIncome);
                GrossIncomeTxt.Text = grossIncome.ToString("0.00");

                decimal sssContrib = calculator.ComputeSSS(grossIncome);
                SSSContributionTxt.Text = sssContrib.ToString("0.00");

                decimal pagibigContrib = calculator.ComputePagibig();
                PagibigContributionsTxt.Text = pagibigContrib.ToString("0.00");

                decimal philhealthContrib = calculator.ComputePhilHealth(grossIncome);
                PhilhealthContributionsTxt.Text = philhealthContrib.ToString("0.00");

                decimal taxableIncome = grossIncome - sssContrib - philhealthContrib - pagibigContrib;

                decimal tax = calculator.ComputeTax(taxableIncome);
                IncomeTaxTxt.Text = tax.ToString("0.00");

                decimal sssLoan = decimal.Parse(SSSLoanTxt.Text);
                decimal pagibigLoan = decimal.Parse(PagibigLoansTxt.Text);
                decimal savingsDeposit = decimal.Parse(FacultySavingsDepositTxt.Text);
                decimal savingsLoan = decimal.Parse(FacultySavingsLoansTxt.Text);
                decimal salaryLoan = decimal.Parse(SalaryLoanTxt.Text);
                decimal otherLoan = decimal.Parse(OtherLoanTxt.Text);

                var payrollData = new PayrollVariables
                {
                    sssContribution = sssContrib,
                    philhealthContribution = philhealthContrib,
                    pagibigContribution = pagibigContrib,
                    incomeTax = tax,
                    sssLoan = sssLoan,
                    pagibigLoan = pagibigLoan,
                    facultySavingsDeposit = savingsDeposit,
                    facultySavingsLoan = savingsLoan,
                    salaryLoan = salaryLoan,
                    otherLoan = otherLoan
                };

                decimal totalDeduction = calculator.ComputeTotalDeduction(payrollData);
                TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                decimal netIncome = calculator.ComputeNetIncome(grossIncome, totalDeduction);
                NetIncomeTxt.Text = netIncome.ToString("0.00");

                MessageBox.Show("Calculation completed!");
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in all fields with valid numbers!");
            }
        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payrol_Database_Load(object sender, EventArgs e)
        {
            picturepathTxtBox.Hide();

            others_loanCombo.Text = "Select other loan";
            others_loanCombo.Items.Add("Personal Loans");
            others_loanCombo.Items.Add("Home Loans");
            others_loanCombo.Items.Add("Auto Loans");
            others_loanCombo.Items.Add("Business Loans");
            others_loanCombo.Items.Add("Cash Loans");
            others_loanCombo.Items.Add("Buy Now, Pay Later (BNPL)");
        }

        private void PRINTbutton_Click(object sender, EventArgs e)
        {
            try
            {
                double totalDeduction = 0;
                double.TryParse(TotalDeductionTxt.Text, out totalDeduction);

                totalDeduction += 750;

                TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                Lesson5ActivityPayslipReport print = new Lesson5ActivityPayslipReport();

                print.EmployeeNumTxt.Text = empNumberTxtBox.Text;
                print.SurnameTxt.Text = surnameTxtBox.Text;
                print.FirstNameTxt.Text = firstnameTxtbox.Text;
                print.MiddleNameTxt.Text = MNameTxtbox.Text;
                print.DepartmentTxt.Text = departmentTxtBox.Text;
                print.textBox1.Text = paydateDatePicker.Text;
                print.PaydateTxt.Text = paydateDatePicker.Text;

                print.BasicNoofHoursTxt.Text = BasicNoofHoursTxt.Text;
                print.HonorariumNoofHoursTxt.Text = HonorariumNoofHoursTxt.Text;
                print.OtherNoofHoursTxt.Text = OtherNoofHoursTxt.Text;

                print.IncomeTaxTxt.Text = IncomeTaxTxt.Text;
                print.SSSContributionTxt.Text = SSSContributionTxt.Text;
                print.PhilhealthContributionsTxt.Text = PhilhealthContributionsTxt.Text;
                print.PagibigContributionsTxt.Text = PagibigContributionsTxt.Text;

                print.textBox12.Text = GrossIncomeTxt.Text;
                print.TotalDeductionTxt.Text = totalDeduction.ToString("0.00");

                print.GrossIncomeTxt.Text = GrossIncomeTxt.Text;
                print.textBox5.Text = totalDeduction.ToString("0.00");
                print.NetIncomeTxt.Text = NetIncomeTxt.Text;

                print.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void NEWbutton_Click(object sender, EventArgs e)
        {
            cleartexeboxes();
        }

        private void Savebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                payrol_dbconnection db = new payrol_dbconnection();
                db.payrol_connString();

                db.payrol_sql = "INSERT INTO payrolTbl (basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutoff, honorarium_rate_hr, honorarium_no_of_hrs_cut0ff, honorarium_income_per_cutoff, other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutoff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, emp_id, pay_date) VALUES ('" + BasicRateHourTxt.Text + "', '" + BasicNoofHoursTxt.Text + "', '" + BasicIncomeTxt.Text + "', '" + HonorariumRateHourTxt.Text + "', '" + HonorariumNoofHoursTxt.Text + "', '" + HonorariumIncomeTxt.Text + "', '" + OtherRateHourTxt.Text + "', '" + OtherNoofHoursTxt.Text + "', '" + OtherIncomeTxt.Text + "', '" + SSSContributionTxt.Text + "', '" + PhilhealthContributionsTxt.Text + "', '" + PagibigContributionsTxt.Text + "', '" + IncomeTaxTxt.Text + "', '" + SSSLoanTxt.Text + "', '" + PagibigLoansTxt.Text + "', '" + FacultySavingsDepositTxt.Text + "', '" + FacultySavingsLoansTxt.Text + "', '" + SalaryLoanTxt.Text + "', '" + OtherLoanTxt.Text + "', '" + TotalDeductionTxt.Text + "', '" + GrossIncomeTxt.Text + "', '" + NetIncomeTxt.Text + "', '" + empNumberTxtBox.Text + "', '" + paydateDatePicker.Text + "')";

                db.payrol_cmd();
                db.payrol_sqladapterInsert();
                db.payrol_sql_connection.Close();

                MessageBox.Show("Record saved successfully!");
                cleartexeboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
