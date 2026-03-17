using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class BattleManager
    {
        //Initialise
        private List<Pokemon> PlayerTeam;
        private List<Pokemon> BotTeam;
        private Pokemon PlayerActivePokemon;
        private Pokemon EnemyActivePokemon;

        public BattleManager(List<Pokemon> myTeam, List<Pokemon> enemyTeam)
        {
            PlayerTeam = myTeam;
            BotTeam = enemyTeam;
            PlayerActivePokemon = PlayerTeam[0];
            EnemyActivePokemon = BotTeam[0];
        }

        public void StartBattle()
        {
            Console.WriteLine("The battle has begun!");
            Console.WriteLine($"Your active Pokemon is {PlayerActivePokemon.Name} and the enemy's active Pokemon is {EnemyActivePokemon.Name}.");
            //Battle logic will go here
            
            //Who goes first
            if(PlayerActivePokemon.Speed >= EnemyActivePokemon.Speed)
            {
                Console.WriteLine("You go first!");
                //Player's turn logic will go here
            }
            else
            {
                Console.WriteLine("The enemy goes first!");
                //Enemy's turn logic will go here
            }

            //Attacking

        }
        public void StopBattle()
        {
            if(PlayerTeam.All(p => p.IsFainted))
            {
                Console.WriteLine("You have no more Pokemon left! You lose!");
            }
            else if(BotTeam.All(p => p.IsFainted))
            {
                Console.WriteLine("The enemy has no more Pokemon left! You win!");
            }
        }
    }
}
