using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Method newMethod = new Method();

            Console.WriteLine("Input a number to be divided by 2");
            int myNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number to be multiplied by 2.");
            int myNum2 = Convert.ToInt32(Console.ReadLine());

            newMethod.methodDivision(myNum1);

            newMethod.methodMultiplication(myNum2);



            int outcome = newMethod.methodMultiplication(myNum1, myNum2);

            Console.WriteLine("This is the result of your first number and your second number being multiplied by each other: {0}", outcome);

            Console.Read();


        }
    }
}
