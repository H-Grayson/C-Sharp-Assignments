using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee //Create an Employee class with 
    {
        public int id { get; set; } // Id

        public static bool operator ==(Employee emp1, Employee emp2) // In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
        {
            return emp1.id == emp2.id;
        }

        public static bool operator !=(Employee emp1, Employee emp2) // == has to have a matching != for overloading operators
        {
            return emp1.id == emp2.id;
        }

        public string firstName { get; set; } // firstName property
        public string lastName { get; set; } // lastName property

    }
}
