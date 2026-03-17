using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public abstract class Pokemon
    {
        //Initialising Properties
        public string Name { get; init; }
        public PokemonType MyType { get; init; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }

        //Status Properties
        public bool IsFainted;
        public bool IsBurning;
        public bool IsPoisoned;
        public bool IsFrozen;
        public bool IsDizzy;
        public bool IsFlying;

        //Move List
        private static readonly Dictionary<string, (int Power, PokemonType MoveType, double Drain)> MoveList = new Dictionary<string, (int Power, PokemonType MoveType, double Drain)>
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

        //Constructor
        public Pokemon(string name, PokemonType myType, int maxHP, int attack, int defence, int speed)
        {
            Name = name;
            MyType = myType;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            Attack = attack;
            Defence = defence;
            Speed = speed;
        }
    }
}
