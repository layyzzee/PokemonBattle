using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class TeamBuilder
    {
        public static void BuildTeam()
        {

            //Creating a pokemon getter so new pokemon are selected each time
            Pokemon GetNewPokemon(int choice) => choice switch
            {
                1 => new Bulbasaur(),
                2 => new Charmander(),
                3 => new Squirtle(),
                4 => new Pikachu(),
                5 => new Pidgey(),
                _ => new Bulbasaur()
            };

            //Initialising
            List<Pokemon> myTeam = new List<Pokemon>();
            List<Pokemon> enemyTeam = new List<Pokemon>();
            string[] validChoices = new string[] { "1", "2", "3", "4", "5" };
            Random rand = new Random();
            Console.WriteLine("Welcome to the Pokemon Battle Game! Prepare to choose your Pokemon team");
            Thread.Sleep(1500);
            Console.Clear();
            //First Pokemon
            Console.WriteLine("Please choose your first Pokemon:");
            Console.WriteLine("\n 1. Bulbasaur \n 2. Charmander \n 3. Squirtle \n 4. Pikachu \n 5. Pidgey");
            string input1 = Console.ReadLine();
            //Was user Input valid?
            if (!validChoices.Contains(input1))
            {
                Console.WriteLine("Invalid Input. Please try again.");
                return;
            }
            int int1 = int.Parse(input1);
            Pokemon pokemon1 = GetNewPokemon(int1);
            myTeam.Add(pokemon1);
            Console.WriteLine($"You chose {pokemon1.Name} as your first Pokemon!");
            Thread.Sleep(1000);
            Console.Clear();
            //Second Pokemon
            Console.WriteLine("Please choose your second Pokemon:");
            Console.WriteLine("\n 1. Bulbasaur \n 2. Charmander \n 3. Squirtle \n 4. Pikachu \n 5. Pidgey");
            string input2 = Console.ReadLine();
            //Was user Input valid?
            if (!validChoices.Contains(input2))
            {
                Console.WriteLine("Invalid Input. Please try again.");
                return;
            }
            int int2 = int.Parse(input2);
            Pokemon pokemon2 = GetNewPokemon(int2);
            myTeam.Add(pokemon2);
            Console.WriteLine($"You chose {pokemon2.Name} as your first Pokemon!");
            Thread.Sleep(1000);
            Console.Clear();
            //Third Pokemon
            Console.WriteLine("Please choose your first Pokemon:");
            Console.WriteLine("\n 1. Bulbasaur \n 2. Charmander \n 3. Squirtle \n 4. Pikachu \n 5. Pidgey");
            string input3 = Console.ReadLine();
            //Was user Input valid?
            if (!validChoices.Contains(input3))
            {
                Console.WriteLine("Invalid Input. Please try again.");
                return;
            }
            int int3 = int.Parse(input3);
            Pokemon pokemon3 = GetNewPokemon(int3);
            myTeam.Add(pokemon3);
            Console.WriteLine($"You chose {pokemon3.Name} as your third Pokemon!");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Your team is {pokemon1.Name}, {pokemon2.Name}, and {pokemon3.Name}!");
            //Emeny myTeam
            for (int i = 0; i < 3; i++)
            {
                // Picks a random index between 1 and 5
                int enemyIdx = rand.Next(1, 6);
                enemyTeam.Add(GetNewPokemon(enemyIdx));
            }
            Console.WriteLine($"Enemy's team is {enemyTeam[0].Name}, {enemyTeam[1].Name}, and {enemyTeam[2].Name}!");
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
