using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        private double totalUnits = 0;
        private double baseTuitionFee = 0;
        private double totalMiscFee = 0;
        private const double TuitionFeePerUnit = 1500.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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
            ExamBookletFeetextBox.Clear();
            CiscoLabFeetextBox.Clear();
            LabFeetextBox.Clear();
            LabFees.Clear();
            CiscoLabFees.Clear();
            ExamBookletFees.Clear();
            TotalTuitionandFees.Clear();
            TotalTuitionandFeetextBox.Clear();
            TotalTuitionFeetextBox.Clear();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseCodelistBox.Items.Add(UnitLabtextBox.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalTuitionFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void LabFees_TextChanged(object sender, EventArgs e)
        {

        }
    }
}