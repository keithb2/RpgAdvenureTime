using System;

namespace RpgAdvenureTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the greatest adventure EVER!");
            Console.WriteLine("Which direction would you like to go? You have so many adventures to look forward too...[left/straight/right]");

            var choice = Console.ReadLine();

            if(choice.Equals("left"))
            {
                Console.WriteLine("You arrive at a dusty oasis with barely any water for you and your horse");

                Console.WriteLine("As you take a sip of water as does your horse you hear someone approach. You spin around in time to see a haggard toothless man.  \"Got any spare change?\"");

                Console.WriteLine("This man looks like trouble, give him some spare [change] or [tell] him to leave");

                choice = Console.ReadLine();

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
                {
                    Console.WriteLine("you travel through night, get lost.");

                    Console.WriteLine("you spend the majority of the night trying to find your way back to the road.");
                }
            }
            else if (choice.Equals("straight"))
            {
                Console.WriteLine("You walk for what seems like hours and come to a thick forest.");

                Console.WriteLine("You take a deep breath and begin your [trip] into the forrest, or you could wait and [camp] here for the night");

                choice = Console.ReadLine();

                if (choice.Equals("trip"))
                {
                    Trip();
                }
                else if (choice.Equals("camp"))
                {
                    Console.WriteLine("You spend a brief time gathering some dry wood at the edge of the forrest always keeping one eye on the shadows.  Once you've collected enough wood for the night you sit down and enjoy a nice warming fire while you chew on some deer jerkey.");

                    Console.WriteLine("When you finaly wake up you realize your horse is missing as well as your supplies.  Being the quick acting adventurer you are, you quickly follow the tracks into the forrest.  At least now you will be able to see where you are going.  If you [run] you may catch whoever did this sooner, or you could go [slowly] in hopes of catching whoever stole your stuff offguard");

                    choice = Console.ReadLine();

                    if (choice.Equals("run"))
                    {
                        Console.WriteLine("You take off running as fast as you can.  The tracks are clear to follow as you race through the thick forrest.  You stumble and nearly fall flat on your face when you trip over a tree root sticking up. You find the goblin thief ready and waiting for you, time to [fight] or [flee]");

                        if (choice.Equals("run"))
                        {
                            Console.WriteLine("You turn to run but are winded from previous running and the goblin catches you and stabs his rusty sword through your defensless back.");
                        }
                        else if (choice.Equals("fight"))
                        {
                            GoblinFightA();
                        }
                    }
                    else if (choice.Equals("slowly"))
                    {
                        Console.WriteLine("move slowly through woods find horse and supplies by a goblins campfire.  Luckily for you the lazy goblin has fallen asleep. You can [sneak] or [attack]");

                        choice = Console.ReadLine();

                        if (choice.Equals("sneak"))
                        {
                            Console.WriteLine("you sneak in and take back your stuff");

                            Console.WriteLine("As you sneak into the camp you see the goblin you see a prisoner. you can [rescue] or [ignore]");

                            choice = Console.ReadLine();

                            if (choice.Equals("rescue"))
                            {
                                Console.WriteLine("you rescue prisoner.");
                            }

                            else if (choice.Equals("ignore"))
                            {
                                Console.WriteLine("you ignore");
                            }
                        }
                        else if (choice.Equals("attack"))
                        {
                            Console.WriteLine("you attack.");

                            Console.WriteLine("goblin is dead, you notice injured prisoner you can [loot] or [revive]");

                            choice = Console.ReadLine();

                            if (choice.Equals("loot"))
                            {
                                Console.WriteLine("you find a gold pocket watch.");

                            }
                            else if (choice.Equals("revive"))
                            {
                                Console.WriteLine("you save prisoner");

                            }
                                
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
                    Console.WriteLine("You approach the two farmers struggling to repair the wagon wheel.  The first man looks up in time to see your dagger puncture his right eye.  The second farmer falls with a quick slash to his throat.");

                    Console.WriteLine("you loot the caravan, and as you finish you whitness one of the farmers rise from the dead");

                    Console.WriteLine("you can either [fight] or [run]");
                    {
                        choice = Console.ReadLine();

                        if (choice.Equals("fight"))
                        {
                            Console.WriteLine("you kill zombie");
                        }
                        else if (choice.Equals("run"))
                        {
                            Console.WriteLine("you run away as fast as you can.");
                        }
                    }
                }
                else if (choice.Equals("help"))
                {
                    HelpingFarmers();
                }
                else
                {
                    Console.WriteLine("You dont have the will to help out strangers so you hustle past even as they cry out for help.");

                    Console.WriteLine("You push aside the guilt of not helping those who need it and continue down the winding dirt road.");

                    Console.WriteLine("As you continue your travels you see a massive walled city in the distance.  This could be the perfect place to earn some coin as a mercenary");

                    Console.WriteLine("You arrive at the city, it's night time and you see two guards at the main gate.  There are several campfires burning nearby surrounded by weary travelers and merchants.  You can approach [guards/merchants/travelers]");

                    choice = Console.ReadLine();

                    if (choice.Equals("guards"))
                    {
                        Console.WriteLine("you approach guards");
                    }
                    
                    else if (choice.Equals("merchants"))
                    {
                        Console.WriteLine("you approach merchants.");
                    }

                    else if (choice.Equals("travelers"))
                    {
                        Console.WriteLine("you approach travelers");
                    }
                            
                }
            }
            else
            {
                Console.WriteLine("you lose.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void GoblinFightA()
        {
            Console.WriteLine("you lung at the goblin with nothing but your fists and tackle it to the ground.  After a short scuffle you manage to kill the goblin and recover all of your supplies plus your trusty horse");

            Console.WriteLine("seems like things are looking up for you now, you got everything you lost back AND you can see a road ahead that leads to some sort of civilisation.");

            Console.WriteLine("as you return to the road you can go [left] or [right] to the left is a small town, to the right is a big city.");

            var choice = Console.ReadLine();

            if (choice.Equals("left"))
            {
                GoLeftGobo();
            }
            else if (choice.Equals("right"))
            {
                GoRightGobo();
            }
        }

        private static void GoRightGobo()
        {
            Console.WriteLine("you go right.");
        }

        private static void GoLeftGobo()
        {
            Console.WriteLine("you go left");
        }

        private static void HelpingFarmers()
        {
            Console.WriteLine("you use [muscle] or [brains]");

            var choice = Console.ReadLine();

            if (choice.Equals("muscle"))
            {
                Muscle();
            }
            else if (choice.Equals("brains"))
            {
                Brains();
            }
        }

        private static void Brains()
        {
            Console.WriteLine("use brains");
        }

        private static void Muscle()
        {
            Console.WriteLine("use muscle");
        }

        private static void Trip()
        {
            Console.WriteLine("You take a deep breath and step forward into the gloomy forrest. There gaps of moonlight leaving little for you to see. Out of the darkness a goblin attacks.  Do you [fight] or [run]");

            var choice = Console.ReadLine();

            if (choice.Equals("fight"))
            {
                FightGoblin();
            }
            else if (choice.Equals("run"))
            {
                RunFromGoblin();
            }
        }

        private static void RunFromGoblin()
        {
            Console.WriteLine("You push the goblin off and turn and start running.  Its so dark you dont see the rock the trips you and you fall flat on your face.  Before you can get up you feel a rust sword plung into your back... you slowly bleed out while listening to the goblin laugh.");
        }

        private static void FightGoblin()
        {
            Console.WriteLine("You fight back with all your might but the goblin is faster and manages to stab you with his rusty sword. It is but a flesh wound you think and fight on finaly killing the goblin.");
        }
    }
}
