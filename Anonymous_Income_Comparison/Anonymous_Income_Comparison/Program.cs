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

            Console.WriteLine("Hourly Rate?");
            int hrlyRt1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hrsWk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int hrlyRt2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int hrsWk2 = Convert.ToInt32(Console.ReadLine());

            int salary1 = hrlyRt1 * hrsWk1 * 52;
            int salary2 = hrlyRt2 * hrsWk2 * 52;

            bool greater = salary1 > salary2;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(greater);
            Console.ReadLine();
        }
    }
}
