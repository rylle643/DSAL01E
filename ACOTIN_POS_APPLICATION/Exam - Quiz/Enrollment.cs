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
    public partial class Enrollment : Form
    {
        private double totalUnits = 0;
        private double baseTuitionFee = 0;
        private double totalMiscFee = 0;
        private const double TuitionFeePerUnit = 1500.00;
        public Enrollment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CourseNolistBox.Items.Add(CourseNumtextBox.Text);
                CourseCodelistBox.Items.Add(CourseCodetextBox.Text);
                CourseDesclistBox.Items.Add(CourseDesctextBox.Text);
                UnitLeclistBox.Items.Add(UnitLectextBox.Text);
                UnitLablistBox.Items.Add(UnitLabtextBox.Text);
                TimelistBox.Items.Add(TimetextBox.Text);
                DaylistBox.Items.Add(DaytextBox.Text);
                LabFees.Text = LabFeetextBox.Text;
                CiscoLabFees.Text = CiscoLabFeetextBox.Text;
                ExamBookletFees.Text = ExamBookletFeetextBox.Text;

                int LectureUnit, LabUnit;
                double CreditUnits;

                LectureUnit = Convert.ToInt32(UnitLectextBox.Text);
                LabUnit = Convert.ToInt32(UnitLabtextBox.Text);

                CreditUnits = LectureUnit + LabUnit;

                CreditUnitslistBox.Items.Add(CreditUnits.ToString());
                CreditUnitstextBox.Text = CreditUnits.ToString();

                totalUnits += CreditUnits;

                TotalNoofUnittextBox.Text = totalUnits.ToString();
                TotalNoofUnitsTxt.Text = totalUnits.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check lecture and lab units.", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading image.", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScholartextBox.Clear();
            CourseNolistBox.Items.Clear();
            CourseCodelistBox.Items.Clear();
            CourseDesclistBox.Items.Clear();
            UnitLeclistBox.Items.Clear();
            UnitLablistBox.Items.Clear();
            CreditUnitslistBox.Items.Clear();
            pictureBox1.Image = null;
            ProgramcomboBox.SelectedIndex = -1;

            totalUnits = 0;
            baseTuitionFee = 0;
            totalMiscFee = 0;

            CreditUnitstextBox.Clear();
            TotalNoofUnittextBox.Clear();
            TotalNoofUnitsTxt.Clear();
            TotalTuitionFee.Clear();
            TotalMiscFeetextBox.Clear();
            TotalMiscFees.Clear();
            TotalTuitionandFees.Clear();
            CourseNumtextBox.Clear();
            CourseCodetextBox.Clear();
            CourseDesctextBox.Clear();
            UnitLectextBox.Clear();
            UnitLabtextBox.Clear();
            LabFees.Clear();
            CiscoLabFees.Clear();
            ExamBookletFees.Clear();
            TotalTuitionandFees.Clear();
            TotalTuitionandFeetextBox.Clear();
            TotalTuitionFeetextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int ExamBooklet, CiscoLab, ComLab;
                double MiscFee, totalTuitionFee;

                ExamBooklet = Convert.ToInt32(ExamBookletFeetextBox.Text);
                CiscoLab = Convert.ToInt32(CiscoLabFeetextBox.Text);
                ComLab = Convert.ToInt32(LabFeetextBox.Text);

                MiscFee = ExamBooklet + CiscoLab + ComLab;

                TotalMiscFeetextBox.Text = MiscFee.ToString("n");
                TotalMiscFees.Text = MiscFee.ToString("n");

                totalTuitionFee = totalUnits * TuitionFeePerUnit;

                TotalTuitionFee.Text = totalTuitionFee.ToString("n");

                double totalTuitionAndFees = totalTuitionFee + MiscFee;
                TotalTuitionandFeetextBox.Text = totalTuitionAndFees.ToString("n");
                TotalTuitionandFees.Text = totalTuitionAndFees.ToString("n");

                TotalNoofUnittextBox.Text = totalUnits.ToString("n");
                TotalNoofUnitsTxt.Text = totalUnits.ToString("n");
                TotalTuitionFeetextBox.Text = totalTuitionFee.ToString("n");
                TotalTuitionFee.Text = totalTuitionFee.ToString("n");
                TotalOtherSchoolFees.Text = MiscFee.ToString("n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check fee entries.", "Error");
            }
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            ProgramcomboBox.Items.Add("Architecture");
            ProgramcomboBox.Items.Add("Aeronautical Engineering");
            ProgramcomboBox.Items.Add("Computer Engineering");
            ProgramcomboBox.Items.Add("Civil Engineering");
            ProgramcomboBox.Items.Add("Electrical Engineering");
            ProgramcomboBox.Items.Add("Electronics Engineering");
            ProgramcomboBox.Items.Add("Industrial Engineering");
            ProgramcomboBox.Items.Add("Mechanical Engineering");

            CreditUnitstextBox.Enabled = false;
            TotalTuitionFee.Enabled = false;
            TotalNoofUnittextBox.Enabled = false;
            TotalMiscFees.Enabled = false;
            TotalTuitionandFees.Enabled = false;
            TotalTuitionandFeetextBox.Enabled = false;
            TotalNoofUnitsTxt.Enabled = false;
            TotalMiscFeetextBox.Enabled = false;
            TotalTuitionFeetextBox.Enabled = false;
            TotalOtherSchoolFees.Enabled = false;
            LabFees.Enabled = false;
            CiscoLabFees.Enabled = false;
            ExamBookletFees.Enabled = false;
        }

        private void LabFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void CiscoLabFees_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}