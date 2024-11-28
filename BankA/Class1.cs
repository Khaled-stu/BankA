using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BankA
{
    public class BankAccount
    {
         public static int TotalAccounts;
        double Balance = 200;
        string CustomerID = "";


     


        public BankAccount(string ID) //constructor
        {
            CustomerID = ID;
            TotalAccounts = TotalAccounts + 1;


        }

        public BankAccount() //constructor
        {
            TotalAccounts = TotalAccounts + 1;

        }

        public bool Deposit(double n)
        {
            if (n > 0)
            {
                Balance += n;
                return true;
            }
            return false;
        }

        public bool Withdraw(double n)
        {
            if (Balance >= n && n > 0)
            {
                Balance -= n;
                return true;
            }
            return false;
        }

        public double CheckBalance()
        {
            return Balance;
        }

        public bool Transfer(BankAccount ToAccount, double Amount)
        {
            if (this.Withdraw(Amount))
            {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }
        
    }
}

