using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_and_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CashRegister cash1 = new CashRegister();
            cash1.name = "Reg1";
            cash1.total = 0;
            cash1.items = 0;
            CashRegister cash2 = new CashRegister();
            cash2.name = "Reg2";
            cash2.total = 0;
            cash2.items = 0;

            cash1.AddItem(3, 3.30, cash1.name);
            cash1.AddItem(2, 30, cash1.name);
            cash1.AddItem(4, 44, cash1.name);

            cash2.AddItem(5, 90.90, cash2.name);
            cash2.AddItem(1, 0.30, cash2.name);
            cash2.AddItem(1, 5.30, cash2.name);

            Console.WriteLine();
            cash1.DisplayTotals(cash1.items, cash1.total, cash1.name);
            Console.WriteLine();
            cash2.DisplayTotals(cash2.items, cash2.total, cash2.name);

           
            double allTotal = cash1.total + cash2.total;
            int allItems = cash1.items + cash2.items;

            Console.WriteLine();
            Console.WriteLine("Total money for all registers is {0:c}", allTotal);
            Console.WriteLine("Total items for all registers is {0}", allItems);

        }
    }
}
