using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            int userAge = 1;
            while (!validAnswer)
            {
                try // Exceptions must be handled using “try/catch.”
                {
                    Console.WriteLine("Hello! What is your age?"); // Ask the user for their age.
                    validAnswer = int.TryParse(Console.ReadLine(), out userAge);
                    if (userAge <= 0)
                    {
                        Console.WriteLine("Please enter a valid age, you are certainly older than that (no zeros or negatives)."); // Display appropriate error messages if the user enters zero or negative numbers.
                        Console.ReadLine();
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid age!"); // Display a general message if an exception was caused by anything else.
                    Console.ReadLine();
                    return;
                }
            }
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime birthday = today.AddYears(-userAge);
            Console.WriteLine("You were born in the year {0}", birthday); // Display the year the user was born.
            Console.Read(); // I hope this is okay, if I need to rewrite to display just he year I can. 
        }
    }
}
