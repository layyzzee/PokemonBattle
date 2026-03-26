using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattle.Enums;

namespace PokemonBattle
{
    public class Pokemon
    {
        //Initialising Properties
        public string Name { get; init; }
        public PokemonType MyType { get; init; }
        public int MaxHP { get; set; }        
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }

        //Properties that change mid battle
        public int CurrentHP { get; set; }

        //Status Properties
        public bool IsFainted;
        public bool IsBurning;
        public bool IsPoisoned;
        public bool IsFrozen;
        public bool IsDizzy;
        public bool IsFlying;

 
        //Constructor
        public Pokemon(PokemonSpecies species)
        {
            Name = species.Name;
            MyType = species.Type;
            MaxHP = species.MaxHP;
            CurrentHP = species.MaxHP;
            Attack = species.Attack;
            Defence = species.Defence;
            Speed = species.Speed;
        }
    }
}
