using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Account
    {
        //Base class Account should include one private instance variable of type decimal to represent the
        //account balance.
        private decimal balance;

        //The class should provide a constructor that receives an initial balance and uses it to
        //initialize the instance variable with a public property.
        public Account(decimal startingBalance)
        {
            Balance = startingBalance;
        }
        //The property should validate the initial balance to
        //ensure that it’s greater than or equal to 0.0; if not throw an exception.
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    MessageBox.Show("Your balance amount cannot be negative.");
                }
            }
        }

        //Method Credit should add an amount to the current balance
        public void Credit(decimal amount)
        {
            Balance = Balance + amount;
        }
        //Method Debit should withdraw money from the Account
        public void Debit(decimal amount)
        {
            if (amount > Balance)
            {
                MessageBox.Show("Debit amount exceeds account balance.");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
    }
}
