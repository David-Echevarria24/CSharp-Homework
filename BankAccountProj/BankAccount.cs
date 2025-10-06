using System;
namespace BankAccountProj;

public class BankAccount
{
    private string accountNumber;
    private string accountName;
    private decimal balance;

    public string AccountNumber { get { return accountNumber; } }
    public string AccountName { get { return accountName; } }
    public decimal Balance { get { return balance; } }

    public BankAccount()
    {
        accountName = "Default User";
        accountNumber = "00000";
        balance = 0.00m;
    }
    public BankAccount(string name, string accNum)
    {
        accountName = name;
        accountNumber = accNum;
        balance = 0.00m;
    }
    public bool Deposit(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine($"\nInvalid Amount. Please try again....");
            return false;
        }
        
        Console.WriteLine($"\nYou deposited ${amount} to your current balance of ${balance}.");
        balance += amount;
        Console.WriteLine($"Transaction was successful. Your new total is ${balance}.");
        return true;
    }

    public bool WithDraw(decimal amount)
    {
        if (amount <= 0 || amount > balance)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"\nError. Cannot be less than 0.");
            }
            if (amount > balance)
            {
                Console.WriteLine($"\nError. ${amount} exceeds your balance of ${balance}.");
            }
            return false;
        }
        Console.WriteLine($"\nWithdrawing ${amount}.");
        balance -= amount;
        Console.WriteLine($"Success! Your new balance is ${balance}.");
        return true;
    }

    
}