using System;

namespace MaybeGame
{
    public partial class Player
    {
        private PlayerStats playerStats = new();
        private PlayerExperience playerExperience = new();

        public string UserName { get; set; }
        public string ClanName { get; set; }
        public PlayerRace Race { get; set; }
        public PlayerStats Stats { get; set; }

        public void PlayerDataDump()
        {
            Console.WriteLine($"{nameof(UserName)}: {UserName} | {nameof(ClanName)}: {ClanName}\n" +
                $"I am {nameof(playerExperience.Level)}: {playerExperience.Level} {Race}\n" +
                $"{nameof(playerExperience.ExperiencePoints)}: {playerExperience.ExperiencePoints * 100}%\n\n" +
                $"Character stats:\n" +
                $"{nameof(playerStats.Health)} - {playerStats.Health}\n" +
                $"{nameof(playerStats.Defence)} - {playerStats.Defence}\n" +
                $"{nameof(playerStats.DodgeChance)} - {playerStats.DodgeChance * 100}%\n" +
                $"{nameof(playerStats.AttackPower)} - {playerStats.AttackPower}\n" +
                $"{nameof(playerStats.Speed)} - {playerStats.Speed}\n\n" +
                $"{nameof(playerStats.Strength)} - {playerStats.Strength}\n" +
                $"{nameof(playerStats.Stamina)} - {playerStats.Stamina}\n" +
                $"{nameof(playerStats.Agility)} - {playerStats.Agility}\n" +
                $"{nameof(playerStats.Dexterity)} - {playerStats.Dexterity}.\n");
        }
        public void RaceInfo()
        {
            Console.WriteLine("Please select your race:\n" +
                "1. Human\n" +
                "2. Drawf\n" +
                "3. Elf\n" +
                "4. Undead\n");

            var success = int.TryParse(Console.ReadLine(), out var race);
            if (success == false)
            {
                Console.WriteLine("You have chosen an invalid option!");
                RaceInfo();
            }
            ResolvePlayerRace(race);
        }
        private void ResolvePlayerRace(int race)
        {
            switch (race)
            {
                case 1:
                    Race = PlayerRace.Human;
                    break;

                case 2:
                    Race = PlayerRace.Dwarf;
                    break;

                case 3:
                    Race = PlayerRace.Elf;
                    break;

                case 4:
                    Race = PlayerRace.Undead;
                    break;

                default:
                    Console.WriteLine("This doesn't work!");
                    break;
            }
        }

    }
}
