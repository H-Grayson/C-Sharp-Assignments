using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee : Person, IQuittable // Create another class called Employee and have it inherit from the Person class. POLYMORPHISM ASSIGNMENT : Have your Employee class from the previous drill inherit that interface
    {
        public override void SayName() // Implement the SayName() method inside of the Employee class.
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit() // POLYMORPHISM ASSIGNMENT implement the Quit() method in any way you choose.
        {
            Console.WriteLine("Goodbye!");
        }

    }
}
