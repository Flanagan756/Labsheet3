using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class BankAccount
    {
  

        public int AccountNumber { get; set; }   
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Number: {0}",AccountNumber);
            Console.WriteLine("Account Holder: {0}", AccountHolder);
            Console.WriteLine("Balance: {0:c}", Balance);
        }
        public override string ToString() //How it will be written to the main
        {
            return string.Format("Account Number: {0}" + "Account Holder: {1}" + "Balance: {2}",AccountNumber,AccountHolder,Balance);
        }
        public void Deposit(decimal input, int accountNum)
        {
            Console.WriteLine();
            Console.WriteLine("You have deposited {0:c} into account {1}",input,accountNum);
            Balance += input;
            Console.WriteLine("Your new balance is for account {0} is {1:c}",accountNum,Balance);
        }
        public void Widthdraw(decimal input, int accountNum)
        {
            Console.WriteLine();
            if (input>Balance)
            {
                Console.WriteLine("Sorry you do not have enough fund to take out of this account");
            }
            else
            {
                Balance = Balance - input;
                Console.WriteLine("You have taken {0:c} from account {1}", input, accountNum);
                Console.WriteLine("Your new balance for account {0} is {1:c}", accountNum, Balance);
            }
       
        }

    }
}
