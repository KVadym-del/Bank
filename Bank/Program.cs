using Bank.Utilities;
using System.Reflection.Metadata.Ecma335;

public class Account
{
    private double Balance = 0.0;

    public void DepositFunds(double amount)
    {
        Balance += WalletUtils.IsAPositive(amount) ? amount : throw new ArgumentException("Depositing value should be positive.");
    }

    public void WithdrawFunds(double amount)
    {
        if (!WalletUtils.IsAPositive(amount)) throw new ArgumentException("Withdraw value should be positive.");
        if (Balance < amount) throw new ArgumentException("Not enough money");
        Balance -= amount;
    }


    public void GetBalance()
    {
        Console.WriteLine(Balance);
    }

    public static void Main(string[] args)
    {
        Account myAccount = new Account();

        myAccount.DepositFunds(100.0);
        myAccount.GetBalance();

        myAccount.WithdrawFunds(50.0);
        myAccount.GetBalance();                                               
    }
}