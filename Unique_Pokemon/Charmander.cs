using PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Charmander : Pokemon
    {
        public Charmander() : base("Charmander", PokemonType.Fire, 39, 52, 43, 65)
        {
            LearnedMoves.Add("Tackle");
            LearnedMoves.Add("Ember");
            LearnedMoves.Add("Fire Punch");
            LearnedMoves.Add("Scratch");
        }
    }
}
