using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> obj1 = new Employee<string>(); //Instantiate an Employee object with type “string” as its generic parameter.
            obj1.things = new List<string>() { "Hunter", "Teddy", "Leeroy" }; // Assign a list of strings as the property value of Things.

            Employee<int> obj2 = new Employee<int>(); //Instantiate an Employee object with type “int” as its generic parameter.
            obj2.things = new List<int>() { 1, 2, 5, 9, 17 }; // Assign a list of integers as the property value of Things.

            foreach (string obj in obj1.things)
            {
                Console.WriteLine(obj);
            }

            foreach (int obj in obj2.things)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
