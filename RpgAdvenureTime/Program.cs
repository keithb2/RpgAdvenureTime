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

            TheStart();

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

        private static void TheStart()
        {
            Console.WriteLine("Welcome to the world, " + PlayerOne.Name + ", " + "this journey is the greatest ever!");


            Console.WriteLine("Your journey begins at a crossroads.  To the [west] you see a small town in the distance, to the [north] you see a dark and gloomy forrest, to the [east] you see a massive city on the horizon.  Which way will you go, brave adventurer?");

            var choice = Console.ReadLine();

            if (choice.Equals("west"))
            {
                Console.WriteLine("You begin your journey walking towards the small town.  The sun will be setting soon so you need to hurry to make it before dark.");
            }

            else if (choice.Equals("north"))
            {
                Console.WriteLine("You start walking north to the dark scary woods, as you get closer you notice no aniamls making noise.  The forrest is creepy silent.");

            }

            else if (choice.Equals("east"))
            {
                Console.WriteLine("You begin your long trip towards the big city, making sure to keep an eye on the creepy forrest in case something were to attack");

            }
        }

        private static void StartWest()
        {
            Console.WriteLine(PlayerOne.Name + ", " + "you arrive at the small town just as the sun sets and night envelopes the small town.  There is still a few people moving around closing up shops and finishing last of the days work.  The rest of the town has seemed to filled the local tavern");

            Console.WriteLine("You can see one [market] stall still open, the owner seems to be waiting for late comers.  The [tavern] is only place that is open publicly");

            var choice = Console.ReadLine();

            if (choice.Equals(tavern))
            {
                Console.WriteLine(You enter the tavern)
            }
        }
    }
}
