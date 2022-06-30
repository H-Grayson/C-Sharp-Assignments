using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program : Employee
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(); //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            emp.firstName = "Sample";
            emp.lastName = "Student";

            emp.SayName(); // Call the SayName() method on the object.
            Console.ReadLine();
        }
    }
}
