using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAssignment_OptParams_
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods maths = new Methods();

            Console.WriteLine("Please enter a number: ");
            string userNum1 = Console.ReadLine();


            Console.WriteLine("Please enter a second number - DO NOT HAVE TO Your Answer is : ");
            string userNum2 = Console.ReadLine();

            int num2;
            if (!int.TryParse(userNum2, out num2))
            {
                int num1 = Convert.ToInt32(userNum1);
                Console.WriteLine("You have entered one number. Your Answer is : " + Methods.Maths(num1));
            }

            else
            {
                int num1 = Convert.ToInt32(userNum1);
                num2 = Convert.ToInt32(userNum2);
                Console.WriteLine("You have entered two numbers. Your Answer is : " + Methods.Maths(num1, num2));
            }

            Console.ReadLine();
        }
    }
}
