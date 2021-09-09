using System;

namespace MaybeGame
{
    public class Player
    {
        PlayerStats playerStats = new ();
        PlayerExperience playerExperience = new ();

        public string UserName { get; set; }
        public string ClanName { get; set; }
        public PlayerRaces Race { get; set; }

        public void DataDump()
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
        private PlayerRaces RaceInfo()
        {
            Console.WriteLine("Please select your race:\n" +
                "1. Human\n" +
                "2. Drawf\n" +
                "3. Elf\n" +
                "4. Undead\n");

            var success = int.TryParse(Console.ReadLine(), out var selection);
            if (success == false)
            {
                Console.WriteLine("You have chosen an invalid option!");
                RaceInfo();
            }

            switch (selection)
            {
                case 1:
                    Race = PlayerRaces.Human;
                    break;

                case 2:
                    Race = PlayerRaces.Dwarf;
                    break;

                case 3:
                    Race = PlayerRaces.Elf;
                    break;

                case 4:
                    Race = PlayerRaces.Undead;
                    break;

                default:
                    Console.WriteLine("This doesn't work!");
                    break;
            }

            return Race;
        }

        public void StatSet(string userName, string clanName)
        {
            UserName = userName;
            ClanName = clanName;
            Race = (PlayerRaces) RaceInfo();
            playerExperience.ExperiencePoints = 0;
            playerExperience.Level = 1;
            playerStats.Strength = playerStats.SetStrength(Race.ToString());
            playerStats.Stamina = playerStats.SetStamina(Race.ToString());
            playerStats.Agility = playerStats.SetAgility(Race.ToString());
            playerStats.Dexterity = playerStats.SetDexterity(Race.ToString());
            playerStats.Health = playerStats.SetHealth(playerStats.Stamina);
            playerStats.Defence = playerStats.SetDefence(playerStats.Stamina);
            playerStats.DodgeChance = playerStats.SetDodgeChance(playerStats.Dexterity);
            playerStats.Speed = playerStats.SetSpeed(playerStats.Agility);
            playerStats.AttackPower = playerStats.SetAttackPower(playerStats.Strength);
        }
    }
}
