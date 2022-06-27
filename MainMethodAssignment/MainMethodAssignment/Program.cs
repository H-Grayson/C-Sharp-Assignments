using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("25 + 10 =  " + Methods.Math(25));

            Console.WriteLine("3.5 * 10 =   " + Methods.Math(3.5m));

            Console.WriteLine("25 / 5 =   " + Methods.Math("25"));

            Console.ReadLine();
        }
    }
}
