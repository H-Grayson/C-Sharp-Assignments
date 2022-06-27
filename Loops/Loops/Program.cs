using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Watch me count to 5!");
            int i = 0;

            while (i < 5)
            {
                Console.WriteLine(i);

                i++;

            }    
            

            Console.WriteLine("Now to guess a number 1-20!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Try higher!");
                        Console.WriteLine("Guess another number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Try higher!");
                        Console.WriteLine("Guess another number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That is correct!");
                        isGuessed = true;
                        break;
                    case 12:
                        Console.WriteLine("Try lower!");
                        Console.WriteLine("Guess another number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 17:
                        Console.WriteLine("Try lower!");
                        Console.WriteLine("Guess another number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are Wrong!");
                        Console.WriteLine("Guess another number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isGuessed);
            
            Console.Read();
        }
    }
}
