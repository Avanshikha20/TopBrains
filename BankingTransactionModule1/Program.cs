using System;

namespace BankingTransactionModule
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public decimal Deposit(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }

                Balance += amount;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive.");
                }

                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }

                Balance -= amount;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Balance;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            Account account = new Account
            {
                AccountNumber = accountNumber,
                Balance = initialBalance
            };

            Console.Write("Enter transaction amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    account.Deposit(amount);
                    break;

                case 2:
                    account.Withdraw(amount);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("Final Balance: " + account.Balance);
        }
    }
}

