namespace JL_Intership_Day21_03
{
    public class SavingsAccount
    {
        public static int AnnualInterestRate;

        private int _savingsBalance;

        public int SavingsBalance
        {
            set
            {
                if (value > 0)
                {
                    _savingsBalance = value;
                }
            }
            get { return _savingsBalance; }
        }

        public void CalculateMonthlyInterest()
        {
            _savingsBalance = _savingsBalance*AnnualInterestRate/12;
        }

        public static void ModifyInterestRate(int newAnnualRate)
        {
            AnnualInterestRate = newAnnualRate;
        }
    }
}