using Bank.Utilities;

public class Account
{
    private double Balance = 0.0;

    public void DepositFunds(double amount)
    {
        Balance += WalletUtils.IsAPositive(amount) ? amount : throw new ArgumentException("Depositing value should be positive.");
    }

    public void WithdrawFunds(double amount)
    {
        Balance -= WalletUtils.IsAPositive(amount) ? Balance > amount ? amount : throw new ArgumentException("Not enough money") : throw new ArgumentException("Withdraw value should be positive.");
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