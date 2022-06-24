using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the packages weight?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Thread.Sleep(2000);
                return;
            }

            Console.WriteLine("What is the packages width? Please use whole inches.");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the packages height? Please use whole inches.");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the packages length? Please use whole inches.");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            // adding Width, Height, Length to determine dimension eligibility
            if (pkgWidth + pkgHeight + pkgLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Thread.Sleep(2000);
                return;
            }
            // multiplying Width, Height, Length to determine pkg cost
            int pkgQuote = (((pkgHeight * pkgWidth * pkgLength) * pkgWeight) / 100);

            Console.WriteLine("Your estimated total for shipping this package is: " + pkgQuote + "$");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
