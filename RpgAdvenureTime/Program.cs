using System;

namespace RpgAdvenureTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the greatest adventure EVER!");
            Console.WriteLine("Which direction would you like to go? [left/straight/right]");

            var choice = Console.ReadLine();

            if(choice.Equals("left"))
            {
                // what to do?
            }
            else if (choice.Equals("straight"))
            {
                // what to do?
            }
            else if (choice.Equals("right"))
            {
                // what to do?
            }
            else
            {
                Console.WriteLine("you lose.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
