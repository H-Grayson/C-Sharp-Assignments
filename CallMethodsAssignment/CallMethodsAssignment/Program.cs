using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number for math operations to be used on.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userNum + " + 5 = " + methods.Addition(userNum));

            Console.WriteLine(userNum + " - 5 = " + methods.Subtraction(userNum));

            Console.WriteLine(userNum + " / 2 = " + methods.Division(userNum));

            Console.ReadLine();
        }
    }
}
