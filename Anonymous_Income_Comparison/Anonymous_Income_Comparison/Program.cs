using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            // Establish hourly rate of Person 1
            Console.WriteLine("Hourly Rate?");
            int hrlyRt1 = Convert.ToInt32(Console.ReadLine());

            // Establish hours worked for Person 1
            Console.WriteLine("Hours worked per week?");
            int hrsWk1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Person 2");
            Console.ReadLine();

            // Establish hourly rate of Person 2
            Console.WriteLine("Hourly Rate?");
            int hrlyRt2 = Convert.ToInt32(Console.ReadLine());

            // Establish hours worked for Person 2
            Console.WriteLine("Hours worked per week?");
            int hrsWk2 = Convert.ToInt32(Console.ReadLine());

            // multiplied weekly income by weeks in a year to determine annual salary
            int salary1 = hrlyRt1 * hrsWk1 * 52;
            int salary2 = hrlyRt2 * hrsWk2 * 52;

            // asking if salary 1 is greater than 2
            bool greater = salary1 > salary2;

            // displaying person 1 info
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.ReadLine();

            // displaying person 2 info 
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);
            Console.ReadLine();

            // Determining who makes more money
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(greater);
            Console.ReadLine();
        }
    }
}
