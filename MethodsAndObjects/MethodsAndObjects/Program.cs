using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(); // Inside of the Main method, instantiate and initialize an Employee object

            emp.FirstName = "Sample"; //  with a first name of “Sample” 
            emp.LastName = "Student"; // and a last name of “Student”.
            emp.Id = 1;

            emp.SayName(); // Call the superclass method SayName() on the Employee object.
            Console.ReadLine();

        }
    }
}
