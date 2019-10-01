using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //gives attributes values
            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Focus";
            car1.CurrentSpeed = 19;
            car1.EngineSize = 1.6;

            Car car2 = new Car();
            car2.Make = "Skoda";
            car2.Model = "Horizon";
            car2.CurrentSpeed = 22;
            car2.EngineSize = 0.7;

            //Displays Car info using method from car class
            Console.WriteLine("Car 1");
            car1.DisplayCarInfo();

            Console.WriteLine("Car 2");
            car2.DisplayCarInfo();


        }
       
      
    }
}
