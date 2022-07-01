using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerablesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week \nIf you need help type !help"); // Prompt the user to enter the current day of the week.
            string today = Console.ReadLine();

            if (today == "!help");
            {
                foreach (DaysOfTheWeek day in Enum.GetValues(typeof(DaysOfTheWeek)))
                {
                    Console.WriteLine("\n" + day);
                }
            }
            try
            {
                DaysOfTheWeek endsWithY = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), today); // Assign the value to a variable of that enum data type you just created.
            }
            catch (Exception ex) // Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
            {
                Console.WriteLine("\nPlease enter an actual day of the week.");
            }

            
            Console.ReadLine();
        }

        public enum DaysOfTheWeek{ Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }// Create an enum for the days of the week.



    }
}
