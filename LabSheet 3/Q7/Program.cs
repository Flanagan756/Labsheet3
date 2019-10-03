using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] name = new string[5];
            int[] enrolNum = new int[5];

            SchoolDemo school1, school2, school3, school4, school5;
            school1 = new SchoolDemo();
            school2 = new SchoolDemo();
            school3 = new SchoolDemo();
            school4 = new SchoolDemo();
            school5 = new SchoolDemo();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter school name: ");
                name[i] = Console.ReadLine();
                

                Console.Write("Enter enrollment: ");
                enrolNum[i] = int.Parse(Console.ReadLine());

            }

            school1.Name = name[0];
            school1.Enrollment = enrolNum[0];

            school2.Name = name[1];
            school2.Enrollment = enrolNum[1];

            school3.Name = name[2];
            school3.Enrollment = enrolNum[2];

            school4.Name = name[3];
            school4.Enrollment = enrolNum[3];

            school5.Name = name[4];
            school5.Enrollment = enrolNum[4];

            Console.WriteLine("{0} has {1} students",school1.Name,school1.Enrollment);

            Console.WriteLine("{0} has {1} students", school2.Name, school2.Enrollment);

            Console.WriteLine("{0} has {1} students", school3.Name, school3.Enrollment);

            Console.WriteLine("{0} has {1} students", school4.Name, school4.Enrollment);

            Console.WriteLine("{0} has {1} students", school5.Name, school5.Enrollment);


        }
     
    }
}
