using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Car
    {
        //Properties
        private string make;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string model;
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        private int currentSpeed;
        public int CurrentSpeed
        {
            get { return this.currentSpeed; }
            set { this.currentSpeed = value; }
        }

        private double engineSize;
        public double EngineSize
        {
            get { return this.engineSize; }
            set { this.engineSize = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine("Car Make: {0}", Make);
            Console.WriteLine("Car Model: {0}",Model);
            Console.WriteLine("Car Current Speed: {0}",CurrentSpeed);
            Console.WriteLine("Car Engine Size: {0}",EngineSize);
        }

        public override string ToString() //How it will be written to the main
        {
            return string.Format("Car Make: {0}" + "Car Model: {1}" + "Car Current Speed: {2} Car Engine Size: {3}", Make, Model, CurrentSpeed, EngineSize);
        }

        public  void Accelerate()
        {
            for (int i = 0; i < 10; i++)
            {
                CurrentSpeed += 10;
                Console.WriteLine();
                if (CurrentSpeed<=100)
                {
                    Console.WriteLine("The Accelerated Speed is: {0}", CurrentSpeed);
                }
                else
                {
                    Console.WriteLine("Max speed of {0} has been reached",100);
                }
               
            }
           
        }
    }

}
   
