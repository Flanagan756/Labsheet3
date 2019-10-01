using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class CashRegister
    {
        public string name { get; set; }
        public double total { get; set; }
        public int items { get; set; }
       
        public void AddItem(int addItem, double price, string register)
        {
            Console.WriteLine("You have added {0} item(s) worth {1:c} into register {2}",addItem,price,register);

            total += price;
            items += addItem;
        }
        public void DisplayTotals(int finalItems, double finalTotal, string register)
        {
            Console.WriteLine("The totals for {0} are:",register);
            Console.WriteLine("Total Items: {0}",finalItems);
            Console.WriteLine("Total Cash: {0:c}",finalTotal);
              
        }
            
         
       

    }
}
