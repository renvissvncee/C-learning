using System;

public class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount) => Balance += amount;

    public void Withdraw(decimal amount)
    {
        if (Balance - amount < 0)
        {
            Console.WriteLine("Не хватает денег");
            return;
        }
        Balance -= amount;
    }
}

class Program
{
    public static void Main()
    { 
        BankAccount account = new BankAccount();
        account.Deposit(100);
        Console.WriteLine(account.Balance);
    }
}


