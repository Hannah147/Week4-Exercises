using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount JohnsAccount = new BankAccount(1234, "John", 200);

            BankAccount MarysAccount = new BankAccount(4321, "Mary", 2000);

            WriteLine(JohnsAccount);

            WriteLine(MarysAccount);

            MarysAccount.LodgeFunds(20);

            JohnsAccount.WithdrawFunds(100);
        }
    }

    class BankAccount
    {
        private int accountNumber;
        private string accountHolder;
        private double accountBalance;

        public BankAccount()
        {

        }

        public BankAccount(int accountNumber, string accountHolder, double accountBalance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolder = accountHolder;
            this.AccountBalance = accountBalance;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public double LodgeFunds(double amount)
        {
            AccountBalance += amount;
            WriteLine($"{AccountHolder} Balance after Lodgement : {AccountBalance}");
            return AccountBalance;
        }

        public double WithdrawFunds(double amount)
        {
            AccountBalance -= amount;
            WriteLine($"{AccountHolder} Balance after Lodgement : {AccountBalance}");
            return AccountBalance;
        }

        public override string ToString()
        {
            return "\nAccount Number \t: " + accountNumber + "\nAccount Holder \t: " + accountHolder + "\nCurrent Balance : " + accountBalance + "\n";
        }

    }
}
