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

            Console.WriteLine("You chose " + choice + ".");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
