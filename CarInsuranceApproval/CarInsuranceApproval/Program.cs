using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please state True or False.");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int spdTckt = Convert.ToInt32(Console.ReadLine());

            bool ageQual = age > 15;
            bool duiQual = dui == false;
            bool spdTcktQual = spdTckt <= 3;

            bool insQual = ageQual == duiQual == spdTcktQual == true;


            Console.WriteLine("Qualified?");
            Console.WriteLine(insQual);
            Console.ReadLine();
        }
    }
}
