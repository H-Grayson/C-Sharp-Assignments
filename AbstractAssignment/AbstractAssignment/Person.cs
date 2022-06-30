using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public abstract class Person // Create an abstract class called Person with two properties
    {
       public string firstName { get; set; } // string firstName
        public string lastName { get; set; } // string lastName.

        public abstract void SayName(); // Give it the method SayName().
    }
}
