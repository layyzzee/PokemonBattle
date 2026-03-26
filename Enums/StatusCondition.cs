using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public enum StatusCondition
    {
        None = 0,
        Fainted = 1,
        Burning = 2,
        Poison = 4,
        Confusion = 8,
        Paralysis = 16,
        Sleep = 32,
        Flinch = 64,
        Taunt = 128
    }
}
