using System;
using MaybeGame.Stats;

namespace MaybeGame.Players
{
    public class Player
    {
        public string UserName { get; set; }
        public string ClanName { get; set; }
        public PlayerRace Race { get; set; }
        public PlayerStats Stats { get; set; }
        public PlayerExperience PlayerExperience { get; set; }

        public Player(string userName, string clanName, int race)
        {
            UserName = userName;
            ClanName = clanName;
            Race = ResolvePlayerRace(race);
            Stats = new PlayerStats(Race);
            PlayerExperience = new PlayerExperience();
        }

        public void DumpPlayerData()
        {
            Console.WriteLine($"{nameof(UserName)}: {UserName} | {nameof(ClanName)}: {ClanName}\n" +
                              $"I am {nameof(PlayerExperience.Level)}: {PlayerExperience.Level} {Race}\n" +
                              $"{nameof(PlayerExperience.ExperiencePoints)}: {PlayerExperience.ExperiencePoints * 100}%\n\n" +
                              $"Character stats:\n" +
                              $"{nameof(Stats.Health)} - {Stats.Health}\n" +
                              $"{nameof(Stats.Defence)} - {Stats.Defence}\n" +
                              $"{nameof(Stats.DodgeChance)} - {Math.Round(Stats.DodgeChance * 100, 2)}%\n" +
                              $"{nameof(Stats.AttackPower)} - {Stats.AttackPower}\n" +
                              $"{nameof(Stats.Speed)} - {Stats.Speed}\n\n" +
                              $"{nameof(Stats.Strength)} - {Stats.Strength}\n" +
                              $"{nameof(Stats.Stamina)} - {Stats.Stamina}\n" +
                              $"{nameof(Stats.Agility)} - {Stats.Agility}\n" +
                              $"{nameof(Stats.Dexterity)} - {Stats.Dexterity}.\n");
        }

        private static PlayerRace ResolvePlayerRace(int race) => race switch
        {
            1 => PlayerRace.Human,
            2 => PlayerRace.Dwarf,
            3 => PlayerRace.Elf,
            4 => PlayerRace.Undead,
            _ => PlayerRace.Unset
        };
    }
}