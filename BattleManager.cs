using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattle.Enums;

namespace PokemonBattle
{
    public class BattleManager
    {
        //Initialise
        private List<Pokemon> PlayerTeam;
        private List<Pokemon> EnemyTeam;
        private Pokemon PlayerActivePokemon;
        private Pokemon EnemyActivePokemon;
        Random rand = new Random();

        public BattleManager(List<Pokemon> myTeam, List<Pokemon> enemyTeam)
        {
            PlayerTeam = myTeam;
            EnemyTeam = enemyTeam;
            PlayerActivePokemon = PlayerTeam[0];
            EnemyActivePokemon = EnemyTeam[0];
        }

        public void StartBattle()
        {
            Console.WriteLine($"Which Pokemon would you like to start with?\n1: {PlayerTeam[0].Name}\n2: {PlayerTeam[1].Name}\n3: {PlayerTeam[2].Name}");
            string? input = Console.ReadLine();
            if (int.Parse(input) >= 1 && int.Parse(input) <= 3)
            {
                var inputIndex = int.Parse(input);
                Console.WriteLine($"I choose you {PlayerTeam[inputIndex - 1].Name}");
                PlayerActivePokemon = PlayerTeam[inputIndex - 1];
                Console.Clear();
            }
            bool playerGoesFirst = PlayerActivePokemon.Speed >= EnemyActivePokemon.Speed;
            Console.WriteLine(playerGoesFirst ? "Your Pokemon is faster!\nYou go first!" : "Enemy Pokemon is faster!\nYou go second!");
            Console.WriteLine("The battle has begun!");
            Thread.Sleep(1000);
            Console.Clear();
            while (IsBattleActive())
            {
                bool isTurnTaken = false;
                while (!isTurnTaken)
                {
                    Console.WriteLine($"Your Team: {PlayerTeam[0].Name}, {PlayerTeam[0].CurrentHP}/{PlayerTeam[0].MaxHP} HP, {PlayerTeam[1].Name}, " +
                        $"{PlayerTeam[1].CurrentHP}/{PlayerTeam[1].MaxHP} HP, {PlayerTeam[2].Name}, {PlayerTeam[2].CurrentHP}/{PlayerTeam[2].MaxHP} HP");
                    Console.WriteLine($"Enemy Team: {EnemyTeam[0].Name}, {EnemyTeam[0].CurrentHP}/{EnemyTeam[0].MaxHP} HP\n" +
                        $"{EnemyTeam[1].Name}, {EnemyTeam[1].CurrentHP}/{EnemyTeam[1].MaxHP} HP\n{EnemyTeam[2].Name}, {EnemyTeam[2].CurrentHP}/{EnemyTeam[2].MaxHP} HP");
                    Console.WriteLine($"Your active Pokemon is {PlayerActivePokemon.Name} with {PlayerActivePokemon.CurrentHP} HP\n" +
                        $"Enemy's active Pokemon is {EnemyActivePokemon.Name} with {EnemyActivePokemon.CurrentHP} HP.");
                    Thread.Sleep(1000);
                    string playerMove = GetPlayerMove();
                    string enemyMove = GetEnemyMove();
                    if (playerMove == "SWAP")
                    {
                        if (HandleManualSwitch())
                        {
                            ExecuteTurn(EnemyActivePokemon, PlayerActivePokemon, enemyMove);
                            Thread.Sleep(1000);
                            Console.Clear();
                            isTurnTaken = true;
                        }
                    }
                    else
                    {
                        if (playerGoesFirst)
                        {
                            ExecuteTurn(PlayerActivePokemon, EnemyActivePokemon, playerMove);

                            if (!EnemyActivePokemon.Condition.HasFlag(StatusCondition.Fainted))
                            {
                                ExecuteTurn(EnemyActivePokemon, PlayerActivePokemon, enemyMove);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                        }
                        else
                        {
                            ExecuteTurn(EnemyActivePokemon, PlayerActivePokemon, enemyMove);
                            if (!PlayerActivePokemon.Condition.HasFlag(StatusCondition.Fainted))
                            {
                                ExecuteTurn(PlayerActivePokemon, EnemyActivePokemon, playerMove);
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                        }
                        isTurnTaken = true;
                    }
                    CheckAndSwitchFainted();
                }
            }
        }
        public bool IsBattleActive()
        {
            if (PlayerTeam.All(p => p.Condition.HasFlag(StatusCondition.Fainted)))
            {
                Console.WriteLine("You have no more Pokemon left! You lose!");
                return false;
            }
            else if (EnemyTeam.All(p => p.Condition.HasFlag(StatusCondition.Fainted)))
            {
                Console.WriteLine("The enemy has no more Pokemon left! You win!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public string GetPlayerMove()
        {
            Console.WriteLine($"Choose your move\n" +
                $"1: {PlayerActivePokemon.MoveSet[0]}\n" +
                $"2: {PlayerActivePokemon.MoveSet[1]}\n" +
                $"3: {PlayerActivePokemon.MoveSet[2]}\n" +
                $"4: {PlayerActivePokemon.MoveSet[3]}\n" +
                $"5: Swap Pokemon");

            string? result = Console.ReadLine();
            if (int.TryParse(result, out int choice) && choice >= 1 && choice <= 4)
            {
                return PlayerActivePokemon.MoveSet[choice - 1];
            }
            else if (result == "5") return "SWAP";
            else
            {
                Console.WriteLine($"Invalid Input, Selecting {PlayerActivePokemon.MoveSet[0]}");
                return PlayerActivePokemon.MoveSet[0];
            }
        }

        public string GetEnemyMove()
        {
            int index = rand.Next(4);
            return EnemyActivePokemon.MoveSet[index];
        }

        public void ExecuteTurn(Pokemon attacker, Pokemon defender, string moveName)
        {
            if (attacker.Condition.HasFlag(StatusCondition.Fainted)) return;
            Console.WriteLine($"{attacker.Name} used {moveName}");
            //Check if strong/weak
            var move = PokemonData.MoveList[moveName];
            double multiplier = CombatEngine.DamageMultiplier(move.MoveType, defender.Type);
            if (multiplier == 2)
            {
                Console.WriteLine("It was super effective");
            }
            if (multiplier == 0.5)
            {
                Console.WriteLine("It wasn't very effective");
            }
            if (multiplier == 1.5)
            {
                Console.WriteLine("It was effective");
            }

            //Deal damage
            int damage = CombatEngine.CalculateDamage(attacker, defender, moveName);
            defender.CurrentHP -= damage;
            if (defender.CurrentHP < 0) defender.CurrentHP = 0;
            Console.WriteLine($"{defender.Name} took {damage} points of damage, and has {defender.CurrentHP} HP left");
            if (defender.CurrentHP <= 0)
            {
                defender.Condition |= StatusCondition.Fainted;
                Console.WriteLine($"{defender.Name} has fainted");
            }
            Thread.Sleep(1500);
        }
        //Add a Pokemon swap on Faint
        public void CheckAndSwitchFainted()
        {
            if (PlayerActivePokemon.Condition.HasFlag(StatusCondition.Fainted))
            {
                var remaining = PlayerTeam.Where(p => !p.Condition.HasFlag(StatusCondition.Fainted)).ToList();

                if (remaining.Count == 1)
                {
                    PlayerActivePokemon = remaining[0];
                    Console.WriteLine($"\nYour last Pokemon, {PlayerActivePokemon.Name}, joined the battle!");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else if (remaining.Count > 1)
                {
                    Console.WriteLine("\nYour Pokemon fainted! You must choose a new one.");
                    HandleManualSwitch();
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }
            if (EnemyActivePokemon.Condition.HasFlag(StatusCondition.Fainted))
            {
                EnemyActivePokemon = EnemyTeam.FirstOrDefault(p => !p.Condition.HasFlag(StatusCondition.Fainted));
                if (EnemyActivePokemon != null) Console.WriteLine($"\nEnemy sent out {EnemyActivePokemon.Name}!");
            }
        }


        private bool HandleManualSwitch()
        {
            var available = PlayerTeam.Where(p => !p.Condition.HasFlag(StatusCondition.Fainted) && p != PlayerActivePokemon).ToList();

            if (available.Count == 0)
            {
                Console.WriteLine("No other Pokemon are able to battle!");
                Thread.Sleep(500);
                Console.Clear();
                return false;
            }

            while (true)
            {
                Console.WriteLine("Who would you like to send out?");
                for (int i = 0; i < available.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {available[i].Name} (HP: {available[i].CurrentHP}/{available[i].MaxHP})");
                }
                Console.WriteLine($"{available.Count + 1}: Cancel Pokemon Swap.");
                string? input = Console.ReadLine();

                if (input == $"{available.Count + 1}")
                {
                    if (!PlayerActivePokemon.Condition.HasFlag(StatusCondition.Fainted))
                    {
                        return false;
                    }
                    Console.WriteLine("You cannot cancel! Your current Pokemon has fainted.");
                    Thread.Sleep(500);
                    Console.Clear();
                }

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= available.Count)
                {
                    PlayerActivePokemon = available[choice - 1];
                    Console.WriteLine($"Go, {PlayerActivePokemon.Name}!");
                    Thread.Sleep(1500);
                    return true;
                }

                Console.WriteLine("Invalid selection.");
            }
        }
    }
}