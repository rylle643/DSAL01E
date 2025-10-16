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
    public partial class DSAL_EXAM : Form
    {
        // Constants for fees
        private const decimal LECTURE_FEE = 1500.00m;
        private const decimal LABORATORY_FEE = 2500.00m;
        private const decimal CISCO_LAB_FEE = 4500.00m;
        private const decimal EXAM_BOOKLET_FEE = 450.00m;
        private const decimal SAP_FEE = 2000.00m;
        private const decimal DOWN_PAYMENT = 8000.00m;

        public DSAL_EXAM()
        {
            InitializeComponent();
        }

        private void DSAL_EXAM_Load(object sender, EventArgs e)
        {
            // Disable course code textboxes (you mentioned these should be disabled)
            // Remove these lines if course codes should be enabled
            // textBox1.Enabled = false;
            // textBox2.Enabled = false;
            // textBox3.Enabled = false;
            // textBox4.Enabled = false;
            // textBox5.Enabled = false;
            // textBox6.Enabled = false;
            // textBox7.Enabled = false;

            // Disable credit units textboxes (these are auto-calculated)
            textBox13.Enabled = false;
            textBox22.Enabled = false;
            textBox31.Enabled = false;
            textBox40.Enabled = false;
            textBox49.Enabled = false;
            textBox58.Enabled = false;
            textBox67.Enabled = false;
            textBox71.Enabled = false; // Total credit units

            // Disable calculation result textboxes
            TotalTuitionFeestextBox.Enabled = false;
            MiscellaneousFeetextBox.Enabled = false;
            TotalOtherSchoolFees.Enabled = false;
            ModeofPaymenttextBox.Enabled = false;
            InstallmentChargetextBox.Enabled = false;
            DownpaymenttextBox.Enabled = false;
            FIRSTInstallmenttextBox.Enabled = false;
            SECInstallmenttextBox.Enabled = false;
            THIRDInstallmenttextBox.Enabled = false;
            AmountDuetextBox.Enabled = false;
            GrandTotaltextBox.Enabled = false;
            DiscounttextBox.Enabled = false;
            TotalTuitionAndFeetextBox.Enabled = false;
            ComLabFees.Enabled = false;
            CiscoLabFees.Enabled = false;
            ExamBookletFees.Enabled = false;
            SAPtextBox.Enabled = false;

            // Populate ComboBoxes
            ProgramcomboBox.Items.Add("Architecture");
            ProgramcomboBox.Items.Add("Aeronautical Engineering");
            ProgramcomboBox.Items.Add("Computer Engineering");
            ProgramcomboBox.Items.Add("Civil Engineering");
            ProgramcomboBox.Items.Add("Electrical Engineering");
            ProgramcomboBox.Items.Add("Electronics Engineering");
            ProgramcomboBox.Items.Add("Industrial Engineering");
            ProgramcomboBox.Items.Add("Mechanical Engineering");

            YearLevelcomboBox.Items.Add("1st Year");
            YearLevelcomboBox.Items.Add("2nd Year");
            YearLevelcomboBox.Items.Add("3rd Year");
            YearLevelcomboBox.Items.Add("4th Year");
            YearLevelcomboBox.Items.Add("5th Year");

            ScholarcomboBox.Items.Add("None");
            ScholarcomboBox.Items.Add("Academic");
            ScholarcomboBox.Items.Add("Athletic");
            ScholarcomboBox.Items.Add("Employee");
            ScholarcomboBox.Items.Add("Sibling");

            ModecomboBox.Items.Add("Full Payment");
            ModecomboBox.Items.Add("Installment");

            // Set default mode to Installment
            ModecomboBox.SelectedIndex = 1;
            ModeofPaymenttextBox.Text = "Installment";

            // Add event handlers for calculation triggers
            AddCalculationEventHandlers();
        }

        private void AddCalculationEventHandlers()
        {
            // Lecture units textboxes
            textBox8.TextChanged += (s, e) => CalculateCreditUnit(textBox8, textBox9, textBox13);
            textBox9.TextChanged += (s, e) => CalculateCreditUnit(textBox8, textBox9, textBox13);

            textBox17.TextChanged += (s, e) => CalculateCreditUnit(textBox17, textBox18, textBox22);
            textBox18.TextChanged += (s, e) => CalculateCreditUnit(textBox17, textBox18, textBox22);

            textBox26.TextChanged += (s, e) => CalculateCreditUnit(textBox26, textBox27, textBox31);
            textBox27.TextChanged += (s, e) => CalculateCreditUnit(textBox26, textBox27, textBox31);

            textBox35.TextChanged += (s, e) => CalculateCreditUnit(textBox35, textBox36, textBox40);
            textBox36.TextChanged += (s, e) => CalculateCreditUnit(textBox35, textBox36, textBox40);

            textBox44.TextChanged += (s, e) => CalculateCreditUnit(textBox44, textBox45, textBox49);
            textBox45.TextChanged += (s, e) => CalculateCreditUnit(textBox44, textBox45, textBox49);

            textBox53.TextChanged += (s, e) => CalculateCreditUnit(textBox53, textBox54, textBox58);
            textBox54.TextChanged += (s, e) => CalculateCreditUnit(textBox53, textBox54, textBox58);

            textBox62.TextChanged += (s, e) => CalculateCreditUnit(textBox62, textBox63, textBox67);
            textBox63.TextChanged += (s, e) => CalculateCreditUnit(textBox62, textBox63, textBox67);

            // Add event handler for scholar combo box
            ScholarcomboBox.SelectedIndexChanged += (s, e) => CalculateAll();
        }

        private void CalculateCreditUnit(TextBox lectureUnits, TextBox labUnits, TextBox creditUnits)
        {
            decimal lecture = 0, lab = 0;
            decimal.TryParse(lectureUnits.Text, out lecture);
            decimal.TryParse(labUnits.Text, out lab);

            creditUnits.Text = (lecture + lab).ToString("0.0");

            CalculateAll();
        }

        private void CalculateAll()
        {
            // Calculate total credit units from all individual credit unit textboxes
            decimal totalCreditUnits = 0;
            totalCreditUnits += GetDecimalValue(textBox13);
            totalCreditUnits += GetDecimalValue(textBox22);
            totalCreditUnits += GetDecimalValue(textBox31);
            totalCreditUnits += GetDecimalValue(textBox40);
            totalCreditUnits += GetDecimalValue(textBox49);
            totalCreditUnits += GetDecimalValue(textBox58);
            totalCreditUnits += GetDecimalValue(textBox67);

            textBox71.Text = totalCreditUnits.ToString("0.0");

            // Calculate total lecture and lab units for fee calculations
            decimal totalLectureUnits = GetTotalLectureUnits();
            decimal totalLabUnits = GetTotalLabUnits();

            // Calculate Total Tuition Fee (instruction i)
            decimal totalTuitionFee = totalLectureUnits * LECTURE_FEE;
            TotalTuitionFeestextBox.Text = totalTuitionFee.ToString("0.00");

            // Calculate Computer Laboratory Fee (instruction k)
            decimal comLabFee = totalLabUnits * LABORATORY_FEE;
            ComLabFees.Text = comLabFee.ToString("0.00");

            // Set fixed fees
            CiscoLabFees.Text = CISCO_LAB_FEE.ToString("0.00");
            ExamBookletFees.Text = EXAM_BOOKLET_FEE.ToString("0.00");
            SAPtextBox.Text = SAP_FEE.ToString("0.00");

            // Calculate Total Other School Fees / Miscellaneous Fees (instruction j)
            decimal totalOtherFees = comLabFee + CISCO_LAB_FEE + SAP_FEE + EXAM_BOOKLET_FEE;
            TotalOtherSchoolFees.Text = totalOtherFees.ToString("0.00");
            MiscellaneousFeetextBox.Text = totalOtherFees.ToString("0.00");

            // Calculate Total Tuition and Fees (instruction l)
            decimal totalTuitionAndFees = totalTuitionFee + totalOtherFees;
            TotalTuitionAndFeetextBox.Text = totalTuitionAndFees.ToString("0.00");

            // Calculate discount based on scholarship
            decimal discount = CalculateDiscount(totalTuitionAndFees);
            DiscounttextBox.Text = discount.ToString("0.00");

            // Calculate Grand Total after discount
            decimal grandTotal = totalTuitionAndFees - discount;
            GrandTotaltextBox.Text = grandTotal.ToString("0.00");

            // Calculate installment details (instruction m)
            CalculateInstallmentDetails(grandTotal);
        }

        private decimal GetTotalLectureUnits()
        {
            decimal total = 0;
            total += GetDecimalValue(textBox8);
            total += GetDecimalValue(textBox17);
            total += GetDecimalValue(textBox26);
            total += GetDecimalValue(textBox35);
            total += GetDecimalValue(textBox44);
            total += GetDecimalValue(textBox53);
            total += GetDecimalValue(textBox62);
            return total;
        }

        private decimal GetTotalLabUnits()
        {
            decimal total = 0;
            total += GetDecimalValue(textBox9);
            total += GetDecimalValue(textBox18);
            total += GetDecimalValue(textBox27);
            total += GetDecimalValue(textBox36);
            total += GetDecimalValue(textBox45);
            total += GetDecimalValue(textBox54);
            total += GetDecimalValue(textBox63);
            return total;
        }

        private decimal GetDecimalValue(TextBox textBox)
        {
            decimal value = 0;
            decimal.TryParse(textBox.Text, out value);
            return value;
        }

        private decimal CalculateDiscount(decimal totalAmount)
        {
            if (ScholarcomboBox.SelectedItem == null)
                return 0;

            string scholarship = ScholarcomboBox.SelectedItem.ToString();

            switch (scholarship)
            {
                case "Academic":
                    return totalAmount * 0.50m; // 50% discount
                case "Athletic":
                    return totalAmount * 0.30m; // 30% discount
                case "Employee":
                    return totalAmount * 0.25m; // 25% discount
                case "Sibling":
                    return totalAmount * 0.10m; // 10% discount
                default:
                    return 0;
            }
        }

        private void CalculateInstallmentDetails(decimal grandTotal)
        {
            // Set down payment
            DownpaymenttextBox.Text = DOWN_PAYMENT.ToString("0.00");

            // Calculate remaining balance after down payment
            decimal remainingBalance = grandTotal - DOWN_PAYMENT;

            // Divide remaining balance into 3 installments
            decimal installmentAmount = remainingBalance / 3;

            FIRSTInstallmenttextBox.Text = installmentAmount.ToString("0.00");
            SECInstallmenttextBox.Text = installmentAmount.ToString("0.00");
            THIRDInstallmenttextBox.Text = installmentAmount.ToString("0.00");

            // Amount due is the down payment (initial payment required)
            AmountDuetextBox.Text = DOWN_PAYMENT.ToString("0.00");

            // Installment charge can be set to 0 or a specific value if needed
            InstallmentChargetextBox.Text = "0.00";
        }

        // Event handlers (keeping the existing structure)
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label18_Click(object sender, EventArgs e) { }
        private void label29_Click(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void textBox22_TextChanged(object sender, EventArgs e) { }
        private void TotalTuitionFeestextBox_TextChanged(object sender, EventArgs e) { }
        private void MiscellaneousFeetextBox_TextChanged(object sender, EventArgs e) { }
        private void ComLabFees_TextChanged(object sender, EventArgs e) { }
        private void CiscoLabFees_TextChanged(object sender, EventArgs e) { }
        private void ExamBookletFees_TextChanged(object sender, EventArgs e) { }
        private void TotalOtherSchoolFees_TextChanged(object sender, EventArgs e) { }
        private void textBox71_TextChanged(object sender, EventArgs e) { }
        private void TotalTuitionAndFeetextBox_TextChanged(object sender, EventArgs e) { }
        private void ModeofPaymenttextBox_TextChanged(object sender, EventArgs e) { }
        private void InstallmentChargetextBox_TextChanged(object sender, EventArgs e) { }
        private void DownpaymenttextBox_TextChanged(object sender, EventArgs e) { }
        private void FIRSTInstallmenttextBox_TextChanged(object sender, EventArgs e) { }
        private void SECInstallmenttextBox_TextChanged(object sender, EventArgs e) { }
        private void THIRDInstallmenttextBox_TextChanged(object sender, EventArgs e) { }
        private void AmountDuetextBox_TextChanged(object sender, EventArgs e) { }
        private void GrandTotaltextBox_TextChanged(object sender, EventArgs e) { }
        private void DiscounttextBox_TextChanged(object sender, EventArgs e) { }
        private void ModecomboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ScholarcomboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void YearLevelcomboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void StudentNumbertextBox_TextChanged(object sender, EventArgs e) { }
        private void DateEnrolleddateTimePicker_ValueChanged(object sender, EventArgs e) { }
        private void ProgramcomboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void StudentNametextBox_TextChanged(object sender, EventArgs e) { }
        private void label24_Click(object sender, EventArgs e) { }
        private void SAPtextBox_TextChanged(object sender, EventArgs e) { }

        private void ClearStudentInfobutton_Click(object sender, EventArgs e)
        {
            StudentNametextBox.Clear();
            StudentNumbertextBox.Clear();
            ProgramcomboBox.SelectedIndex = -1;
            YearLevelcomboBox.SelectedIndex = -1;
            ScholarcomboBox.SelectedIndex = -1;
            DateEnrolleddateTimePicker.Value = DateTime.Now;
            ModecomboBox.SelectedIndex = -1;



        }

        private void ClearStudentCoursesbutton_Click(object sender, EventArgs e)
        {
            // Clear textBox8 through textBox70
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox55.Clear();
            textBox56.Clear();
            textBox57.Clear();
            textBox58.Clear();
            textBox59.Clear();
            textBox60.Clear();
            textBox61.Clear();
            textBox62.Clear();
            textBox63.Clear();
            textBox64.Clear();
            textBox65.Clear();
            textBox66.Clear();
            textBox67.Clear();
            textBox68.Clear();
            textBox69.Clear();
            textBox70.Clear();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}