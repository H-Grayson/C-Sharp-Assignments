using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numList = new List<int>() { 10, 15, 20, 25, 30 };
            Console.WriteLine("Please give a number less than 10 to divide by.");
            int numNum = Convert.ToInt32(Console.ReadLine());

            foreach (int num in numList)
            {
                int answer = num / numNum;
                Console.WriteLine(num);
            }
        }

        catch (FormatException)
        {
            Console.WriteLine("Please type a whole number.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please choose a number other than zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}
