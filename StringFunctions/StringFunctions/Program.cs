using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Hunter";
            //string quote = "The man said,\\Hello\", Hunter. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Hunter";

            //bool trueOrFalse = name.Contains("H");
            //trueOrFalse = name.EndsWith("r");

            //int length = name.Length;

            //name = name.ToLower();

            //Console.WriteLine(name);
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Hunter");

            //Console.WriteLine(sb);
            //Console.ReadLine();

            StringBuilder myStringBuilder = new StringBuilder("Hello World!");
            myStringBuilder.Append(" I hope you are well!");
            myStringBuilder.Append(" What a beautiful day.");
            Console.WriteLine(myStringBuilder);
            Console.ReadLine();

            Console.WriteLine("Please enter a color");
            string myColor = Console.ReadLine();

            Console.WriteLine("Please enter a word");
            string myWord = Console.ReadLine();

            Console.WriteLine("Please enter a adjective");
            string myAdjective = Console.ReadLine();

            string mySentence = (myColor + " " + myWord + " " + myAdjective);
            mySentence = mySentence.ToUpper();

            Console.WriteLine(mySentence);
            Console.Read();


        }
    }
}
