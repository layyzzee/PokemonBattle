using PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    //Handles primarily the Math of the battle, such as damage modifier calculations, status effect calculations, etc.
    public static class CombatEngine
    {
        //Static dictionary for strong/weak reference
        private static readonly Dictionary<PokemonType, (List<PokemonType> Strong, List<PokemonType> Weak)> TypeChart =
    new Dictionary<PokemonType, (List<PokemonType>, List<PokemonType>)>
{
    { PokemonType.Normal, (new List<PokemonType>(), new List<PokemonType>{ PokemonType.Rock }) },
    { PokemonType.Fire, (new List<PokemonType>{ PokemonType.Grass, PokemonType.Bug, PokemonType.Ice }, new List<PokemonType>{ PokemonType.Fire, PokemonType.Water, PokemonType.Rock }) },
    { PokemonType.Water, (new List<PokemonType>{ PokemonType.Fire, PokemonType.Ground, PokemonType.Rock }, new List<PokemonType>{ PokemonType.Water, PokemonType.Grass, PokemonType.Dragon }) },
    { PokemonType.Grass, (new List<PokemonType>{ PokemonType.Water, PokemonType.Ground, PokemonType.Rock }, new List<PokemonType>{ PokemonType.Fire, PokemonType.Grass, PokemonType.Poison, PokemonType.Flying, PokemonType.Bug, PokemonType.Dragon }) },
    { PokemonType.Electric, (new List<PokemonType>{ PokemonType.Water, PokemonType.Flying }, new List<PokemonType>{ PokemonType.Grass, PokemonType.Electric, PokemonType.Dragon }) },
    { PokemonType.Ice, (new List<PokemonType>{ PokemonType.Grass, PokemonType.Ground, PokemonType.Flying, PokemonType.Dragon }, new List<PokemonType>{ PokemonType.Water, PokemonType.Ice }) }, // Note: Neutral vs Fire in Gen 1
    { PokemonType.Fighting, (new List<PokemonType>{ PokemonType.Normal, PokemonType.Ice, PokemonType.Rock }, new List<PokemonType>{ PokemonType.Poison, PokemonType.Flying, PokemonType.Psychic, PokemonType.Bug }) },
    { PokemonType.Poison, (new List<PokemonType>{ PokemonType.Grass, PokemonType.Bug }, new List<PokemonType>{ PokemonType.Poison, PokemonType.Ground, PokemonType.Rock, PokemonType.Ghost }) },
    { PokemonType.Ground, (new List<PokemonType>{ PokemonType.Fire, PokemonType.Electric, PokemonType.Poison, PokemonType.Rock }, new List<PokemonType>{ PokemonType.Grass, PokemonType.Bug }) },
    { PokemonType.Flying, (new List<PokemonType>{ PokemonType.Grass, PokemonType.Fighting, PokemonType.Bug }, new List<PokemonType>{ PokemonType.Electric, PokemonType.Rock }) },
    { PokemonType.Psychic, (new List<PokemonType>{ PokemonType.Fighting, PokemonType.Poison }, new List<PokemonType>{ PokemonType.Psychic }) },
    { PokemonType.Bug, (new List<PokemonType>{ PokemonType.Grass, PokemonType.Poison, PokemonType.Psychic }, new List<PokemonType>{ PokemonType.Fire, PokemonType.Fighting, PokemonType.Flying }) },
    { PokemonType.Rock, (new List<PokemonType>{ PokemonType.Fire, PokemonType.Ice, PokemonType.Flying, PokemonType.Bug }, new List<PokemonType>{ PokemonType.Fighting, PokemonType.Ground }) },
    { PokemonType.Ghost, (new List<PokemonType>{ PokemonType.Ghost }, new List<PokemonType>()) },
    { PokemonType.Dragon, (new List<PokemonType>{ PokemonType.Dragon }, new List<PokemonType>()) }
};

        //Damage multiplier
        public static double DamageMultiplier(PokemonType movetype, PokemonType defender)
        {
            //No modifier if pokemon type not in typechart
            if (!TypeChart.ContainsKey(movetype)) return Constants.NORMAL_DAMAGE_MULTIPLIER;
            var (strongAgainst, weakAgainst) = TypeChart[movetype];
            if (strongAgainst.Contains(defender)) return 2.0;
            if (weakAgainst.Contains(defender)) return 0.5;
            return 1.0;
        }

        //Final Damage calculation
        public static int CalculateDamage(Pokemon attacker, Pokemon defender, string movename)
        {
            var move = PokemonData.MoveList[movename];
            double typeMult = DamageMultiplier(move.MoveType, defender.Type);
            //STAB (Same type attack bonus)
            double stab = (attacker.Type == defender.Type) ? 1.5 : 1.0;
            double baseDamage = (double)(move.Power * attacker.Attack) / (double)defender.Defence;
            int totalDamage = (int)(baseDamage * typeMult * stab);
            //Dividing by 5 to avoid needing massive hp
            int finalDamage = totalDamage / 5;
            return finalDamage;
        }

    }
}
