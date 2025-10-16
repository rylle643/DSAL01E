using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACOTIN_POS_APPLICATION
{
    internal class PayrollVariables
    {
        // Income
        public decimal basicIncome;
        public decimal honorariumIncome;
        public decimal otherIncome;
        public decimal grossIncome;
        public decimal netIncome;

        // Contributions
        public decimal sssContribution;
        public decimal philhealthContribution;
        public decimal pagibigContribution;
        public decimal incomeTax;

        // Loans
        public decimal sssLoan;
        public decimal pagibigLoan;
        public decimal facultySavingsDeposit;
        public decimal facultySavingsLoan;
        public decimal salaryLoan;
        public decimal otherLoan;

        // Total
        public decimal totalDeduction;
    }
}
