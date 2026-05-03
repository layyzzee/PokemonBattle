using PokemonBattle.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class PokemonData
    {
        // Master List of All Pokemon (Add as required)
        public static List<PokemonSpecies> AllSpecies = new List<PokemonSpecies>
{
new PokemonSpecies { Name = "Bulbasaur", Type = PokemonType.Grass, MaxHP = 45, Attack = 49, Defence = 49, Speed = 45, MoveSet = new List<string> { "Tackle", "Vine Whip", "Razor Leaf", "Poison Sting" } },
new PokemonSpecies { Name = "Ivysaur", Type = PokemonType.Grass, MaxHP = 60, Attack = 62, Defence = 63, Speed = 60, MoveSet = new List<string> { "Tackle", "Vine Whip", "Razor Leaf", "Poison Sting" } },
new PokemonSpecies { Name = "Venusaur", Type = PokemonType.Grass, MaxHP = 80, Attack = 82, Defence = 83, Speed = 80, MoveSet = new List<string> { "Razor Leaf", "Solar Beam", "Body Slam", "Sludge" } },
new PokemonSpecies { Name = "Charmander", Type = PokemonType.Fire, MaxHP = 39, Attack = 52, Defence = 43, Speed = 65, MoveSet = new List<string> { "Scratch", "Ember", "Slash", "Flamethrower" } },
new PokemonSpecies { Name = "Charmeleon", Type = PokemonType.Fire, MaxHP = 58, Attack = 64, Defence = 58, Speed = 80, MoveSet = new List<string> { "Scratch", "Ember", "Slash", "Flamethrower" } },
new PokemonSpecies { Name = "Charizard", Type = PokemonType.Fire, MaxHP = 78, Attack = 84, Defence = 78, Speed = 100, MoveSet = new List<string> { "Flamethrower", "Fire Blast", "Slash", "Wing Attack" } },
new PokemonSpecies { Name = "Squirtle", Type = PokemonType.Water, MaxHP = 44, Attack = 48, Defence = 65, Speed = 43, MoveSet = new List<string> { "Tackle", "Water Gun", "Bubble", "Bite" } },
new PokemonSpecies { Name = "Wartortle", Type = PokemonType.Water, MaxHP = 59, Attack = 63, Defence = 80, Speed = 58, MoveSet = new List<string> { "Tackle", "Water Gun", "Bubble Beam", "Bite" } },
new PokemonSpecies { Name = "Blastoise", Type = PokemonType.Water, MaxHP = 79, Attack = 83, Defence = 100, Speed = 78, MoveSet = new List<string> { "Hydro Pump", "Surf", "Ice Beam", "Body Slam" } },
new PokemonSpecies { Name = "Caterpie", Type = PokemonType.Bug, MaxHP = 45, Attack = 30, Defence = 35, Speed = 45, MoveSet = new List<string> { "Tackle" } },
new PokemonSpecies { Name = "Metapod", Type = PokemonType.Bug, MaxHP = 50, Attack = 20, Defence = 55, Speed = 30, MoveSet = new List<string> { "Harden" } },
new PokemonSpecies { Name = "Butterfree", Type = PokemonType.Bug, MaxHP = 60, Attack = 45, Defence = 50, Speed = 70, MoveSet = new List<string> { "Confusion", "Psybeam", "Gust", "Razor Leaf" } },
new PokemonSpecies { Name = "Weedle", Type = PokemonType.Bug, MaxHP = 40, Attack = 35, Defence = 30, Speed = 50, MoveSet = new List<string> { "Poison Sting" } },
new PokemonSpecies { Name = "Kakuna", Type = PokemonType.Bug, MaxHP = 45, Attack = 25, Defence = 50, Speed = 35, MoveSet = new List<string> { "Harden" } },
new PokemonSpecies { Name = "Beedrill", Type = PokemonType.Bug, MaxHP = 65, Attack = 80, Defence = 40, Speed = 75, MoveSet = new List<string> { "Twineedle", "Pin Missile", "Poison Sting", "Agility" } },
new PokemonSpecies { Name = "Pidgey", Type = PokemonType.Normal, MaxHP = 40, Attack = 45, Defence = 40, Speed = 56, MoveSet = new List<string> { "Tackle", "Gust", "Quick Attack", "Wing Attack" } },
new PokemonSpecies { Name = "Pidgeotto", Type = PokemonType.Normal, MaxHP = 63, Attack = 60, Defence = 55, Speed = 71, MoveSet = new List<string> { "Tackle", "Gust", "Quick Attack", "Wing Attack" } },
new PokemonSpecies { Name = "Pidgeot", Type = PokemonType.Normal, MaxHP = 83, Attack = 80, Defence = 75, Speed = 91, MoveSet = new List<string> { "Wing Attack", "Sky Attack", "Hyper Beam", "Quick Attack" } },
new PokemonSpecies { Name = "Rattata", Type = PokemonType.Normal, MaxHP = 30, Attack = 56, Defence = 35, Speed = 72, MoveSet = new List<string> { "Tackle", "Quick Attack", "Hyper Fang", "Bite" } },
new PokemonSpecies { Name = "Raticate", Type = PokemonType.Normal, MaxHP = 55, Attack = 81, Defence = 60, Speed = 97, MoveSet = new List<string> { "Super Fang", "Hyper Fang", "Quick Attack", "Bite" } },
new PokemonSpecies { Name = "Spearow", Type = PokemonType.Normal, MaxHP = 40, Attack = 60, Defence = 30, Speed = 70, MoveSet = new List<string> { "Peck", "Drill Peck", "Agility", "Mirror Move" } },
new PokemonSpecies { Name = "Fearow", Type = PokemonType.Normal, MaxHP = 65, Attack = 90, Defence = 65, Speed = 100, MoveSet = new List<string> { "Drill Peck", "Sky Attack", "Agility", "Mirror Move" } },
new PokemonSpecies { Name = "Ekans", Type = PokemonType.Poison, MaxHP = 35, Attack = 60, Defence = 44, Speed = 55, MoveSet = new List<string> { "Poison Sting", "Bite", "Acid", "Sludge" } },
new PokemonSpecies { Name = "Arbok", Type = PokemonType.Poison, MaxHP = 60, Attack = 85, Defence = 69, Speed = 80, MoveSet = new List<string> { "Acid", "Sludge", "Bite", "Earthquake" } },
new PokemonSpecies { Name = "Pikachu", Type = PokemonType.Electric, MaxHP = 35, Attack = 55, Defence = 30, Speed = 90, MoveSet = new List<string> { "Thunder Shock", "Thunderbolt", "Quick Attack", "Thunder" } },
new PokemonSpecies { Name = "Raichu", Type = PokemonType.Electric, MaxHP = 60, Attack = 90, Defence = 55, Speed = 100, MoveSet = new List<string> { "Thunderbolt", "Thunder", "Thunder Punch", "Mega Punch" } },
new PokemonSpecies { Name = "Sandshrew", Type = PokemonType.Ground, MaxHP = 50, Attack = 75, Defence = 85, Speed = 40, MoveSet = new List<string> { "Scratch", "Slash", "Earthquake", "Dig" } },
new PokemonSpecies { Name = "Sandslash", Type = PokemonType.Ground, MaxHP = 75, Attack = 100, Defence = 110, Speed = 65, MoveSet = new List<string> { "Slash", "Earthquake", "Dig", "Swift" } },
new PokemonSpecies { Name = "Nidoran♀", Type = PokemonType.Poison, MaxHP = 55, Attack = 47, Defence = 52, Speed = 41, MoveSet = new List<string> { "Tackle", "Poison Sting", "Double Kick", "Bite" } },
new PokemonSpecies { Name = "Nidorina", Type = PokemonType.Poison, MaxHP = 70, Attack = 62, Defence = 67, Speed = 56, MoveSet = new List<string> { "Poison Sting", "Double Kick", "Bite", "Scratch" } },
new PokemonSpecies { Name = "Nidoqueen", Type = PokemonType.Poison, MaxHP = 90, Attack = 82, Defence = 87, Speed = 76, MoveSet = new List<string> { "Body Slam", "Earthquake", "Sludge", "Fire Blast" } },
new PokemonSpecies { Name = "Nidoran♂", Type = PokemonType.Poison, MaxHP = 46, Attack = 57, Defence = 40, Speed = 50, MoveSet = new List<string> { "Tackle", "Poison Sting", "Double Kick", "Horn Attack" } },
new PokemonSpecies { Name = "Nidorino", Type = PokemonType.Poison, MaxHP = 61, Attack = 72, Defence = 57, Speed = 65, MoveSet = new List<string> { "Poison Sting", "Double Kick", "Horn Attack", "Thrash" } },
new PokemonSpecies { Name = "Nidoking", Type = PokemonType.Poison, MaxHP = 81, Attack = 92, Defence = 77, Speed = 85, MoveSet = new List<string> { "Earthquake", "Thrash", "Ice Beam", "Thunderbolt" } },
new PokemonSpecies { Name = "Clefairy", Type = PokemonType.Normal, MaxHP = 70, Attack = 45, Defence = 48, Speed = 35, MoveSet = new List<string> { "Pound", "Body Slam", "Psychic", "Metronome" } },
new PokemonSpecies { Name = "Clefable", Type = PokemonType.Normal, MaxHP = 95, Attack = 70, Defence = 73, Speed = 60, MoveSet = new List<string> { "Psychic", "Body Slam", "Thunderbolt", "Fire Blast" } },
new PokemonSpecies { Name = "Vulpix", Type = PokemonType.Fire, MaxHP = 38, Attack = 41, Defence = 40, Speed = 65, MoveSet = new List<string> { "Ember", "Flamethrower", "Fire Spin", "Confuse Ray" } },
new PokemonSpecies { Name = "Ninetales", Type = PokemonType.Fire, MaxHP = 73, Attack = 76, Defence = 75, Speed = 100, MoveSet = new List<string> { "Flamethrower", "Fire Blast", "Fire Spin", "Confuse Ray" } },
new PokemonSpecies { Name = "Jigglypuff", Type = PokemonType.Normal, MaxHP = 115, Attack = 45, Defence = 20, Speed = 20, MoveSet = new List<string> { "Pound", "Body Slam", "Sing", "Double Slap" } },
new PokemonSpecies { Name = "Wigglytuff", Type = PokemonType.Normal, MaxHP = 140, Attack = 70, Defence = 45, Speed = 45, MoveSet = new List<string> { "Double Slap", "Body Slam", "Hyper Beam", "Sing" } },
new PokemonSpecies { Name = "Zubat", Type = PokemonType.Poison, MaxHP = 40, Attack = 45, Defence = 35, Speed = 55, MoveSet = new List<string> { "Leech Life", "Bite", "Wing Attack", "Confuse Ray" } },
new PokemonSpecies { Name = "Golbat", Type = PokemonType.Poison, MaxHP = 75, Attack = 80, Defence = 70, Speed = 90, MoveSet = new List<string> { "Bite", "Wing Attack", "Confuse Ray", "Sludge" } },
new PokemonSpecies { Name = "Oddish", Type = PokemonType.Grass, MaxHP = 45, Attack = 50, Defence = 55, Speed = 30, MoveSet = new List<string> { "Absorb", "Acid", "Mega Drain", "Petal Dance" } },
new PokemonSpecies { Name = "Gloom", Type = PokemonType.Grass, MaxHP = 60, Attack = 65, Defence = 70, Speed = 40, MoveSet = new List<string> { "Acid", "Mega Drain", "Petal Dance", "Solar Beam" } },
new PokemonSpecies { Name = "Vileplume", Type = PokemonType.Grass, MaxHP = 75, Attack = 80, Defence = 85, Speed = 50, MoveSet = new List<string> { "Petal Dance", "Solar Beam", "Body Slam", "Acid" } },
new PokemonSpecies { Name = "Paras", Type = PokemonType.Bug, MaxHP = 35, Attack = 70, Defence = 55, Speed = 25, MoveSet = new List<string> { "Scratch", "Leech Life", "Slash", "Spore" } },
new PokemonSpecies { Name = "Parasect", Type = PokemonType.Bug, MaxHP = 60, Attack = 95, Defence = 80, Speed = 30, MoveSet = new List<string> { "Leech Life", "Slash", "Spore", "Mega Drain" } },
new PokemonSpecies { Name = "Venonat", Type = PokemonType.Bug, MaxHP = 60, Attack = 55, Defence = 50, Speed = 45, MoveSet = new List<string> { "Confusion", "Psybeam", "Leech Life", "Psychic" } },
new PokemonSpecies { Name = "Venomoth", Type = PokemonType.Bug, MaxHP = 70, Attack = 65, Defence = 60, Speed = 90, MoveSet = new List<string> { "Psychic", "Psybeam", "Mega Drain", "Sleep Powder" } },
new PokemonSpecies { Name = "Diglett", Type = PokemonType.Ground, MaxHP = 10, Attack = 55, Defence = 25, Speed = 95, MoveSet = new List<string> { "Scratch", "Dig", "Slash", "Earthquake" } },
new PokemonSpecies { Name = "Dugtrio", Type = PokemonType.Ground, MaxHP = 35, Attack = 80, Defence = 50, Speed = 120, MoveSet = new List<string> { "Slash", "Dig", "Earthquake", "Rock Slide" } },
new PokemonSpecies { Name = "Meowth", Type = PokemonType.Normal, MaxHP = 40, Attack = 45, Defence = 35, Speed = 90, MoveSet = new List<string> { "Scratch", "Bite", "Slash", "Pay Day" } },
new PokemonSpecies { Name = "Persian", Type = PokemonType.Normal, MaxHP = 65, Attack = 70, Defence = 60, Speed = 115, MoveSet = new List<string> { "Slash", "Bite", "Hyper Beam", "Bubble Beam" } },
new PokemonSpecies { Name = "Psyduck", Type = PokemonType.Water, MaxHP = 50, Attack = 52, Defence = 48, Speed = 55, MoveSet = new List<string> { "Scratch", "Water Gun", "Confusion", "Surf" } },
new PokemonSpecies { Name = "Golduck", Type = PokemonType.Water, MaxHP = 80, Attack = 82, Defence = 78, Speed = 85, MoveSet = new List<string> { "Hydro Pump", "Surf", "Psychic", "Ice Beam" } },
new PokemonSpecies { Name = "Mankey", Type = PokemonType.Fighting, MaxHP = 40, Attack = 80, Defence = 35, Speed = 70, MoveSet = new List<string> { "Scratch", "Karate Chop", "Submission", "Thrash" } },
new PokemonSpecies { Name = "Primeape", Type = PokemonType.Fighting, MaxHP = 65, Attack = 105, Defence = 60, Speed = 95, MoveSet = new List<string> { "Karate Chop", "Submission", "Thrash", "Mega Punch" } },
new PokemonSpecies { Name = "Growlithe", Type = PokemonType.Fire, MaxHP = 55, Attack = 70, Defence = 45, Speed = 60, MoveSet = new List<string> { "Ember", "Flamethrower", "Bite", "Fire Blast" } },
new PokemonSpecies { Name = "Arcanine", Type = PokemonType.Fire, MaxHP = 90, Attack = 110, Defence = 80, Speed = 95, MoveSet = new List<string> { "Flamethrower", "Fire Blast", "Body Slam", "Bite" } },
new PokemonSpecies { Name = "Poliwag", Type = PokemonType.Water, MaxHP = 40, Attack = 50, Defence = 40, Speed = 90, MoveSet = new List<string> { "Bubble", "Water Gun", "Hypnosis", "Body Slam" } },
new PokemonSpecies { Name = "Poliwhirl", Type = PokemonType.Water, MaxHP = 65, Attack = 65, Defence = 65, Speed = 90, MoveSet = new List<string> { "Water Gun", "Bubble Beam", "Ice Beam", "Hypnosis" } },
new PokemonSpecies { Name = "Poliwrath", Type = PokemonType.Water, MaxHP = 90, Attack = 85, Defence = 95, Speed = 70, MoveSet = new List<string> { "Hydro Pump", "Submission", "Ice Beam", "Psychic" } },
new PokemonSpecies { Name = "Abra", Type = PokemonType.Psychic, MaxHP = 25, Attack = 20, Defence = 15, Speed = 90, MoveSet = new List<string> { "Psychic", "Confusion", "Night Shade", "Seismic Toss" } },
new PokemonSpecies { Name = "Kadabra", Type = PokemonType.Psychic, MaxHP = 40, Attack = 35, Defence = 30, Speed = 105, MoveSet = new List<string> { "Psychic", "Recover", "Confusion", "Psybeam" } },
new PokemonSpecies { Name = "Alakazam", Type = PokemonType.Psychic, MaxHP = 55, Attack = 50, Defence = 45, Speed = 120, MoveSet = new List<string> { "Psychic", "Recover", "Thunder Wave", "Tri Attack" } },
new PokemonSpecies { Name = "Machop", Type = PokemonType.Fighting, MaxHP = 70, Attack = 80, Defence = 50, Speed = 35, MoveSet = new List<string> { "Karate Chop", "Low Kick", "Seismic Toss", "Submission" } },
new PokemonSpecies { Name = "Machoke", Type = PokemonType.Fighting, MaxHP = 80, Attack = 100, Defence = 70, Speed = 45, MoveSet = new List<string> { "Submission", "Seismic Toss", "Body Slam", "Karate Chop" } },
new PokemonSpecies { Name = "Machamp", Type = PokemonType.Fighting, MaxHP = 90, Attack = 130, Defence = 80, Speed = 55, MoveSet = new List<string> { "Submission", "Hyper Beam", "Earthquake", "Rock Slide" } },
new PokemonSpecies { Name = "Bellsprout", Type = PokemonType.Grass, MaxHP = 50, Attack = 75, Defence = 35, Speed = 40, MoveSet = new List<string> { "Vine Whip", "Acid", "Razor Leaf", "Sleep Powder" } },
new PokemonSpecies { Name = "Weepinbell", Type = PokemonType.Grass, MaxHP = 65, Attack = 90, Defence = 50, Speed = 55, MoveSet = new List<string> { "Razor Leaf", "Acid", "Mega Drain", "Solar Beam" } },
new PokemonSpecies { Name = "Victreebel", Type = PokemonType.Grass, MaxHP = 80, Attack = 105, Defence = 65, Speed = 70, MoveSet = new List<string> { "Razor Leaf", "Solar Beam", "Body Slam", "Acid" } },
new PokemonSpecies { Name = "Tentacool", Type = PokemonType.Water, MaxHP = 40, Attack = 40, Defence = 35, Speed = 70, MoveSet = new List<string> { "Acid", "Bubble Beam", "Water Gun", "Surf" } },
new PokemonSpecies { Name = "Tentacruel", Type = PokemonType.Water, MaxHP = 80, Attack = 70, Defence = 65, Speed = 100, MoveSet = new List<string> { "Hydro Pump", "Surf", "Ice Beam", "Sludge" } },
new PokemonSpecies { Name = "Geodude", Type = PokemonType.Rock, MaxHP = 40, Attack = 80, Defence = 100, Speed = 20, MoveSet = new List<string> { "Tackle", "Rock Throw", "Earthquake", "Self-Destruct" } },
new PokemonSpecies { Name = "Graveler", Type = PokemonType.Rock, MaxHP = 55, Attack = 95, Defence = 115, Speed = 35, MoveSet = new List<string> { "Rock Throw", "Earthquake", "Explosion", "Rock Slide" } },
new PokemonSpecies { Name = "Golem", Type = PokemonType.Rock, MaxHP = 80, Attack = 110, Defence = 130, Speed = 45, MoveSet = new List<string> { "Earthquake", "Explosion", "Rock Slide", "Body Slam" } },
new PokemonSpecies { Name = "Ponyta", Type = PokemonType.Fire, MaxHP = 50, Attack = 85, Defence = 55, Speed = 90, MoveSet = new List<string> { "Ember", "Flamethrower", "Fire Spin", "Stomp" } },
new PokemonSpecies { Name = "Rapidash", Type = PokemonType.Fire, MaxHP = 65, Attack = 100, Defence = 70, Speed = 105, MoveSet = new List<string> { "Fire Blast", "Flamethrower", "Body Slam", "Fire Spin" } },
new PokemonSpecies { Name = "Slowpoke", Type = PokemonType.Water, MaxHP = 90, Attack = 65, Defence = 65, Speed = 15, MoveSet = new List<string> { "Confusion", "Water Gun", "Psychic", "Surf" } },
new PokemonSpecies { Name = "Slowbro", Type = PokemonType.Water, MaxHP = 95, Attack = 75, Defence = 110, Speed = 30, MoveSet = new List<string> { "Psychic", "Surf", "Ice Beam", "Thunder Wave" } },
new PokemonSpecies { Name = "Magnemite", Type = PokemonType.Electric, MaxHP = 25, Attack = 35, Defence = 70, Speed = 45, MoveSet = new List<string> { "Thunder Shock", "Thunderbolt", "Sonic Boom", "Thunder Wave" } },
new PokemonSpecies { Name = "Magneton", Type = PokemonType.Electric, MaxHP = 50, Attack = 60, Defence = 95, Speed = 70, MoveSet = new List<string> { "Thunderbolt", "Thunder", "Thunder Wave", "Tri Attack" } },
new PokemonSpecies { Name = "Farfetch'd", Type = PokemonType.Normal, MaxHP = 52, Attack = 65, Defence = 55, Speed = 60, MoveSet = new List<string> { "Peck", "Slash", "Cut", "Agility" } },
new PokemonSpecies { Name = "Doduo", Type = PokemonType.Normal, MaxHP = 35, Attack = 85, Defence = 45, Speed = 75, MoveSet = new List<string> { "Peck", "Drill Peck", "Quick Attack", "Tri Attack" } },
new PokemonSpecies { Name = "Dodrio", Type = PokemonType.Normal, MaxHP = 60, Attack = 110, Defence = 70, Speed = 100, MoveSet = new List<string> { "Drill Peck", "Tri Attack", "Body Slam", "Sky Attack" } },
new PokemonSpecies { Name = "Seel", Type = PokemonType.Water, MaxHP = 65, Attack = 45, Defence = 55, Speed = 45, MoveSet = new List<string> { "Headbutt", "Water Gun", "Surf", "Ice Beam" } },
new PokemonSpecies { Name = "Dewgong", Type = PokemonType.Water, MaxHP = 90, Attack = 70, Defence = 80, Speed = 70, MoveSet = new List<string> { "Ice Beam", "Surf", "Blizzard", "Body Slam" } },
new PokemonSpecies { Name = "Grimer", Type = PokemonType.Poison, MaxHP = 80, Attack = 80, Defence = 50, Speed = 25, MoveSet = new List<string> { "Pound", "Sludge", "Acid", "Explosion" } },
new PokemonSpecies { Name = "Muk", Type = PokemonType.Poison, MaxHP = 105, Attack = 105, Defence = 75, Speed = 50, MoveSet = new List<string> { "Sludge", "Explosion", "Body Slam", "Thunderbolt" } },
new PokemonSpecies { Name = "Shellder", Type = PokemonType.Water, MaxHP = 30, Attack = 65, Defence = 100, Speed = 40, MoveSet = new List<string> { "Tackle", "Water Gun", "Ice Beam", "Clamp" } },
new PokemonSpecies { Name = "Cloyster", Type = PokemonType.Water, MaxHP = 50, Attack = 95, Defence = 180, Speed = 70, MoveSet = new List<string> { "Clamp", "Ice Beam", "Blizzard", "Explosion" } },
new PokemonSpecies { Name = "Gastly", Type = PokemonType.Ghost, MaxHP = 30, Attack = 35, Defence = 30, Speed = 80, MoveSet = new List<string> { "Lick", "Night Shade", "Confuse Ray", "Hypnosis" } },
new PokemonSpecies { Name = "Haunter", Type = PokemonType.Ghost, MaxHP = 45, Attack = 50, Defence = 45, Speed = 95, MoveSet = new List<string> { "Lick", "Night Shade", "Confuse Ray", "Dream Eater" } },
new PokemonSpecies { Name = "Gengar", Type = PokemonType.Ghost, MaxHP = 60, Attack = 65, Defence = 60, Speed = 110, MoveSet = new List<string> { "Night Shade", "Dream Eater", "Psychic", "Thunderbolt" } },
new PokemonSpecies { Name = "Onix", Type = PokemonType.Rock, MaxHP = 35, Attack = 45, Defence = 160, Speed = 70, MoveSet = new List<string> { "Tackle", "Rock Throw", "Earthquake", "Slam" } },
new PokemonSpecies { Name = "Drowzee", Type = PokemonType.Psychic, MaxHP = 60, Attack = 48, Defence = 45, Speed = 42, MoveSet = new List<string> { "Pound", "Confusion", "Psychic", "Headbutt" } },
new PokemonSpecies { Name = "Hypno", Type = PokemonType.Psychic, MaxHP = 85, Attack = 73, Defence = 70, Speed = 67, MoveSet = new List<string> { "Psychic", "Confusion", "Headbutt", "Body Slam" } },
new PokemonSpecies { Name = "Krabby", Type = PokemonType.Water, MaxHP = 30, Attack = 105, Defence = 90, Speed = 50, MoveSet = new List<string> { "Bubble", "Vice Grip", "Crabhammer", "Stomp" } },
new PokemonSpecies { Name = "Kingler", Type = PokemonType.Water, MaxHP = 55, Attack = 130, Defence = 115, Speed = 75, MoveSet = new List<string> { "Crabhammer", "Vice Grip", "Slam", "Hyper Beam" } },
new PokemonSpecies { Name = "Voltorb", Type = PokemonType.Electric, MaxHP = 40, Attack = 30, Defence = 50, Speed = 100, MoveSet = new List<string> { "Tackle", "Thunder Shock", "Sonic Boom", "Self-Destruct" } },
new PokemonSpecies { Name = "Electrode", Type = PokemonType.Electric, MaxHP = 60, Attack = 50, Defence = 70, Speed = 140, MoveSet = new List<string> { "Thunderbolt", "Thunder", "Swift", "Explosion" } },
new PokemonSpecies { Name = "Exeggcute", Type = PokemonType.Grass, MaxHP = 60, Attack = 40, Defence = 80, Speed = 40, MoveSet = new List<string> { "Confusion", "Absorb", "Solar Beam", "Stun Spore" } },
new PokemonSpecies { Name = "Exeggutor", Type = PokemonType.Grass, MaxHP = 95, Attack = 95, Defence = 85, Speed = 55, MoveSet = new List<string> { "Psychic", "Solar Beam", "Stomp", "Egg Bomb" } },
new PokemonSpecies { Name = "Cubone", Type = PokemonType.Ground, MaxHP = 50, Attack = 50, Defence = 95, Speed = 35, MoveSet = new List<string> { "Bone Club", "Headbutt", "Thrash", "Tackle" } },
new PokemonSpecies { Name = "Marowak", Type = PokemonType.Ground, MaxHP = 60, Attack = 80, Defence = 110, Speed = 45, MoveSet = new List<string> { "Bone Club", "Thrash", "Earthquake", "Body Slam" } },
new PokemonSpecies { Name = "Hitmonlee", Type = PokemonType.Fighting, MaxHP = 50, Attack = 120, Defence = 53, Speed = 87, MoveSet = new List<string> { "Double Kick", "Rolling Kick", "Mega Kick", "Submission" } },
new PokemonSpecies { Name = "Hitmonchan", Type = PokemonType.Fighting, MaxHP = 50, Attack = 105, Defence = 79, Speed = 76, MoveSet = new List<string> { "Fire Punch", "Ice Punch", "Thunder Punch", "Mega Punch" } },
new PokemonSpecies { Name = "Lickitung", Type = PokemonType.Normal, MaxHP = 90, Attack = 55, Defence = 75, Speed = 30, MoveSet = new List<string> { "Lick", "Stomp", "Slam", "Body Slam" } },
new PokemonSpecies { Name = "Koffing", Type = PokemonType.Poison, MaxHP = 40, Attack = 65, Defence = 95, Speed = 35, MoveSet = new List<string> { "Sludge", "Acid", "Self-Destruct", "Tackle" } },
new PokemonSpecies { Name = "Weezing", Type = PokemonType.Poison, MaxHP = 65, Attack = 90, Defence = 120, Speed = 60, MoveSet = new List<string> { "Sludge", "Explosion", "Fire Blast", "Thunderbolt" } },
new PokemonSpecies { Name = "Rhyhorn", Type = PokemonType.Ground, MaxHP = 80, Attack = 85, Defence = 95, Speed = 25, MoveSet = new List<string> { "Stomp", "Horn Attack", "Earthquake", "Tackle" } },
new PokemonSpecies { Name = "Rhydon", Type = PokemonType.Ground, MaxHP = 105, Attack = 130, Defence = 120, Speed = 40, MoveSet = new List<string> { "Earthquake", "Stomp", "Rock Slide", "Horn Attack" } },
new PokemonSpecies { Name = "Chansey", Type = PokemonType.Normal, MaxHP = 250, Attack = 5, Defence = 5, Speed = 50, MoveSet = new List<string> { "Pound", "Double Slap", "Egg Bomb", "Ice Beam" } },
new PokemonSpecies { Name = "Tangela", Type = PokemonType.Grass, MaxHP = 65, Attack = 55, Defence = 115, Speed = 60, MoveSet = new List<string> { "Vine Whip", "Mega Drain", "Solar Beam", "Stun Spore" } },
new PokemonSpecies { Name = "Kangaskhan", Type = PokemonType.Normal, MaxHP = 105, Attack = 95, Defence = 80, Speed = 90, MoveSet = new List<string> { "Bite", "Mega Punch", "Body Slam", "Dizzy Punch" } },
new PokemonSpecies { Name = "Horsea", Type = PokemonType.Water, MaxHP = 30, Attack = 40, Defence = 70, Speed = 60, MoveSet = new List<string> { "Bubble", "Water Gun", "Bubble Beam", "Swift" } },
new PokemonSpecies { Name = "Seadra", Type = PokemonType.Water, MaxHP = 55, Attack = 65, Defence = 95, Speed = 85, MoveSet = new List<string> { "Hydro Pump", "Surf", "Bubble Beam", "Ice Beam" } },
new PokemonSpecies { Name = "Goldeen", Type = PokemonType.Water, MaxHP = 45, Attack = 67, Defence = 60, Speed = 63, MoveSet = new List<string> { "Peck", "Horn Attack", "Waterfall", "Tackle" } },
new PokemonSpecies { Name = "Seaking", Type = PokemonType.Water, MaxHP = 80, Attack = 92, Defence = 65, Speed = 68, MoveSet = new List<string> { "Waterfall", "Horn Attack", "Mega Drain", "Ice Beam" } },
new PokemonSpecies { Name = "Staryu", Type = PokemonType.Water, MaxHP = 30, Attack = 45, Defence = 55, Speed = 85, MoveSet = new List<string> { "Tackle", "Water Gun", "Swift", "Bubble Beam" } },
new PokemonSpecies { Name = "Starmie", Type = PokemonType.Water, MaxHP = 60, Attack = 75, Defence = 85, Speed = 115, MoveSet = new List<string> { "Psychic", "Surf", "Thunderbolt", "Ice Beam" } },
new PokemonSpecies { Name = "Mr. Mime", Type = PokemonType.Psychic, MaxHP = 40, Attack = 45, Defence = 65, Speed = 90, MoveSet = new List<string> { "Confusion", "Psychic", "Double Slap", "Solar Beam" } },
new PokemonSpecies { Name = "Scyther", Type = PokemonType.Bug, MaxHP = 70, Attack = 110, Defence = 80, Speed = 105, MoveSet = new List<string> { "Slash", "Quick Attack", "Wing Attack", "Agility" } },
new PokemonSpecies { Name = "Jynx", Type = PokemonType.Ice, MaxHP = 65, Attack = 50, Defence = 35, Speed = 95, MoveSet = new List<string> { "Ice Punch", "Body Slam", "Psychic", "Blizzard" } },
new PokemonSpecies { Name = "Electabuzz", Type = PokemonType.Electric, MaxHP = 65, Attack = 83, Defence = 57, Speed = 105, MoveSet = new List<string> { "Thunder Punch", "Thunderbolt", "Thunder", "Swift" } },
new PokemonSpecies { Name = "Magmar", Type = PokemonType.Fire, MaxHP = 65, Attack = 95, Defence = 57, Speed = 93, MoveSet = new List<string> { "Fire Punch", "Flamethrower", "Fire Blast", "Confuse Ray" } },
new PokemonSpecies { Name = "Pinsir", Type = PokemonType.Bug, MaxHP = 65, Attack = 125, Defence = 100, Speed = 85, MoveSet = new List<string> { "Vice Grip", "Slash", "Submission", "Seismic Toss" } },
new PokemonSpecies { Name = "Tauros", Type = PokemonType.Normal, MaxHP = 75, Attack = 100, Defence = 95, Speed = 110, MoveSet = new List<string> { "Stomp", "Take Down", "Body Slam", "Earthquake" } },
new PokemonSpecies { Name = "Magikarp", Type = PokemonType.Water, MaxHP = 20, Attack = 10, Defence = 55, Speed = 80, MoveSet = new List<string> { "Tackle", "Pound" } },
new PokemonSpecies { Name = "Gyarados", Type = PokemonType.Water, MaxHP = 95, Attack = 125, Defence = 79, Speed = 81, MoveSet = new List<string> { "Hydro Pump", "Dragon Rage", "Bite", "Hyper Beam" } },
new PokemonSpecies { Name = "Lapras", Type = PokemonType.Water, MaxHP = 130, Attack = 85, Defence = 80, Speed = 60, MoveSet = new List<string> { "Surf", "Ice Beam", "Body Slam", "Hydro Pump" } },
new PokemonSpecies { Name = "Ditto", Type = PokemonType.Normal, MaxHP = 48, Attack = 48, Defence = 48, Speed = 48, MoveSet = new List<string> { "Tackle", "Scratch" } },
new PokemonSpecies { Name = "Eevee", Type = PokemonType.Normal, MaxHP = 55, Attack = 55, Defence = 50, Speed = 55, MoveSet = new List<string> { "Tackle", "Quick Attack", "Bite", "Swift" } },
new PokemonSpecies { Name = "Vaporeon", Type = PokemonType.Water, MaxHP = 130, Attack = 65, Defence = 60, Speed = 65, MoveSet = new List<string> { "Hydro Pump", "Surf", "Acid", "Ice Beam" } },
new PokemonSpecies { Name = "Jolteon", Type = PokemonType.Electric, MaxHP = 65, Attack = 65, Defence = 60, Speed = 130, MoveSet = new List<string> { "Thunderbolt", "Thunder", "Double Kick", "Pin Missile" } },
new PokemonSpecies { Name = "Flareon", Type = PokemonType.Fire, MaxHP = 65, Attack = 130, Defence = 60, Speed = 65, MoveSet = new List<string> { "Flamethrower", "Fire Blast", "Bite", "Body Slam" } },
new PokemonSpecies { Name = "Porygon", Type = PokemonType.Normal, MaxHP = 65, Attack = 60, Defence = 70, Speed = 40, MoveSet = new List<string> { "Psybeam", "Tri Attack", "Thunderbolt", "Ice Beam" } },
new PokemonSpecies { Name = "Omanyte", Type = PokemonType.Rock, MaxHP = 35, Attack = 40, Defence = 100, Speed = 35, MoveSet = new List<string> { "Water Gun", "Horn Attack", "Bite", "Ice Beam" } },
new PokemonSpecies { Name = "Omastar", Type = PokemonType.Rock, MaxHP = 70, Attack = 60, Defence = 125, Speed = 55, MoveSet = new List<string> { "Hydro Pump", "Horn Attack", "Body Slam", "Ice Beam" } },
new PokemonSpecies { Name = "Kabuto", Type = PokemonType.Rock, MaxHP = 30, Attack = 80, Defence = 90, Speed = 55, MoveSet = new List<string> { "Scratch", "Absorb", "Slash", "Hydro Pump" } },
new PokemonSpecies { Name = "Kabutops", Type = PokemonType.Rock, MaxHP = 60, Attack = 115, Defence = 105, Speed = 80, MoveSet = new List<string> { "Slash", "Hydro Pump", "Mega Drain", "Leech Life" } },
new PokemonSpecies { Name = "Aerodactyl", Type = PokemonType.Rock, MaxHP = 80, Attack = 105, Defence = 65, Speed = 130, MoveSet = new List<string> { "Wing Attack", "Bite", "Hyper Beam", "Sky Attack" } },
new PokemonSpecies { Name = "Snorlax", Type = PokemonType.Normal, MaxHP = 160, Attack = 110, Defence = 65, Speed = 30, MoveSet = new List<string> { "Body Slam", "Hyper Beam", "Pound", "Earthquake" } },
new PokemonSpecies { Name = "Articuno", Type = PokemonType.Ice, MaxHP = 90, Attack = 85, Defence = 100, Speed = 85, MoveSet = new List<string> { "Ice Beam", "Blizzard", "Peck", "Sky Attack" } },
new PokemonSpecies { Name = "Zapdos", Type = PokemonType.Electric, MaxHP = 90, Attack = 90, Defence = 85, Speed = 100, MoveSet = new List<string> { "Thunderbolt", "Thunder", "Drill Peck", "Sky Attack" } },
new PokemonSpecies { Name = "Moltres", Type = PokemonType.Fire, MaxHP = 90, Attack = 100, Defence = 90, Speed = 90, MoveSet = new List<string> { "Fire Blast", "Flamethrower", "Peck", "Sky Attack" } },
new PokemonSpecies { Name = "Dratini", Type = PokemonType.Dragon, MaxHP = 41, Attack = 64, Defence = 45, Speed = 50, MoveSet = new List<string> { "Wrap", "Dragon Rage", "Slam", "Thunderbolt" } },
new PokemonSpecies { Name = "Dragonair", Type = PokemonType.Dragon, MaxHP = 61, Attack = 84, Defence = 65, Speed = 70, MoveSet = new List<string> { "Dragon Rage", "Slam", "Ice Beam", "Hyper Beam" } },
new PokemonSpecies { Name = "Dragonite", Type = PokemonType.Dragon, MaxHP = 91, Attack = 134, Defence = 95, Speed = 80, MoveSet = new List<string> { "Hyper Beam", "Dragon Rage", "Thunderbolt", "Fire Blast" } },
new PokemonSpecies { Name = "Mewtwo", Type = PokemonType.Psychic, MaxHP = 106, Attack = 110, Defence = 90, Speed = 130, MoveSet = new List<string> { "Psychic", "Swift", "Thunderbolt", "Ice Beam" } },
new PokemonSpecies { Name = "Mew", Type = PokemonType.Psychic, MaxHP = 100, Attack = 100, Defence = 100, Speed = 100, MoveSet = new List<string> { "Pound", "Psychic", "Mega Drain", "Fire Blast" } }
};

        // Helper function to find a Pokémon by name
        public static PokemonSpecies Get(string name)
            => AllSpecies.FirstOrDefault(s => s.Name == name);

        //Move List
        public static readonly Dictionary<string, (int Power, PokemonType MoveType, double Drain)> MoveList = new Dictionary<string, (int Power, PokemonType MoveType, double Drain)>
{
    // Normal
    {"Tackle", (35, PokemonType.Normal, 0)},
    {"Scratch", (40, PokemonType.Normal, 0)},
    {"Pound", (40, PokemonType.Normal, 0)},
    {"Quick Attack", (40, PokemonType.Normal, 0)},
    {"Double Slap", (15, PokemonType.Normal, 0)},
    {"Body Slam", (85, PokemonType.Normal, 0)},
    {"Hyper Beam", (150, PokemonType.Normal, 0)},
    {"Slam", (80, PokemonType.Normal, 0)},
    {"Slash", (70, PokemonType.Normal, 0)},
    {"Thrash", (90, PokemonType.Normal, 0)},
    {"Mega Punch", (80, PokemonType.Normal, 0)},
    {"Dizzy Punch", (70, PokemonType.Normal, 0)},
    {"Stomp", (65, PokemonType.Normal, 0)},
    {"Egg Bomb", (100, PokemonType.Normal, 0)},
    {"Tri Attack", (80, PokemonType.Normal, 0)},
    {"Explosion", (250, PokemonType.Normal, 0)},

    // Fire
    {"Ember", (40, PokemonType.Fire, 0)},
    {"Flamethrower", (90, PokemonType.Fire, 0)},
    {"Fire Blast", (110, PokemonType.Fire, 0)},
    {"Fire Punch", (75, PokemonType.Fire, 0)},
    {"Fire Spin", (35, PokemonType.Fire, 0)},

    // Water
    {"Water Gun", (40, PokemonType.Water, 0)},
    {"Bubble", (40, PokemonType.Water, 0)},
    {"Bubble Beam", (65, PokemonType.Water, 0)},
    {"Surf", (90, PokemonType.Water, 0)},
    {"Hydro Pump", (110, PokemonType.Water, 0)},
    {"Crabhammer", (100, PokemonType.Water, 0)},
    {"Waterfall", (80, PokemonType.Water, 0)},
    {"Clamp", (35, PokemonType.Water, 0)},

    // Grass
    {"Vine Whip", (45, PokemonType.Grass, 0)},
    {"Razor Leaf", (55, PokemonType.Grass, 0)},
    {"Solar Beam", (120, PokemonType.Grass, 0)},
    {"Absorb", (20, PokemonType.Grass, 0.50)},
    {"Mega Drain", (40, PokemonType.Grass, 0.50)},
    {"Petal Dance", (90, PokemonType.Grass, 0)},

    // Electric
    {"Thunder Shock", (40, PokemonType.Electric, 0)},
    {"Thunderbolt", (90, PokemonType.Electric, 0)},
    {"Thunder", (110, PokemonType.Electric, 0)},
    {"Thunder Punch", (75, PokemonType.Electric, 0)},

    // Flying (Corrected from Normal)
    {"Gust", (40, PokemonType.Flying, 0)},
    {"Wing Attack", (60, PokemonType.Flying, 0)},
    {"Drill Peck", (80, PokemonType.Flying, 0)},
    {"Sky Attack", (140, PokemonType.Flying, 0)},

    // Poison
    {"Poison Sting", (15, PokemonType.Poison, 0)},
    {"Acid", (40, PokemonType.Poison, 0)},
    {"Sludge", (65, PokemonType.Poison, 0)},

    // Psychic
    {"Confusion", (50, PokemonType.Psychic, 0)},
    {"Psybeam", (65, PokemonType.Psychic, 0)},
    {"Psychic", (90, PokemonType.Psychic, 0)},
    {"Dream Eater", (100, PokemonType.Psychic, 0.50)},

    // Fighting
    {"Karate Chop", (50, PokemonType.Fighting, 0)},
    {"Low Kick", (50, PokemonType.Fighting, 0)},
    {"Submission", (80, PokemonType.Fighting, 0)},
    {"Seismic Toss", (60, PokemonType.Fighting, 0)},

    // Bug
    {"Leech Life", (20, PokemonType.Bug, 0.50)},
    {"Pin Missile", (25, PokemonType.Bug, 0)},
    {"Twineedle", (25, PokemonType.Bug, 0)},

    // Ground
    {"Bone Club", (65, PokemonType.Ground, 0)},
    {"Earthquake", (100, PokemonType.Ground, 0)},
    {"Dig", (80, PokemonType.Ground, 0)},

    // Rock
    {"Rock Throw", (50, PokemonType.Rock, 0)},
    {"Rock Slide", (75, PokemonType.Rock, 0)},

    // Ghost
    {"Lick", (30, PokemonType.Ghost, 0)},
    {"Night Shade", (60, PokemonType.Ghost, 0)},

    // Ice
    {"Ice Beam", (90, PokemonType.Ice, 0)},
    {"Blizzard", (110, PokemonType.Ice, 0)},
    {"Aurora Beam", (65, PokemonType.Ice, 0)},
    {"Ice Punch", (75, PokemonType.Ice, 0)},

    // Dragon
    {"Dragon Rage", (40, PokemonType.Dragon, 0)}
};


        public List<string> LearnedMoves { get; set; } = new List<string>();
        public static int GetPowerMove(string moveName) => MoveList[moveName].Power;
        public static PokemonType GetMoveType(string moveName) => MoveList[moveName].MoveType;

    }
}
