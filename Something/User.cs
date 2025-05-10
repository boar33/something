using System;

namespace Something;

public class User
{
    public decimal Funds { get; private set; }

    public User(decimal cash, decimal moneyInBank)
    {
        Funds = cash + moneyInBank;
    }

    public void ReduceFunds(decimal balanceReduced)
    {
        Funds -= balanceReduced;
    }
}
