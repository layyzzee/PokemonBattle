using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Squirtle : Pokemon
    {
        public Squirtle() : base("Squirtle", PokemonType.Water, 44, 48, 65, 43)
        {
            LearnedMoves.Add("Tackle");
            LearnedMoves.Add("Water Gun");
            LearnedMoves.Add("Bubble");
            LearnedMoves.Add("Bite");
        }
    }
}
