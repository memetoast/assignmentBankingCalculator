namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonChecking.Checked = false;
            radioButtonSaving.Checked = false;
        }
        decimal balance = 0;
        //Calculate button clicked
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal.TryParse(textStartingBalance.Text, out balance);
            //For checking account
            if(radioButtonChecking.Checked)
            {
                decimal fee = 1.0M;
                CheckingAccount checkingAccount = new CheckingAccount(balance, fee);
                if(textDeposit.Text != "")
                {
                    checkingAccount.Credit(Convert.ToDecimal(textDeposit.Text));
                }
                if(textWithdraw.Text != "")
                {
                    checkingAccount.Debit(Convert.ToDecimal(textWithdraw.Text));
                }
                textTotal.Text = checkingAccount.Balance.ToString("C");
            }
            //For savings account
            else if(radioButtonSaving.Checked)
            {
                decimal rate = 0.5M;
                SavingsAccount savingsAccount = new SavingsAccount(balance, rate);
                if (textWithdraw.Text != "")
                {
                    savingsAccount.Debit(Convert.ToDecimal(textWithdraw.Text));
                }
                if (textDeposit.Text != "")
                {
                    savingsAccount.Credit(Convert.ToDecimal(textDeposit.Text));
                }
                // Add interest to the SavingsAccount object by first invoking its CalculateInterest method, then
                // passing the returned interest amount to the object’s Credit method.
                savingsAccount.Balance = savingsAccount.Balance + savingsAccount.CalculateInterest();
                textTotal.Text = savingsAccount.Balance.ToString("C");
            }
        }
        //Exit button clicked
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Reset button clicked
        private void button3_Click(object sender, EventArgs e)
        {
            textStartingBalance.Text = "";
            textDeposit.Text = "";
            textWithdraw.Text = "";
            textTotal.Text = "";
        }
    }
}