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
        payrol_dbconnection db = new payrol_dbconnection();
        public Payrol_Database()
        {

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
            others_loanCombo.SelectedIndex = 0;
            payslip_viewListBox.Items.Clear();
            pictureBox1.Image = Properties.Resources.no_image;
        }

        private void cleartexeboxes2()
        {
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
            others_loanCombo.SelectedIndex = 0;
            payslip_viewListBox.Items.Clear();

        }

        private void EDITbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string otherLoanValue = OtherLoanTxt.Text;
                if (!string.IsNullOrEmpty(others_loanCombo.Text) && others_loanCombo.Text != "Select other loan")
                {
                    otherLoanValue = others_loanCombo.Text + ": " + OtherLoanTxt.Text;
                }

                db.payrol_sql = "UPDATE payrolTbl SET basic_rate_hr = '" + BasicRateHourTxt.Text + "', basic_no_of_hrs_cutoff = '" + BasicNoofHoursTxt.Text + "', basic_income_per_cutoff = '" + BasicIncomeTxt.Text + "', honorarium_rate_hr = '" + HonorariumRateHourTxt.Text + "', honorarium_no_of_hrs_cut0ff = '" + HonorariumNoofHoursTxt.Text + "', honorarium_income_per_cutoff = '" + HonorariumIncomeTxt.Text + "', other_rate_hr = '" + OtherRateHourTxt.Text + "', other_no_of_hrs_cutOff = '" + OtherNoofHoursTxt.Text + "', other_income_per_cutoff = '" + OtherIncomeTxt.Text + "', sss_contrib = '" + SSSContributionTxt.Text + "', philhealth_contrib = '" + PhilhealthContributionsTxt.Text + "', pagibig_contrib = '" + PagibigContributionsTxt.Text + "', tax_contrib = '" + IncomeTaxTxt.Text + "', sss_loan = '" + SSSLoanTxt.Text + "', pagibig_loan = '" + PagibigLoansTxt.Text + "', fac_savings_deposit = '" + FacultySavingsDepositTxt.Text + "', fac_savings_loan = '" + FacultySavingsLoansTxt.Text + "', salary_loan = '" + SalaryLoanTxt.Text + "', other_loans = '" + otherLoanValue + "', total_deductions = '" + TotalDeductionTxt.Text + "', gross_income = '" + GrossIncomeTxt.Text + "', net_income = '" + NetIncomeTxt.Text + "', pay_date = '" + paydateDatePicker.Text + "' WHERE payrolTbl.emp_id = '" + empNumberTxtBox.Text + "' AND pay_date = '" + paydateDatePicker.Text + "'";

                db.payrol_cmd();
                db.payrol_sqladapterUpdate();
                db.payrol_sql_connection.Close();

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
                db.payrol_sql = "DELETE FROM payrolTbl WHERE payrolTbl.emp_id = '" + empNumberTxtBox.Text + "'";
                db.payrol_cmd();
                db.payrol_sqladapterDelete();
                db.payrol_sql_connection.Close();

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
                if (string.IsNullOrEmpty(empNumberTxtBox.Text))
                {
                    MessageBox.Show("Please enter an employee number!");
                    return;
                }

                db.payrol_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath FROM pos_empRegTbl WHERE emp_id = '" + empNumberTxtBox.Text + "'";
                db.payrol_cmd();
                db.payrol_sqladapterSelect();
                db.payrol_sqldatasetSELECT();

                // Check if any records were found
                if (db.payrol_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No employee found with ID: " + empNumberTxtBox.Text);
                    db.payrol_sql_connection.Close();
                    return;
                }

                DataRow row = db.payrol_sql_dataset.Tables[0].Rows[0];
                firstnameTxtbox.Text = row[1].ToString();
                MNameTxtbox.Text = row[2].ToString();
                surnameTxtBox.Text = row[3].ToString();
                civilStatusTxtBox.Text = row[4].ToString();
                designationTxtBox.Text = row[5].ToString();
                numDependentsTxtBox.Text = row[6].ToString();
                emp_statusTxtbox.Text = row[7].ToString();
                departmentTxtBox.Text = row[8].ToString();

                string picpath = row[9].ToString();
                if (!string.IsNullOrEmpty(picpath) && File.Exists(picpath))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = System.Drawing.Image.FromFile(picpath);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.no_image;
                }

                cleartexeboxes2();

                db.payrol_sql_connection.Close();
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
                db.payrol_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, emp_work_status, emp_department, picpath, basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, payrolTbl.emp_id, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE (payrolTbl.emp_id = '" + empNumberTxtBox.Text + "' AND payrolTbl.pay_date = '" + paydateDatePicker.Text + "')";
                db.payrol_cmd();
                db.payrol_sqladapterSelect();
                db.payrol_sqldatasetSELECT();

                if (db.payrol_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No payroll record found for this employee and date!");
                    db.payrol_sql_connection.Close();
                    return;
                }

                firstnameTxtbox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][1].ToString();
                MNameTxtbox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][2].ToString();
                surnameTxtBox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][3].ToString();
                civilStatusTxtBox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][4].ToString();
                designationTxtBox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][5].ToString();
                numDependentsTxtBox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][6].ToString();
                emp_statusTxtbox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][7].ToString();
                departmentTxtBox.Text = db.payrol_sql_dataset.Tables[0].Rows[0][8].ToString();

                string picpath = db.payrol_sql_dataset.Tables[0].Rows[0][9].ToString();
                if (!string.IsNullOrEmpty(picpath) && File.Exists(picpath))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = System.Drawing.Image.FromFile(picpath);
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.no_image;
                }

                BasicRateHourTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][10].ToString();
                BasicNoofHoursTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][11].ToString();
                BasicIncomeTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][12].ToString();
                HonorariumRateHourTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][13].ToString();
                HonorariumNoofHoursTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][14].ToString();
                HonorariumIncomeTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][15].ToString();
                OtherRateHourTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][16].ToString();
                OtherNoofHoursTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][17].ToString();
                OtherIncomeTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][18].ToString();

                SSSContributionTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][19].ToString();
                PhilhealthContributionsTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][20].ToString();
                PagibigContributionsTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][21].ToString();
                IncomeTaxTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][22].ToString();

                SSSLoanTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][23].ToString();
                PagibigLoansTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][24].ToString();
                FacultySavingsDepositTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][25].ToString();
                FacultySavingsLoansTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][26].ToString();
                SalaryLoanTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][27].ToString();

                // Parse the other_loans field which is stored as "Loan Type: Amount"
                string otherLoanData = db.payrol_sql_dataset.Tables[0].Rows[0][28].ToString();
                if (!string.IsNullOrEmpty(otherLoanData) && otherLoanData.Contains(":"))
                {
                    string[] parts = otherLoanData.Split(new[] { ": " }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        others_loanCombo.Text = parts[0]; // Loan type
                        OtherLoanTxt.Text = parts[1];     // Amount
                    }
                    else
                    {
                        others_loanCombo.SelectedIndex = 0;
                        OtherLoanTxt.Text = otherLoanData;
                    }
                }
                else
                {
                    others_loanCombo.SelectedIndex = 0;
                    OtherLoanTxt.Text = otherLoanData;
                }

                TotalDeductionTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][29].ToString();
                GrossIncomeTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][30].ToString();
                NetIncomeTxt.Text = db.payrol_sql_dataset.Tables[0].Rows[0][31].ToString();

                db.payrol_sql_connection.Close();

                MessageBox.Show("Payroll data loaded successfully!");
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

            others_loanCombo.Items.Add("Select other loan");
            others_loanCombo.Items.Add("Personal Loans");
            others_loanCombo.Items.Add("Home Loans");
            others_loanCombo.Items.Add("Auto Loans");
            others_loanCombo.Items.Add("Business Loans");
            others_loanCombo.Items.Add("Cash Loans");
            others_loanCombo.Items.Add("Buy Now, Pay Later (BNPL)");

            firstnameTxtbox.Enabled = false;
            MNameTxtbox.Enabled = false;
            surnameTxtBox.Enabled = false;
            civilStatusTxtBox.Enabled = false;
            designationTxtBox.Enabled = false;
            numDependentsTxtBox.Enabled = false;
            emp_statusTxtbox.Enabled = false;
            departmentTxtBox.Enabled = false;

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


        private void PREVIEWbutton_Click(object sender, EventArgs e)
        {
            payslip_viewListBox.Items.Clear();

            payslip_viewListBox.Items.Add("====================================================================");
            payslip_viewListBox.Items.Add("                         PAYSLIP DETAILS                            ");
            payslip_viewListBox.Items.Add("====================================================================");
            payslip_viewListBox.Items.Add("");

            payslip_viewListBox.Items.Add("EMPLOYEE INFORMATION");
            payslip_viewListBox.Items.Add("--------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("Employee Number:".PadRight(35) + empNumberTxtBox.Text);
            payslip_viewListBox.Items.Add("First Name:".PadRight(35) + firstnameTxtbox.Text);
            payslip_viewListBox.Items.Add("Middle Name:".PadRight(35) + MNameTxtbox.Text);
            payslip_viewListBox.Items.Add("Surname:".PadRight(35) + surnameTxtBox.Text);
            payslip_viewListBox.Items.Add("Civil Status:".PadRight(35) + civilStatusTxtBox.Text);
            payslip_viewListBox.Items.Add("Designation:".PadRight(35) + designationTxtBox.Text);
            payslip_viewListBox.Items.Add("No. of Dependents:".PadRight(35) + numDependentsTxtBox.Text);
            payslip_viewListBox.Items.Add("Employee Status:".PadRight(35) + emp_statusTxtbox.Text);
            payslip_viewListBox.Items.Add("Department:".PadRight(35) + departmentTxtBox.Text);
            payslip_viewListBox.Items.Add("");

            payslip_viewListBox.Items.Add("--------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("Basic Rate/Hour:".PadRight(35) + BasicRateHourTxt.Text);
            payslip_viewListBox.Items.Add("Basic No. of Hours:".PadRight(35) + BasicNoofHoursTxt.Text);
            payslip_viewListBox.Items.Add("Basic Income:".PadRight(35) + BasicIncomeTxt.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("Honorarium Rate/Hour:".PadRight(35) + HonorariumRateHourTxt.Text);
            payslip_viewListBox.Items.Add("Honorarium No. of Hours:".PadRight(35) + HonorariumNoofHoursTxt.Text);
            payslip_viewListBox.Items.Add("Honorarium Income:".PadRight(35) + HonorariumIncomeTxt.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("Other Rate/Hour:".PadRight(35) + OtherRateHourTxt.Text);
            payslip_viewListBox.Items.Add("Other No. of Hours:".PadRight(35) + OtherNoofHoursTxt.Text);
            payslip_viewListBox.Items.Add("Other Income:".PadRight(35) + OtherIncomeTxt.Text);
            payslip_viewListBox.Items.Add("");
            

            payslip_viewListBox.Items.Add("--------------------------------------------------------------------");
            payslip_viewListBox.Items.Add("SSS Contribution:".PadRight(35) + SSSContributionTxt.Text);
            payslip_viewListBox.Items.Add("PhilHealth Contribution:".PadRight(35) + PhilhealthContributionsTxt.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Contribution:".PadRight(35) + PagibigContributionsTxt.Text);
            payslip_viewListBox.Items.Add("Income Tax:".PadRight(35) + IncomeTaxTxt.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("SSS Loan:".PadRight(35) + SSSLoanTxt.Text);
            payslip_viewListBox.Items.Add("Pag-IBIG Loan:".PadRight(35) + PagibigLoansTxt.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Deposit:".PadRight(35) + FacultySavingsDepositTxt.Text);
            payslip_viewListBox.Items.Add("Faculty Savings Loan:".PadRight(35) + FacultySavingsLoansTxt.Text);
            payslip_viewListBox.Items.Add("Salary Loan:".PadRight(35) + SalaryLoanTxt.Text);
            payslip_viewListBox.Items.Add("Other Loan:".PadRight(35) + OtherLoanTxt.Text);
            payslip_viewListBox.Items.Add("");
            payslip_viewListBox.Items.Add("--------------------------------------------------------------------");
            
            payslip_viewListBox.Items.Add("GROSS INCOME:".PadRight(35) + GrossIncomeTxt.Text);
            payslip_viewListBox.Items.Add("TOTAL DEDUCTION:".PadRight(35) + TotalDeductionTxt.Text);

            payslip_viewListBox.Items.Add("====================================================================");
            payslip_viewListBox.Items.Add("NET INCOME:".PadRight(35) + NetIncomeTxt.Text);
            payslip_viewListBox.Items.Add("====================================================================");
        }

        private void Savebutton_Click_1(object sender, EventArgs e)
        {
            try
            {

                string otherLoanValue = OtherLoanTxt.Text;
                if (!string.IsNullOrEmpty(others_loanCombo.Text) && others_loanCombo.Text != "Select other loan")
                {
                    otherLoanValue = others_loanCombo.Text + ": " + OtherLoanTxt.Text;
                }

                db.payrol_sql = "INSERT INTO payrolTbl (basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, salary_loan, other_loans, total_deductions, gross_income, net_income, emp_id, pay_date) VALUES ('" + BasicRateHourTxt.Text + "', '" + BasicNoofHoursTxt.Text + "', '" + BasicIncomeTxt.Text + "', '" + HonorariumRateHourTxt.Text + "', '" + HonorariumNoofHoursTxt.Text + "', '" + HonorariumIncomeTxt.Text + "', '" + OtherRateHourTxt.Text + "', '" + OtherNoofHoursTxt.Text + "', '" + OtherIncomeTxt.Text + "', '" + SSSContributionTxt.Text + "', '" + PhilhealthContributionsTxt.Text + "', '" + PagibigContributionsTxt.Text + "', '" + IncomeTaxTxt.Text + "', '" + SSSLoanTxt.Text + "', '" + PagibigLoansTxt.Text + "', '" + FacultySavingsDepositTxt.Text + "', '" + FacultySavingsLoansTxt.Text + "', '" + SalaryLoanTxt.Text + "', '" + otherLoanValue + "', '" + TotalDeductionTxt.Text + "', '" + GrossIncomeTxt.Text + "', '" + NetIncomeTxt.Text + "', '" + empNumberTxtBox.Text + "', '" + paydateDatePicker.Text + "')";

                db.payrol_cmd();
                db.payrol_sqladapterInsert();
                db.payrol_sql_connection.Close();
                cleartexeboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
