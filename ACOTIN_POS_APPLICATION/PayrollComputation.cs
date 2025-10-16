using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACOTIN_POS_APPLICATION
{
    internal class PayrollCalculator
    {
        public decimal ComputeBasicIncome(decimal rateHour, decimal noofHours)
        {
            return rateHour * noofHours;
        }

        public decimal ComputeGrossIncome(decimal basic, decimal honorarium, decimal other)
        {
            return basic + honorarium + other;
        }

        public decimal ComputeSSS(decimal grossIncome)
        {
            decimal sss_contrib = 0;

            if (grossIncome < 5250)
            {
                sss_contrib = 250.00m / 2;
            }
            else
            {
                decimal extra = grossIncome - 5250;
                int bracket = (int)(extra / 500) + 1;
                decimal contribution = 250.00m + (bracket * 25.00m);
                sss_contrib = contribution / 2;
            }

            return sss_contrib;
        }

        public decimal ComputePagibig()
        {
            return 200.00m;
        }

        public decimal ComputePhilHealth(decimal grossIncome)
        {
            return grossIncome * 0.025m;
        }

        public decimal ComputeTax(decimal monthlyTaxable)
        {
            decimal tax = 0;

            if (monthlyTaxable <= 20833)
            {
                tax = 0;
            }
            else if (monthlyTaxable <= 33333)
            {
                decimal excess = monthlyTaxable - 20833;
                tax = excess * 0.15m;
            }
            else if (monthlyTaxable <= 66667)
            {
                decimal excess = monthlyTaxable - 33333;
                tax = 1875 + (excess * 0.20m);
            }
            else if (monthlyTaxable <= 166667)
            {
                decimal excess = monthlyTaxable - 66667;
                tax = 8541.80m + (excess * 0.25m);
            }
            else if (monthlyTaxable <= 666667)
            {
                decimal excess = monthlyTaxable - 166667;
                tax = 33541.80m + (excess * 0.30m);
            }
            else
            {
                decimal excess = monthlyTaxable - 666667;
                tax = 183541.80m + (excess * 0.35m);
            }

            return tax / 2;
        }

        public decimal ComputeTotalDeduction(PayrollVariables data)
        {
            return data.sssContribution +
                   data.philhealthContribution +
                   data.pagibigContribution +
                   data.incomeTax +
                   data.sssLoan +
                   data.pagibigLoan +
                   data.facultySavingsDeposit +
                   data.facultySavingsLoan +
                   data.salaryLoan +
                   data.otherLoan;
        }

        public decimal ComputeNetIncome(decimal grossIncome, decimal totalDeduction)
        {
            return grossIncome - totalDeduction;
        }
    }
}