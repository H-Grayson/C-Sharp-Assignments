using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods Maths = new Methods();

            Console.WriteLine("Please enter a number: ");
            string userNum1 = Console.ReadLine();


            Console.WriteLine("Please enter a second number (Instructions say: Let them know they need not enter anything for the second number.) : ");
            string userNum2 = Console.ReadLine();
            int num2;

            if (!int.TryParse(userNum2, out num2))
            {
                int num1 = Convert.ToInt32(userNum1);
                Console.WriteLine("You have entered one number... Your Answer is : " + Methods.Maths(num1));
            }

            else
            {
                int num1 = Convert.ToInt32(userNum1);
                num2 = Convert.ToInt32(userNum2);
                Console.WriteLine("You have entered two numbers... Your Answer is : " + Methods.Maths(num1, num2));
            }

            Console.ReadLine();
        }
    }
}
