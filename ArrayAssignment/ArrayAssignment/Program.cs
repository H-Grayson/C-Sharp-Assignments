using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created an array
            string[] stringArray = new string[5];
            stringArray[0] = "Dog";
            stringArray[1] = "Cat";
            stringArray[2] = "Giraffe";
            stringArray[3] = "Elephant";
            stringArray[4] = "Panther";

            //Asked user to choose an index # 1-4
            Console.WriteLine("Please Choose an index 0-4!");
            int animalNumber = Convert.ToInt32(Console.ReadLine());
            if (animalNumber >= 5)
            { 
                Console.WriteLine("Index does not exist.");
                Console.ReadLine();
            }



            Console.WriteLine(stringArray[animalNumber]);
            Console.ReadLine();

            //Created an array
            int[] intArray = new int[5];
            intArray[0] = 7;
            intArray[1] = 13;
            intArray[2] = 17;
            intArray[3] = 36;
            intArray[4] = 77;

            //Asked user to choose an index # 1-4
            Console.WriteLine("Please Choose a number 0-4!");
            int intNumber = Convert.ToInt32(Console.ReadLine());
            if (intNumber >= 5)
            {
                Console.WriteLine("Index does not exist.");
                Console.ReadLine();
            }
            Console.WriteLine(intArray[intNumber]);
            Console.ReadLine();

            //Created a list
            List<string> stringList = new List<string>();
            stringList.Add("Howdy, you have chosen 0");
            stringList.Add("Howdy, you have chosen 1");
            stringList.Add("Howdy, you have chosen 2");
            stringList.Add("Howdy, you have chosen 3");
            stringList.Add("Howdy, you have chosen 4");

            //Asked user to choose an index # 1-4
            Console.WriteLine("Please Choose a string number 0-4!");
            int stringNumber = Convert.ToInt32(Console.ReadLine());
            if (stringNumber >= 5)
            {
                Console.WriteLine("Index does not exist.");
                Console.ReadLine();
            }

            Console.WriteLine(stringList[stringNumber]);
            Console.ReadLine();
        }
    }
}
