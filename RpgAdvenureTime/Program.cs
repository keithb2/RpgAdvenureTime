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

                Console.WriteLine("As you take a sip of water as does your horse you hear someone approach. You spin around in time to see a haggard toothless man.  \"Got any spare change?\"");

                Console.WriteLine("This man looks like trouble, give him some spare [change] or [tell] him to leave");

                if (choice.Equals("change"))
                {
                    Console.WriteLine("You toss a few spare coins at his feet, the man then heads back the way he came.");
                }
                 else if(choice.Equals("tell"))
                {
                    Console.WriteLine("The haggard looking man jumps backwards in alarm as you scream at him to go away");
                }
            }
            else if (choice.Equals("straight"))
            {
                Console.WriteLine("You walk for what seems like hours and come to a thick forest.");

                Console.WriteLine("You take a deep breath and begin your [trip] into the forrest, or you could wait and [camp] here for the night");
                
                if (choice.Equals("trip"))
                {
                    Console.WriteLine("You take a deep breath and step forward into the gloomy forrest.");
                }
                else if (choice.Equals("camp"))
                {
                    Console.WriteLine("You spend a brief time gathering some dry wood at the edge of the forrest always keeping one eye on the shadows.  Once you've collected enough wood for the night you sit down and enjoy a nice warming fire while you chew on some deer jerkey.");

                    Console.WriteLine("When you finaly wake up you realize your horse is missing as well as your supplies.  Being the quick acting adventurer you are, you quickly follow the tracks into the forrest.  At least now you will be able to see where you are going.")
                }
            }
            else if (choice.Equals("right"))
            {
                Console.WriteLine("As you begin your journey to the right you come across a broken down carava... do you [kill] them and take loot or do you [help] them?");

                choice = Console.ReadLine();

                if (choice.Equals("kill"))
                {
                    Console.WriteLine("You approach the two farmers struggling to repair the wagon wheel.  The first man looks up in time to see your dagger puncture his right eye.");
                }
                else if (choice.Equals("help"))
                {

                    Console.WriteLine("you greet the obviously exhasted farmers and offer a hand.  within moments you have the wheel back on and the farmers are on there way.");
                }
                else
                {
                    Console.WriteLine("You have to will to help out strangers so you hustle past even as they cry out for help.");
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
