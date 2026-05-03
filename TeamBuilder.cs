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
        public static Pokemon GetNewPokemon(string choice)
        {
            var species = PokemonData.AllSpecies.FirstOrDefault(p => p.Name == choice);
            return new Pokemon(species);
        }


        public static List<Pokemon> BuildPlayerTeam()
        {
            List<Pokemon> myTeam = new List<Pokemon>();
            Console.WriteLine("Welcome to the Pokemon Battle Game! Prepare to choose your team.");
            Thread.Sleep(1000);
            Console.Clear();

            // Loop 3 times to get 3 Pokemon
            for (int i = 1; i <= 3; i++)
            {
                bool validSelection = false;

                while (!validSelection)
                {
                    Console.WriteLine($"Please choose Pokemon #{i}:");
                    Console.WriteLine("Please type the name of your first pokemon, or type random to pick a random pokemon, or type help for a list of pokemon");

                    string input = Console.ReadLine()?.Trim().ToLower();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Please select a valid input. If you need help type 'help'");
                        continue;
                    }

                    if (input == "help")
                    {
                        foreach (var pokemon in PokemonData.AllSpecies)
                        {
                            Console.WriteLine(pokemon.Name);
                        }
                        continue;
                    }
                    if (input == "random")
                    {
                        Random rand = new Random();
                        input = PokemonData.AllSpecies[rand.Next(PokemonData.AllSpecies.Count)].Name.ToLower();
                    }
                    string pokemonName = input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
                    if (PokemonData.AllSpecies.Any(p => p.Name.ToLower() == input))
                    {
                        Pokemon p = GetNewPokemon(pokemonName);
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
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                // Picks a random index between 1 and 5
                int randomIndex = rand.Next(PokemonData.AllSpecies.Count);
                var species = PokemonData.AllSpecies[randomIndex];
                enemyTeam.Add(new Pokemon (species));
            }
            Console.WriteLine($"Enemy's team is {enemyTeam[0].Name}, {enemyTeam[1].Name}, and {enemyTeam[2].Name}!");
            Thread.Sleep(5000);
            Console.Clear();
            return (enemyTeam);
        }

    }
}
