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
            Method newMethod = new Method(); // In the Main() method, instantiate that class.

            Console.WriteLine("Input a number to be divided by 2"); //Have the user enter a number.
            int myNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input a number to be multiplied by 2.");
            int myNum2 = Convert.ToInt32(Console.ReadLine());

            int myNum3;

            newMethod.methodDivision(myNum1); // Call the method on that number.

            newMethod.methodMultiplication(myNum2);

            newMethod.Addition(out myNum3);


            int outcome = newMethod.methodMultiplication(myNum1, myNum2);
            Console.WriteLine("This is the result of your first number and your second number being multiplied by each other: {0}", outcome); // 

            outcome = staticMethod.Subtraction(myNum1);
            Console.WriteLine("\nYour number with 5 subtracted is: {0}", outcome);


            Console.WriteLine("\nThe result of the addition method is: {0}", myNum3);
            

            Console.Read();


        }
    }
}
