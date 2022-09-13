using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class SavingsAccount : Account
    {
        //Include a decimal instance variable indicating the interest rate(percentage) assigned to the account.
        private decimal interestRate;

        //SavingsAccount’s constructor should receive the initial balance, as well as an initial value for the interest rate.
        public SavingsAccount(decimal startingBalance, decimal rate):base(startingBalance)
        {
            interestRate = rate;
        }

        //CalculateInterest that returns a decimal that indicates the amount of interest earned by an account.
        public decimal CalculateInterest()
        {
            return Balance * (interestRate / (100 * 12));
        }
    }
}
