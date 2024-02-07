// See https://aka.ms/new-console-template for more information
using System;

namespace BankExample
{
    class BankAccount
    {
        public string accountHolder;
        public int balance;

        public BankAccount(string accountHolder,int balance)
        {
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited Amount" + amount + "New Balance:" + balance);
        }

        public void withdraw(int amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("Withdra Amount" + amount + "New Balance:" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name" + accountHolder);
            Console.WriteLine("balance" + balance);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount=new BankAccount("Raju",1000);
            bankAccount.DisplayDetails();
            bankAccount.Deposit(500);
            bankAccount.DisplayDetails();
            bankAccount.withdraw(200);
            bankAccount.DisplayDetails();

        }
    }
}