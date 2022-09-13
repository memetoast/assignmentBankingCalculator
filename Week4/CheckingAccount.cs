using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class CheckingAccount : Account
    {
        //Include a decimal instance variable that represents the fee charged per transaction.
        private decimal fee;

        //CheckingAccount’s constructor should receive the account’s initial balance, as well as a parameter
        //indicating a fee amount.
        public CheckingAccount(decimal startingBalance, decimal fee): base(startingBalance)
        {
            this.fee = fee;
        }
        //Class CheckingAccount should redefine methods Credit and Debit so that they subtract the fee from the account balance
        public void Credit(decimal amount)
        {
            base.Credit(amount - fee);
        }
        public void Debit(decimal amount)
        {
            if ((amount + fee)<= Balance)
                base.Debit(amount + fee);
            else
            {
                MessageBox.Show("Debit amount exceeds account balance.");
            }
        }
    }
}
