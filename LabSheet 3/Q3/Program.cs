using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount ba1 = new BankAccount();
            ba1.AccountNumber = 0001;
            ba1.AccountHolder = "Harry Phillips";
            ba1.Balance = 12000;
            BankAccount ba2 = new BankAccount();
            ba2.AccountNumber = 0002;
            ba2.AccountHolder = "Sarah Benedict";
            ba2.Balance = 6000;

            ba1.DisplayAccountInfo();
            ba2.DisplayAccountInfo();


            ba2.Deposit(3000,ba2.AccountNumber);
            ba1.Widthdraw(200, ba1.AccountNumber);
        }
    }
}
