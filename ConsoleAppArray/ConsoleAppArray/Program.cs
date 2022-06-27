using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // Part 1
        string[] favColor = { "Red ", "Orange ", "Yellow ", "Green ", "Blue ", };
        Console.WriteLine("Please name an object");
        string userText = Console.ReadLine();

        for (int i = 0; i < favColor.Length; i++)
        {
            Console.WriteLine(favColor[i] + userText);

        }

        // another way to do the previous action
        //foreach (string color in favColor)
        //{
        //    Console.WriteLine(color + " " + userText);
        //}

        Console.ReadLine();

        // Part 2
        for (int j = 0; j <= 16; j += 4) //Used the <= operator requested in Part here.
        {
            Console.WriteLine(j);
        }

        Console.ReadLine();

        // Part 3 used <= operator in previous for loop

        for (int s = 0; s < 5; s += 1)
        {
            Console.WriteLine(s);
        }

        Console.ReadLine();


        // Part 4
        List<string> usStates = new List<string> { "Texas", "Ohio", "Florida", "Georgia", "California" };
        Console.WriteLine("Find out where each state falls in terms of highschool football recruiting ranking. Please choose from \nTexas \nOhio \nFlorida \nGeorgia \nCalifornia\n");

        bool stateExists = false;

        do
        {
            string userGuess = Console.ReadLine();

            int i;
            for (i = 0; i < usStates.Count; i++)
            {
                if (usStates[i] == userGuess)
                {
                    stateExists = true;
                    break;
                }
            }
            switch (i)
            {

                case 0:
                    Console.WriteLine("You have chosen {0}", userGuess);
                    stateExists = true;
                    break;

                case 1:
                    Console.WriteLine("You have chosen {0}", userGuess);
                    stateExists = true;
                    break;

                case 2:
                    Console.WriteLine("You have chosen {0}", userGuess);
                    stateExists = true;
                    break;

                case 3:
                    Console.WriteLine("You have chosen {0}", userGuess);
                    stateExists = true;
                    break;

                case 4:
                    Console.WriteLine("You have chosen {0}", userGuess);
                    stateExists = true;
                    break;

                default:
                    Console.WriteLine("This was an incorrect entry, please try again.");
                    Console.WriteLine("Find out where each state falls in terms of highschool football recruiting ranking.");
                    break;
            }
        }
        while (!stateExists);



        //Part 5


        List<string> theAnimals = new List<string> { "Dog", "Dog", "Cat", "Bat", "Rat" }; //Ask the user to select text to search for in the list.
        Console.WriteLine("\nPlease choose an animal from the list below: \nDog \nDog \nCat \nBat \nRat ");
        bool match = false;



        

        do
        {
            string animalThink = Console.ReadLine();

            for (int i = 0; i < theAnimals.Count; i++)
            {
                if (theAnimals[i] == animalThink)
                {
                    match = true;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Your answer was not one listed above.. please try again"); // I'm having difficulty having this only repeat in the case that it has not ended
            Console.WriteLine("Please choose another animal from the list\n");
        }
        while (!match);

        // Part 6


        List<string> myClients = new List<string> { "Sarah", "Daniel", "Doug", "Sarah", "Tom" };


        IEnumerable<string> duplicates = myClients.GroupBy(x => x)
            .SelectMany(g => g.Skip(1));

        foreach (string Client in myClients)
        {
            Console.WriteLine("\n" + Client);
            
            if (duplicates.Contains(Client))
            {
                Console.WriteLine("The user " + Client + " appears in the list more than once.\n");
            }

        }
        Console.ReadLine();
    }
}
