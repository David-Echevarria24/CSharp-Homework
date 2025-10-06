using System;
using System.Linq;
using System.Threading;

namespace BankAccountProj
{
    public static class UserInterface
    {
        public static BankAccount CreateAccount()
        {
            Console.WriteLine("=== Create New Bank Account ===");
            
            string accountName;
            do
            {
                Console.Write("Enter your full name: ");
                accountName = Console.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(accountName))
                {
                    Console.WriteLine("Name cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(accountName));

            // Simulate processing
            Console.WriteLine("\nProcessing your account information...");
            Thread.Sleep(1500); // 1.5 second delay
            
            // Generate random 5-digit account number
            Random random = new Random();
            string accountNumber = random.Next(10000, 99999).ToString();

            Console.WriteLine("Generating account number...");
            Thread.Sleep(1000); // 1 second delay

            Console.WriteLine($"\nAccount created successfully for {accountName}!");
            Console.WriteLine($"Your assigned account number is: {accountNumber}");
            Thread.Sleep(500); // 0.5 second delay
            Console.WriteLine("Press any key to continue to the main menu...");
            Console.ReadKey();
            Console.Clear();
            
            return new BankAccount(accountName, accountNumber);
        }

        public static void HandleUserDeposit(BankAccount account)
        {
            Console.Write("Enter an amount you want to deposit...ex: (100.00) ");
            string? input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal amount))
            {
                Console.WriteLine("Processing your deposit...");
                Thread.Sleep(1200); // 1.2 second delay
                
                bool success = account.Deposit(amount);
                if (success)
                {
                    Thread.Sleep(800); // 0.8 second delay
                    Console.WriteLine("Deposit completed successfully.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid format. Please enter a valid number");
                Thread.Sleep(500); // 0.5 second delay
                HandleUserDeposit(account);
                return;
            }
            HandleUserDeposit(account);
            return;
        }

        public static void HandleUserWithdrawal(BankAccount account)
        {
            Console.Write("Enter an amount you want to withdraw...ex: (100.00) ");
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal amount))
            {
                Console.WriteLine("Processing your withdrawal...");
                Thread.Sleep(1200); // 1.2 second delay
                
                bool success = account.WithDraw(amount);
                if (success)
                {
                    Thread.Sleep(800); // 0.8 second delay
                    Console.WriteLine("Withdraw completed successfully.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid format. Please enter a valid number");
                Thread.Sleep(500); // 0.5 second delay
                HandleUserWithdrawal(account);
                return;
            }
            HandleUserWithdrawal(account);
            return;
        }

        public static void ShowCurrentBalance(BankAccount account)
        {
            Console.WriteLine("Retrieving account information...");
            Thread.Sleep(800); // 0.8 second delay
            
            Console.WriteLine($"Current Balance: ${account.Balance}");
            Console.WriteLine($"Account Holder: {account.AccountName}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
        }

        public static void ShowMenu(BankAccount account)
        {
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Make Deposit");
            Console.WriteLine("3. Withdraw Funds");
            Console.WriteLine("4. Exit Menu.");
            Console.WriteLine("Choose an option 1-4.");

            string? userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    ShowCurrentBalance(account);
                    break;
                case "2":
                    HandleUserDeposit(account);
                    break;
                case "3":
                    HandleUserWithdrawal(account);
                    break;
                case "4":
                    Console.WriteLine("Thank you for banking with us. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid entry. Try again");
                    break;
            }
            Console.WriteLine("\nPress any key to continue....");
            Console.ReadKey();
            Console.Clear();
            ShowMenu(account);
        }
    }
}