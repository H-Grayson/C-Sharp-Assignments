using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\n");

            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourname = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string coursename = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            string pagenum = Console.ReadLine();
            int pgNum = Convert.ToInt32(pagenum);

            Console.WriteLine("\nDo you need help with anything? Please answer “true” or “false.”");
            string needhelp = Console.ReadLine();
            bool ndhelp = Convert.ToBoolean(needhelp);

            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            string studyhrs = Console.ReadLine();
            int stdyhrs = Convert.ToInt32(studyhrs);

            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
