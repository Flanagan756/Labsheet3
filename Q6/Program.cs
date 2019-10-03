using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1, lunch2, lunch3, lunch4, lunch5;
            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Entree = "Humburger";
            lunch1.Side = "Fries";
            lunch1.Drink = "Cola";

            lunch2.Entree = "Hot Dog";
            lunch2.Side = "Chips";
            lunch2.Drink = "Lemonade";

            lunch3.Entree = "Pizza";
            lunch3.Side = "Salade";
            lunch3.Drink = "Iced Tea";

            lunch4.Entree = "Tuna Sandwich";
            lunch4.Side = "Fruit Cup";
            lunch4.Drink = "Water";

            lunch5.Entree = "Peanut Butter Sandwich";
            lunch5.Side = "Cookie";
            lunch5.Drink = "Milk";


            Display(lunch1, lunch2, lunch3);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch4);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4, lunch5);
            
          
        }
        static void Display(params Lunch[] lunches)
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15}","Entree","Side","Drink");
            foreach (Lunch lunch in lunches)
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15}",lunch.Entree,lunch.Side, lunch.Drink);
            }
        }
    }
}
