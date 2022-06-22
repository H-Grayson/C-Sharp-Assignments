using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // && and operator and/and
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            // || or operator true or true
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            // == equal to
            Console.WriteLine(true == true);
            Console.WriteLine(true == false);
            Console.WriteLine(false == false);

            //  != not equal to
            Console.WriteLine(true != true);
            Console.WriteLine(true != false);
            Console.WriteLine(false != false);

            // ^ XOR, one or another is true, but not both
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            Console.ReadLine();


        }
    }
}
