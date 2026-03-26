using PokemonBattle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base("Bulbasaur", PokemonType.Grass | PokemonType.Poison, 62, 39, 45, 41)
        {
            LearnedMoves.Add("Tackle");
            LearnedMoves.Add("Vine Whip");
            LearnedMoves.Add("Slam");
            LearnedMoves.Add("Absorb");

        }
    }
}