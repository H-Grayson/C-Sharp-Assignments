using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment, you can use a comment to disinclude code for testing
            // Use ctrl + k + c to comment a block of code, ctrl + k + u to undo
            //Console.WriteLine("What is your name?");
            //string yourname = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourname);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plust 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';


            decimal moneyInBank = 100.5m; // m = decimal

            double heightInCentimeters = 211.30202092;

            float secondsLeft = 2.62f; //f = float;

            short temperatureOnMars = -341;

            string myName = "Hunter";

            //integer to a string
            int currentAge = 26;
            string yearsOld = currentAge.ToString();


            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();
            
        }
    }
}
