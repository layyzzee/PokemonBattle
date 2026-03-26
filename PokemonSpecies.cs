using PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class PokemonSpecies
    {
        public string Name { get; init; }
        public PokemonType Type { get; init; }
        public int MaxHP { get; init; }
        public int Attack { get; init; }
        public int Defence { get; init; }
        public int Speed { get; init; }
        public List<string> MoveSet { get; set; } = new List<string>();
    }
}
