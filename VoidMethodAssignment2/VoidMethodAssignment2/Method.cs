using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment2
{
    public class Method
    {
        public void methodDivision(int myNum1) // create a void method that outputs an integer
        {
            int outcome = myNum1 / 2; // Have the method divide the data passed to it by 2.
            Console.WriteLine("\nYour answer divided by two is: {0}", outcome + "\n"); // 3. Display the output to the screen.
        }
        public int methodMultiplication(int myNum2) // I believe using methodMultiplication in both instances would be overloading
        {
            int outcome = myNum2 * 2;
            Console.WriteLine("Your answer multiplied by two is: {0}", outcome + "\n");
            return outcome;
        }

        public int methodMultiplication(int myNum1, int myNum2)
        {
            int outcome = myNum1 * myNum2;
            return outcome;
        }

        public void Addition(out int myNum3) // Create a method with output parameters.
        {
            myNum3 = 15;
            myNum3 += myNum3;

        }


    }
}
