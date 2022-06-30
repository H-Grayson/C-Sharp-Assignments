using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment2
{
    public class Method
    {
        public void methodDivision(int myNum1)
        {
            int outcome = myNum1 / 2;
            Console.WriteLine("\nYour answer divided by two is: {0}", outcome + "\n");
        }
        public int methodMultiplication(int myNum2)
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


    }
}
