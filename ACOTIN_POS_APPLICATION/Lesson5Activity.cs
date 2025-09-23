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
            /// income for basic, honorarium, other, regular deduction
            
            /// Basic Income
            decimal basicRate = Convert.ToDecimal(BasicRateHourTxt.Text);
            decimal basicHour = Convert.ToDecimal(BasicNoofHoursTxt.Text);
            decimal basicIncome = basicRate * basicHour;
            BasicIncomeTxt.Text = basicIncome.ToString("0.00");

            /// Honorarium Income
            decimal honorariumRate = Convert.ToDecimal(HonorariumRateHourTxt.Text);
            decimal honorariumHours = Convert.ToDecimal(HonorariumNoofHoursTxt.Text);
            decimal honorariumIncome = honorariumRate * honorariumHours;
            HonorariumIncomeTxt.Text = honorariumIncome.ToString("0.00");

            /// Other Income
            decimal otherRate = Convert.ToDecimal(OtherRateHourTxt.Text);
            decimal otherHours = Convert.ToDecimal(OtherNoofHoursTxt.Text);
            decimal otherIncome = otherRate * otherHours;
            OtherIncomeTxt.Text = otherIncome.ToString("0.00");

            /// Gross Income
            decimal grossIncome = basicIncome + honorariumIncome + otherIncome;
            GrossIncomeTxt.Text = grossIncome.ToString();

            /// Deductions
            /// SSS
            decimal sssContribution = 0;

            if (grossIncome < 10700)
                sssContribution = (grossIncome * 0.15m) + 10;
            else
                sssContribution = (grossIncome * 0.15m) + 30;

            SSSContributionTxt.Text = sssContribution.ToString();

            /// PhilHealth
            decimal monthlyIncome = grossIncome * 2;
            decimal philhealthContribution = 0;

            if (monthlyIncome <= 10000)
                philhealthContribution = 500;
            else if (monthlyIncome >= 10000.01m && monthlyIncome <= 99999.99m)
                philhealthContribution = monthlyIncome * 0.05m;
            else if (monthlyIncome >= 100000)
                philhealthContribution = 5000;

            PhilhealthContributionsTxt.Text = philhealthContribution.ToString();

            /// PagIbig
            PagibigContributionsTxt.Text = "200";

            /// Income Tax
            decimal netTaxableIncome = grossIncome - (sssContribution + philhealthContribution + 200);
            decimal yearlyIncome = netTaxableIncome * 24;
            decimal yearlyTax = 0;

            if (yearlyIncome <= 250000)
                yearlyTax = 0;
            else if (yearlyIncome > 250000 && yearlyIncome <= 400000)
                yearlyTax = (yearlyIncome - 250000) * 0.15m;
            else if (yearlyIncome > 400000 && yearlyIncome <= 800000)
                yearlyTax = 22500 + (yearlyIncome - 400000) * 0.20m;
            else if (yearlyIncome > 800000 && yearlyIncome <= 2000000)
                yearlyTax = 102500 + (yearlyIncome - 800000) * 0.25m;
            else if (yearlyIncome > 2000000 && yearlyIncome <= 8000000)
                yearlyTax = 402500 + (yearlyIncome - 2000000) * 0.30m;
            else if (yearlyIncome > 8000000)
                yearlyTax = 2202500 + (yearlyIncome - 8000000) * 0.35m;

            decimal incomeTax = yearlyTax / 24; 
            IncomeTaxTxt.Text = incomeTax.ToString();
            

        }
    }
}
