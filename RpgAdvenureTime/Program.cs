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

                Console.WriteLine("After a quick drink you continue on your way");

                Console.WriteLine("You travel for what seems like hours until the sun start to set.  you need to find a place to [rest] or [continue]");

                choice = Console.ReadLine();

                if (choice.Equals("rest"))
                {
                    Console.WriteLine("you sleep peacefully through the night, you awake and continue journey.");

                }
                else if (choice.Equals("continue"))

                    Console.WriteLine("you travel through night, get lost.");




            }
            else if (choice.Equals("straight"))
            {
                Console.WriteLine("You walk for what seems like hours and come to a thick forest.");

                Console.WriteLine("You take a deep breath and begin your [trip] into the forrest, or you could wait and [camp] here for the night");

                choice = Console.ReadLine();

                if (choice.Equals("trip"))
                {
                    Console.WriteLine("You take a deep breath and step forward into the gloomy forrest. There gaps of moonlight leaving little for you to see. Out of the darkness a goblin attacks.  Do you [fight] or [run]");
                    {
                        choice = Console.ReadLine();
                        {
                            if (choice.Equals("fight"))
                                Console.WriteLine("You fight back with all your might but the goblin is faster and manages to stab you with his rusty sword. It is but a flesh wound you think and fight on finaly killing the goblin.");

                            else if (choice.Equals("run"))
                                Console.WriteLine("You push the goblin off and turn and start running.  Its so dark you dont see the rock the trips you and you fall flat on your face.  Before you can get up you feel a rust sword plung into your back... you slowly bleed out while listening to the goblin laugh.");
                        }

                        

                    }
                }
                else if (choice.Equals("camp"))
                {
                    
                    Console.WriteLine("You spend a brief time gathering some dry wood at the edge of the forrest always keeping one eye on the shadows.  Once you've collected enough wood for the night you sit down and enjoy a nice warming fire while you chew on some deer jerkey.");

                    Console.WriteLine("When you finaly wake up you realize your horse is missing as well as your supplies.  Being the quick acting adventurer you are, you quickly follow the tracks into the forrest.  At least now you will be able to see where you are going.  If you [run] you may catch whoever did this sooner, or you could go [slowly] in hopes of catching whoever stole your stuff offguard");
                    {
                        choice = Console.ReadLine();

                        if (choice.Equals("run"))
                        {
                            Console.WriteLine("You take off running as fast as you can.  The tracks are clear to follow as you race through the thick forrest.  You stumble and nearly fall flat on your face when you trip over a tree root sticking up. You find the goblin thief ready and waiting for you, time to [fight] or [flee]");

                            if (choice.Equals("run"))
                                Console.WriteLine("You turn to run but are winded from previos running and the goblin catches you and stabs his rusty sword through your back.");

                            else if (choice.Equals("fight"))

                                    Console.WriteLine("you lung at the goblin with nothing but your fists and tackle it to the ground.  After a short scuffle you manage to kill the goblin and recover all of your supplies plus your trusty horse");

                        }


                    }
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
                    Console.WriteLine("You dont have the will to help out strangers so you hustle past even as they cry out for help.");
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
