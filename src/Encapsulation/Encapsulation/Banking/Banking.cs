using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public double Balance
        {
            get { return _balance; }
            private set { _balance = value < 0 ? 0.0 : value; }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Withdrawal amount is invalid or insufficient balance.");
            }
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
