using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    internal class Account
    {
        double Balance { get; set; }
        int AccountNumber { get; set; }
        Customer AccountOwner { get; set; }

        static int AccountCounter = 0;

        public Account(double Balance, Customer AccountOwner)
        {
            this.Balance = Balance;
            this.AccountOwner = AccountOwner;
            this.AccountNumber = AccountCounter++;
        }

        public static void deposit() { }
        public static double withdraw(double Balance, double sumToWithdraw) 
        {
            if (sumToWithdraw > Balance )
            {
                Console.WriteLine("Not enough funds");
            }
            else
            {
                Balance -= sumToWithdraw;
            }
            return Balance;
        }
        public static void showBalance() { }
        public static void transfer() { }       
    }
}
