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
                Console.WriteLine("You arive at a dusty oasis with barely any water for your horse");
            }
            else if (choice.Equals("straight"))
            {
                Console.WriteLine("You walk for what seems like hours and come to a thick forest.");
            }
            else if (choice.Equals("right"))
            {
                Console.WriteLine("As you begin your journey to the right you come across a broken down carava... do you [kill] them and take loot or do you [help] them?");

                choice = Console.ReadLine();

                if (choice.Equals("kill"))
                {
                    // do something
                }
                else if (choice.Equals("help"))
                {

                    // do something else
                }
                else
                {
                    // do ashir
                }

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
