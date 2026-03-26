using PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class PokemonAllNew
    {
        //Moveset unique per pokemon
        

        // This is your "Master List" of every Pokémon in your game
        public static readonly List<PokemonSpecies> AllSpecies = new List<PokemonSpecies>
        {
            new PokemonSpecies {
                Name = "Squirtle", Type = PokemonType.Water,
                MaxHP = 44, Attack = 48, Defence = 65, Speed = 43,
                MoveSet = new List<string> { "Tackle", "Water Gun" }
        },
            new PokemonSpecies {
                Name = "Charmander", Type = PokemonType.Fire,
                MaxHP = 39, Attack = 52, Defence = 43, Speed = 65,
                MoveSet = new List<string> { "Scratch", "Ember" }
        },
        // Add as many as you want here!
    };

            // Helper function to find a Pokémon by name
            public static PokemonSpecies Get(string name)
                => AllSpecies.FirstOrDefault(s => s.Name == name);

        //Move List
        public readonly Dictionary<string, (int Power, PokemonType MoveType, double Drain)> MoveList = new Dictionary<string, (int Power, PokemonType MoveType, double Drain)>
        {
            //Normal
            {"Tackle", (35, PokemonType.Normal, 0)},
            {"Scratch", (35, PokemonType.Normal, 0)},
            {"Slam", (40, PokemonType.Normal, 0)},

            //Fire
            {"Ember", (30, PokemonType.Fire, 0)},
            {"Incinerate", (40, PokemonType.Fire, 0)},
            {"Fire Punch", (40, PokemonType.Fire, 0)},
            {"Fire Fang", (45, PokemonType.Fire, 0)},

            //Water
            {"Water Gun", (35, PokemonType.Water, 0)},
            {"Bubble", (30, PokemonType.Water, 0)},
            {"Aqua Jet", (35, PokemonType.Water, 0)},
            {"Water Pulse", (40, PokemonType.Water, 0)},

            //Grass
            {"Vine Whip", (35, PokemonType.Grass, 0)},
            {"Razor Leaf", (40, PokemonType.Grass, 0)},
            {"Absorb", (25, PokemonType.Grass, 0.25)},
            {"Leafage", (40, PokemonType.Grass, 0)},

            //Electric
            {"Thunder Shock", (40, PokemonType.Electric, 0)},
            {"Spark", (40, PokemonType.Electric, 0)},
            {"Bolt Strike", (40, PokemonType.Electric, 0)},
            
            //Poison
            {"Poison sting", (25, PokemonType.Poison, 0)},
            {"Acid", (25, PokemonType.Poison, 0)},

            //Flying
            {"Gust", (30, PokemonType.Normal, 0)},
            {"Wing Attack", (40, PokemonType.Normal, 0)}
        };
        public List<string> LearnedMoves { get; set; } = new List<string>();
        public int GetPowerMove(string moveName) => MoveList[moveName].Power;
        public PokemonType GetMoveType(string moveName) => MoveList[moveName].MoveType;

    }
}
