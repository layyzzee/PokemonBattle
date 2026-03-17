using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Pidgey : Pokemon
    {
        public Pidgey() : base("Pidgey", PokemonType.Normal, 36, 48, 32, 63)
        {
            LearnedMoves.Add("Tackle");
            LearnedMoves.Add("Gust");
            LearnedMoves.Add("Wing Attack");
            LearnedMoves.Add("Scratch");

        }
    }
}
