using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = new DateTime();
            currentDate = DateTime.Now;
            // Console.WriteLine(currentDate); Prints the current date and time to the console. Added into the time change 
            Console.WriteLine("Please enter a random number between 1-10."); // Asks the user for a number.

                        int userNum = Convert.ToInt32(Console.ReadLine());
            DateTime hoursAddedDate = currentDate.AddHours(userNum);
            Console.WriteLine("\nTodays date is {0}. \n\nWith the number you've added, we've added the that amount of time in hours the time would be: \n\n{1}!", currentDate, hoursAddedDate); // Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.Read();
        }
    }
}
