namespace Something
{
    public delegate void OnBalanceDecreased(decimal balance);

    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public event OnBalanceDecreased OnBalanceDecreased;

        public void DecreaseBalance(decimal price)
        {
            Balance -= price;
            OnBalanceDecreased(price);
        }
    }
}
