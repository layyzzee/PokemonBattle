using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Pikachu : Pokemon
    {
        public Pikachu() : base("Pikachu", PokemonType.Electric, 45, 45, 45, 45)
        {
            LearnedMoves.Add("Tackle");
            LearnedMoves.Add("Thunder Shock");
            LearnedMoves.Add("Spark");
            LearnedMoves.Add("Scratch");
        }
    }
}
