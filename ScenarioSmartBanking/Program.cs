using System;
using System.Collections.Generic;
using System.Linq;

// -------- Custom Exceptions --------

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string msg) : base(msg) { }
}

class MinimumBalanceException : Exception
{
    public MinimumBalanceException(string msg) : base(msg) { }
}

class InvalidTransactionException : Exception
{
    public InvalidTransactionException(string msg) : base(msg) { }
}

// -------- Abstract Class --------

abstract class BankAccount
{
    public string AccountNumber;
    public string CustomerName;
    public decimal Balance;

    public BankAccount(string accNo, string name, decimal balance)
    {
        AccountNumber = accNo;
        CustomerName = name;
        Balance = balance;
    }

    public abstract decimal CalculateInterest();
}

// -------- Savings --------

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accNo, string name, decimal balance)
        : base(accNo, name, balance)
    {
        if (balance < 1000)
            throw new MinimumBalanceException("Minimum 1000 required.");
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance - amount < 1000)
            throw new MinimumBalanceException("Minimum balance rule.");
        Balance -= amount;
    }

    public override decimal CalculateInterest()
    {
        return Balance * 0.04m;
    }
}

// -------- Current --------

class CurrentAccount : BankAccount
{
    public CurrentAccount(string accNo, string name, decimal balance)
        : base(accNo, name, balance) { }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance - amount < -20000)
            throw new InsufficientBalanceException("Overdraft exceeded.");
        Balance -= amount;
    }

    public override decimal CalculateInterest()
    {
        return 0;
    }
}

// -------- Loan --------

class LoanAccount : BankAccount
{
    public LoanAccount(string accNo, string name, decimal loan)
        : base(accNo, name, loan) { }

    public void Deposit(decimal amount)
    {
        throw new InvalidTransactionException("Deposit not allowed.");
    }

    public void Withdraw(decimal amount)
    {
        throw new InvalidTransactionException("Withdraw not allowed.");
    }

    public override decimal CalculateInterest()
    {
        return Balance * 0.10m;
    }
}

// -------- Main --------

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        while (true)
        {
            Console.WriteLine("\n1.Add 2.Display 3.Report 4.Exit");
            int ch = int.Parse(Console.ReadLine());

            try
            {
                if (ch == 1)
                {
                    Console.WriteLine("1.Savings 2.Current 3.Loan");
                    int type = int.Parse(Console.ReadLine());

                    Console.Write("AccNo: ");
                    string acc = Console.ReadLine();

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Balance: ");
                    decimal bal = decimal.Parse(Console.ReadLine());

                    if (type == 1)
                        accounts.Add(new SavingsAccount(acc, name, bal));
                    else if (type == 2)
                        accounts.Add(new CurrentAccount(acc, name, bal));
                    else
                        accounts.Add(new LoanAccount(acc, name, bal));

                    Console.WriteLine("Added!");
                }

                else if (ch == 2)
                {
                    foreach (var a in accounts)
                        Console.WriteLine(a.AccountNumber + " | " + a.CustomerName + " | " + a.Balance + " | " + a.GetType().Name);
                }

                else if (ch == 3)
                {
                    Console.WriteLine("Balance > 50000:");
                    foreach (var a in accounts.Where(x => x.Balance > 50000))
                        Console.WriteLine(a.CustomerName);

                    Console.WriteLine("Total Balance: " + accounts.Sum(x => x.Balance));

                    Console.WriteLine("Top 3:");
                    foreach (var a in accounts.OrderByDescending(x => x.Balance).Take(3))
                        Console.WriteLine(a.CustomerName);

                    Console.WriteLine("Grouped:");
                    foreach (var g in accounts.GroupBy(x => x.GetType().Name))
                    {
                        Console.WriteLine(g.Key);
                        foreach (var a in g)
                            Console.WriteLine("  " + a.CustomerName);
                    }

                    Console.WriteLine("Starts with R:");
                    foreach (var a in accounts.Where(x => x.CustomerName.StartsWith("R")))
                        Console.WriteLine(a.CustomerName);
                }

                else if (ch == 4)
                    break;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
