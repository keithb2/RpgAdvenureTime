using System;
using RpgAdvenureTime.Models;
using RpgAdvenureTime.Services;

namespace RpgAdvenureTime
{
    class Program
    {
        private static BattleService _battleService = new BattleService();

        private static Player PlayerOne { get; set; }

        static void Main(string[] args)
        {
            CharacterCreation();
            
            Console.WriteLine("Welcome to the greatest adventure EVER, " + PlayerOne.Name + "!");
            Console.WriteLine("Which direction would you like to go? You have so many adventures to look forward too...[left/straight/right/down]");
            
            var choice = Console.ReadLine();
            
            if (choice.Equals("left"))
            {
                OasisStart();
            }
            else if (choice.Equals("straight"))
            {
                GoStraightPath();
            }
            else if (choice.Equals("right"))
            {
                ChooseRightPath();
            }
            else if (choice.Equals("down"))
            {
                DugAHoleDown();
            }
            else
            {
                Console.WriteLine("you lose.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void CharacterCreation()
        {
            PlayerOne = new Player();
            Console.WriteLine("What's your name, dude?");
            PlayerOne.Name = Console.ReadLine();

            Console.WriteLine("What's your class, broski? You a warrior, mage, or rogue?");
            PlayerOne.CharacterClass = Console.ReadLine();

            PlayerOne.Weapon = new Weapon();
            PlayerOne.Weapon.Name = "rusty sword";
            PlayerOne.Weapon.Damage = 3;
            PlayerOne.Health = 15;
        }

        private static void RightDarkness()
        {
            Console.WriteLine("you go right into the dakness. end of tunnel you find [zombies]");
        }

        private static void LeftDarkness()
        {
            Console.WriteLine("you go left into darkness.  end of tunnel you find [treasure]");

            var choice = Console.ReadLine();

            if (choice.Equals("treasure"))
            {
                Treasure();
            }
        }

        private static void Treasure()
        {
            Console.WriteLine("you loot treasure");
        }

        private static void DugAHoleDown()
        {
            Console.WriteLine("you dig down until you find a tunnel, you can go [left] or [right]");

            var choice = Console.ReadLine();

            if (choice.Equals("left"))
            {
                LeftDarkness();
            }
            else if (choice.Equals("right"))
            {
                RightDarkness();
            }
        }

        private static void ChooseRightPath()
        {
            Console.WriteLine("As you begin your journey to the right you come across a broken down caravan... do you [kill] them and take loot or do you [help] them?");

            var choice = Console.ReadLine();

            if (choice.Equals("kill"))
            {
                KillFarmers();
            }
            else if (choice.Equals("help"))
            {
                HelpingFarmers();
            }
        }

        private static void TravelingToCity()
        {

            Console.WriteLine("As you continue your travels you see a massive walled city in the distance.  This could be the perfect place to earn some coin as a mercenary");

            Console.WriteLine("You arrive at the city, it's night time and you see two guards at the main gate.  There are several campfires burning nearby surrounded by weary travelers and merchants.  You can approach [guards/merchants/travelers]");

            var choice = Console.ReadLine();

            if (choice.Equals("guards"))
            {
                ApproachGuardsCity();
            }

            else if (choice.Equals("merchants"))
            {
                ApproachMerchantsCity();
            }

            else if (choice.Equals("travelers"))
            {
                ApproachTravelersCity();
            }
        }

        private static void ApproachGuardsCity()
        {
            Console.WriteLine("you approach guards");

            Console.WriteLine("One guard demands [bribe] the other guard [challenges].");

            var choice = Console.ReadLine();

            if (choice.Equals("bribe"))
            {
                Bribe();
            }

            else if (choice.Equals("challenges"))
            {
                Challenges();
            }
        }

        private static void Challenges()
        {
            Console.WriteLine("you arm wrestle guard and win, you gain entrance to city");
        }

        private static void Bribe()
        {
            Console.WriteLine("you bribe guard, gain entrance to city");
        }

        private static void ApproachMerchantsCity()
        {
            Console.WriteLine("you approach merchants.");

            Console.WriteLine("you see 3 main merchants, one sells [weapons], one sells [armor], and the other sells [potions]");

            var choice = Console.ReadLine();

            if (choice.Equals("weapons"))
            {
                WeaponBuy();
            }
            else if (choice.Equals("armor"))
            {
                ArmorBuy();
            }
            else if (choice.Equals("potions"))
            {
                PotionBuy();
            }
        }

        private static void PotionBuy()
        {
            Console.WriteLine("you buy potions");
        }

        private static void ArmorBuy()
        {
            Console.WriteLine("you buy armor.");
        }

        private static void WeaponBuy()
        {
            Console.WriteLine("you buy weapon.");
        }

        private static void ApproachTravelersCity()
        {
            Console.WriteLine("you approach travelers");
        }

        private static void OasisStart()
        {
            Console.WriteLine(PlayerOne.Name + ", the " + PlayerOne.CharacterClass + ", arrives at a dusty oasis with barely any water for you and your horse");
            
            Console.WriteLine("As you take a sip of water as does your horse you hear someone approach. You spin around in time to see a haggard toothless man.  \"Got any spare change?\"");

            Console.WriteLine("This man looks like trouble, give him some spare [change] or [tell] him to leave");

            var choice = Console.ReadLine();

            if (choice.Equals("change"))
            {
                OasisBeggarGiveChange();
            }
            else if (choice.Equals("tell"))
            {
                OasisBeggarTell();
            }
        }

        private static void OasisDeparture()
        {
            Console.WriteLine("After a quick drink you continue on your way");

            Console.WriteLine(PlayerOne.Name + ", " + "You travel for what seems like hours until the sun start to set.  you need to find a place to [rest] or [continue]");

            var choice = Console.ReadLine();

            if (choice.Equals("rest"))
            {
                CampOasis();
            }
            else if (choice.Equals("continue"))
            {
                ContinueTravels();
            }
        }

        private static void OasisBeggarGiveChange()
        {
            Console.WriteLine(PlayerOne.Name + ", You toss a few spare coins at his feet, the man then heads back the way he came.");

            OasisDeparture();
        }

        private static void OasisBeggarTell()
        {
            Console.WriteLine("The haggard looking man jumps backwards in alarm as you scream at him to go away");

            OasisDeparture();
        }

        private static void CampOasis()
        {
            Console.WriteLine("you sleep peacefully through the night, you awake and continue journey.");
        }

        private static void ContinueTravels()
        {
            Console.WriteLine("you travel through night, get lost.");

            Console.WriteLine("you spend the majority of the night trying to find your way back to the road.");
        }

        private static void GoStraightPath()
        {

            Console.WriteLine(PlayerOne.Name + ", the " + PlayerOne.CharacterClass + ", " + "You walk for what seems like hours and come to a thick forest.");

            Console.WriteLine("You take a deep breath and begin your [trip] into the forrest, or you could wait and [camp] here for the night");

            var choice = Console.ReadLine();

            if (choice.Equals("trip"))
            {
                Trip();
            }
            else if (choice.Equals("camp"))
            {
                GoblinACampStart();
            }
        }

        private static void GoblinACampStart()
        {
            Console.WriteLine(PlayerOne.Name + ", When you finaly wake up you realize your horse is missing as well as your supplies.  Being the quick acting adventurer you are, you quickly follow the tracks into the forrest.  At least now you will be able to see where you are going.  If you [run] you may catch whoever did this sooner, or you could go [slowly] in hopes of catching whoever stole your stuff offguard");

            var choice = Console.ReadLine();

            if (choice.Equals("run"))
            {
                GoblinARun();
            }
            else if (choice.Equals("slowly"))
            {
                SneakingToGoblinCampsite();
            }
        }

        private static void SneakingToGoblinCampsite()
        {

            if (PlayerOne.CharacterClass.Equals("rogue"))
            {
                Console.WriteLine("move slowly through woods find horse and supplies by a goblins campfire.  Luckily for you the lazy goblin has fallen asleep. You can [sneak] or [attack]");
            }
            else
            {
                Console.WriteLine("move slowly through woods find horse and supplies by a goblins campfire.  Luckily for you the lazy goblin has fallen asleep. You can [attack]");
            }

            var choice = Console.ReadLine();

            if (choice.Equals("sneak") && PlayerOne.CharacterClass.Equals("rogue"))
            {
                choice = SneakByGoblin();
            }
            else if (choice.Equals("attack"))
            {
                AttackOption2();

            }
        }

        private static void GoblinARun()
        {
            Console.WriteLine("You take off running as fast as you can.  The tracks are clear to follow as you race through the thick forrest.  You stumble and nearly fall flat on your face when you trip over a tree root sticking up. You find the goblin thief ready and waiting for you, time to [fight] or [flee]");

            var choice = Console.ReadLine();

            if (choice.Equals("run"))
            {
                RunFromGoblinA();
            }
            else if (choice.Equals("fight"))
            {
                GoblinFightA();
            }
        }

        private static void RunFromGoblinA()
        {
            Console.WriteLine("You turn to run but are winded from previous running and the goblin catches you and stabs his rusty sword through your defensless back.");
        }

        private static void KillFarmers()
        {
            Console.WriteLine("You approach the two farmers struggling to repair the wagon wheel.  The first man looks up in time to see your dagger puncture his right eye.  The second farmer falls with a quick slash to his throat.");

            Console.WriteLine("you loot the caravan, and as you finish you whitness one of the farmers rise from the dead");

            Console.WriteLine("you can either [fight] or [run]");

            var choice = Console.ReadLine();

            if (choice.Equals("fight"))
            {
                KillZombie();
            }
            else if (choice.Equals("run"))
            {
                RunFromZombie();
            }
        }

        private static void RunFromZombie()
        {
            Console.WriteLine("you run away as fast as you can.");

            TravelingToCity();
        }

        private static void KillZombie()
        {
            var zombie = new Monster
            {
                Name = "Zombie",
                Damage = 1,
                Health = 5
            };
            
            var result = _battleService.Fight(PlayerOne, zombie);

            if (result.Equals(BattleResult.PlayerWon))
            {
                Console.WriteLine("the," + PlayerOne.CharacterClass + ", kills the zombie");
                TravelingToCity();
            }
            else
            {
                Console.WriteLine("you died");
            }
        }

        private static string SneakByGoblin()
        {
            string choice;
            Console.WriteLine("you sneak in and take back your stuff");

            Console.WriteLine("As you sneak into the camp you see the goblin you see a prisoner. you can [rescue], or [ignore]");

            choice = Console.ReadLine();

            if (choice.Equals("rescue"))
            {
                RescueGoblinPrisoner();
            }

            else if (choice.Equals("ignore"))
            {
                IgnoreGoblinPrisoner();
            }

            return choice;
        }

        private static void IgnoreGoblinPrisoner()
        {
            Console.WriteLine("you ignore");
        }

        private static void RescueGoblinPrisoner()
        {
            Console.WriteLine("you rescue prisoner.");
        }

        private static void AttackOption2()
        {
            Console.WriteLine("you attack.");

            var goblin = new Monster
            {
                Name = "Goblin",
                Damage = 2,
                Health = 8
            };

            var result = _battleService.Fight(PlayerOne, goblin);
            
            Console.WriteLine("goblin is dead, you notice injured prisoner you can [loot] or [revive]");

            var choice = Console.ReadLine();

            if (choice.Equals("loot"))
            {
                Loot();

            }
            else if (choice.Equals("revive"))
            {
                Revive();

            }
        }

        private static void Revive()
        {
            Console.WriteLine("you save prisoner");
        }

        private static void Loot()
        {
            Console.WriteLine("you find a gold pocket watch.");
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
            Console.WriteLine(PlayerOne.Name + "you go left");

            Console.WriteLine("As you travel down the road you can see that the small town is empty.  You enter the town and see several buildings [house/store/shack/church]");

            var choice = Console.ReadLine();

            if (choice.Equals("house"))
            {
                Console.WriteLine(PlayerOne.Name + "You enter a nice looking house");
            }

            else if (choice.Equals("store"))
            {
                Console.WriteLine(PlayerOne.Name + "You enter store");
            }

            else if (choice.Equals("shack"))
            {
                Console.WriteLine(PlayerOne.Name + "You enter shack");
            }

            else if (choice.Equals("church"))
            {
                Console.WriteLine(PlayerOne.Name + "You enter the church and its occupied by two bandits");

                Console.WriteLine("The bandits charge at you, prepare to [fight], or [flee]");


                if (Console.ReadLine().Equals("fight"))
                {
                    var bandits = new Monster
                    {
                        Name = "Bandits",
                        Damage = 4,
                        Health = 8
                    };

                    var result = _battleService.Fight(PlayerOne, bandits);

                    Console.WriteLine("You defeated the bandits");

                }

                else if (Console.ReadLine().Equals("flee"))
                {
                    Console.WriteLine("You run away like a coward");

                    Console.WriteLine("As you run away you hear the laughter of the bandits trail away.  You find yourself back on the road.");
                }
            }
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

            TravelingToCity();
        }

        private static void Muscle()
        {
            Console.WriteLine("use muscle");

            TravelingToCity();
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
