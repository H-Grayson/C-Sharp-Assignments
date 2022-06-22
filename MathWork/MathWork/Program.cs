using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication
            Console.WriteLine("Please choose a number to be multiplied by 50");
            int by50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(50 * by50);
            Console.ReadLine();

            // Addition
            Console.WriteLine("Please choose a number to have 25 added to it");
            int add25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(25 + add25);
            Console.ReadLine();

            // Division
            Console.WriteLine("Please choose a number to divide by 12.5");
            int divishun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(divishun / 12.5);
            Console.ReadLine();

            // A way to do a true false statement for > 50
            Console.WriteLine("Please choose a number");
            int chsNum = Convert.ToInt32(Console.ReadLine());
            if (chsNum >= 50)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

            // Another way to do a true false statement for > 50
            Console.WriteLine("Please choose a number");
            int yadda = Convert.ToInt32(Console.ReadLine());
            int yidda = 50;
            bool slamma = yadda >= yidda;
            Console.WriteLine(slamma);
            Console.ReadLine();

            // Showing remainder of division
            Console.WriteLine("Please choose a number to be divided by 7");
            int tip = Convert.ToInt32(Console.ReadLine());
            int tax = 7;
            int remainder = tip % tax;
            Console.WriteLine(remainder);
            Console.ReadLine();
            
        }
    }
}
