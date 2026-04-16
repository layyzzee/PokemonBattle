using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class TeamBuilder
    {
        //Creating a pokemon getter so new pokemon are selected each time
        public static Pokemon GetNewPokemon(int choice)
        {
            var species = PokemonData.AllSpecies[choice - 1];
            return new Pokemon(species);
        }


        public static List<Pokemon> BuildPlayerTeam()
        {
            List<Pokemon> myTeam = new List<Pokemon>();
            string[] validChoices = { "1", "2", "3", "4", "5" };
            Console.WriteLine("Welcome to the Pokemon Battle Game! Prepare to choose your team.");
            Thread.Sleep(1000);
            Console.Clear();

            //var validOption = new List<string>();
            ////For loop to remove magic numbers
            //for (int i = 0; i < PokemonData.AllSpecies.Count; i++)
            //{
            //    while (myTeam.Count < 3)
            //    {
            //        bool validSelection = false;
            //        while (!validSelection)
            //        {
            //            validOption.Add(i.ToString());
            //            Console.WriteLine("Please choose your Pokemon:");
            //            Console.WriteLine($"{i + 1}: {PokemonData.AllSpecies[i].Name}");
            //            string input = Console.ReadLine();
            //            if (validChoices.Contains(input))
            //            {
            //                if (int.TryParse(input, out int choice))
            //                {
            //                    Pokemon p = GetNewPokemon(choice);
            //                    myTeam.Add(p);
            //                    Thread.Sleep(1000);
            //                    Console.Clear();
            //                    Console.WriteLine($"Added {p.Name} to your team!");
            //                    validSelection = true;
            //                }
            //                Console.Clear();
            //                Console.WriteLine("");
            //            }
            //            else
            //            {
            //                Console.Clear();
            //                Console.WriteLine($"Invalid Input! Please pick a number between 0 and {PokemonData.AllSpecies.Count}.");
            //            }
            //        }
            //    }
            //}

            // Loop 3 times to get 3 Pokemon
            for (int i = 1; i <= 3; i++)
            {
                bool validSelection = false;

                while (!validSelection)
                {
                    Console.WriteLine($"Please choose Pokemon #{i}:");
                    Console.WriteLine($"\n 1. {PokemonData.AllSpecies[0].Name} \n 2. {PokemonData.AllSpecies[1].Name} \n 3. {PokemonData.AllSpecies[2].Name} \n " +
                        $"4. {PokemonData.AllSpecies[3].Name} \n 5. {PokemonData.AllSpecies[4].Name}");

                    string input = Console.ReadLine();

                    if (validChoices.Contains(input))
                    {
                        int choice = int.Parse(input);
                        Pokemon p = GetNewPokemon(choice);
                        myTeam.Add(p);
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine($"Added {p.Name} to your team!");
                        validSelection = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Invalid Input! Please pick a number between 0 and {PokemonData.AllSpecies.Count}.");
                    }
                }
            }
            Console.WriteLine($"Your team is: {myTeam[0].Name}, {myTeam[1].Name}, and {myTeam[2].Name}!");
            Thread.Sleep(2000);

            return myTeam;
        }



        public static List<Pokemon> BuildEnemyTeam()
        {
            //Initialising
            List<Pokemon> enemyTeam = new List<Pokemon>();
            string[] validChoices = new string[] { "1", "2", "3", "4", "5" };
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                // Picks a random index between 1 and 5
                int enemyIdx = rand.Next(1, 6);
                enemyTeam.Add(GetNewPokemon(enemyIdx));
            }
            Console.WriteLine($"Enemy's team is {enemyTeam[0].Name}, {enemyTeam[1].Name}, and {enemyTeam[2].Name}!");
            Thread.Sleep(5000);
            Console.Clear();
            return (enemyTeam);
        }

    }
}
