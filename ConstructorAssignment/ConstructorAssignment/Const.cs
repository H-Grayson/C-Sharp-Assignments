using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Const
    {
        const int numberPizzas = 4; // Create a const variable.


        public Const() : this(numberPizzas)
        {

        }

        public Const(int slices)
        { // Create a variable using the keyword “var.” Below
            var howMany = numberPizzas; //  Chain two constructors together.
            slices = howMany; 
            Console.WriteLine(slices);
        }
    }
}
