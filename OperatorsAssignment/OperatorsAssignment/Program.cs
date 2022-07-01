using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.firstName = "Patrick ";
            emp1.id = 1;
            emp2.firstName = "Star ";
            emp2.id = 2;

            Console.WriteLine("Are both employee id's the same?\n\n");
            if (emp1 == emp2)
            {
                Console.WriteLine(emp1.firstName + "and " + emp2.firstName + "have matching employee id numbers!");
            }
            else
            {
                Console.WriteLine(emp1.firstName + "and " + emp2.firstName + "do not have matching employee id numbers.");
            }
            Console.ReadLine();
        }
    }
}
