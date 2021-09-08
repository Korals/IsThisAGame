﻿using System;

namespace MaybeGame
{
    public class Player
    {
        //TODO: Make a class to house stats and a class for Experience!!!! Make enum races

        public string UserName { get; set; }
        public string ClanName { get; set; }
        public string Race { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public double DodgeChance { get; set; }
        public double Speed { get; set; }
        public int AttackPower { get; set; }
        public double ExperiencePoints { get; set; }
        //public double SavedExperiencePoints { get; set; }
        public int StatPoints { get; set; }
        public int Level { get; set; }


        public void DataDump()
        {
            Console.WriteLine($"{nameof(UserName)}: {UserName} | {nameof(ClanName)}: {ClanName}\n" +
                $"I am {nameof(Level)}: {Level} {Race}\n" +
                $"{nameof(ExperiencePoints)}: {ExperiencePoints *100}%\n\n" +
                $"Character stats:\n" +
                $"{nameof(Health)} - {Health}\n" +
                $"{nameof(Defence)} - {Defence}\n" +
                $"{nameof(DodgeChance)} - {DodgeChance * 100}%\n" +
                $"{nameof(AttackPower)} - {AttackPower}\n" +
                $"{nameof(Speed)} - {Speed}\n\n" +
                $"{nameof(Strength)} - {Strength}\n" +
                $"{nameof(Stamina)} - {Stamina}\n" +
                $"{nameof(Agility)} - {Agility}\n" +
                $"{nameof(Dexterity)} - {Dexterity}.\n");
        }
        private string ChooseARace()
        {
            Console.WriteLine("Please select your race:\n" +
                "1. Human\n" +
                "2. Drawf\n" +
                "3. Elf\n" +
                "4. Undead\n");
            var race = RaceInfo();
            
            return race;
        }
        private string RaceInfo()
        {
            var raceName = "N/A";
            var invalidChoice = false;
            var selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    raceName = "Human";
                    break;

                case 2:
                    raceName = "Dwarf";
                    break;

                case 3:
                    raceName = "Elf";
                    break;

                case 4:
                    raceName = "Undead";
                    break;

                default:
                    invalidChoice = true;
                    break;
            }

            if (invalidChoice)
            {
                Console.WriteLine("Invalid choice. Try again!");
                RaceInfo();
            }
            return raceName;
        }
        private int SetStrength(string race)
        {
            // Strength is the quality or state of being physically strong.

            var strength = 5;
            
            switch (race)
            {
                case "Human":
                    strength += 2;
                    break;

                case "Dwarf":
                    strength += 5;
                    break;

                case "Elf":
                    strength += 1;
                    break;

                case "Undead":
                    strength += 4;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return strength;
        }
        private int SetStamina(string race)
        {
            // Stamina is the ability to sustain prolonged physical or mental effort.

            var stamina = 5;
            
            switch (race)
            {
                case "Human":
                    stamina += 5;
                    break;

                case "Dwarf":
                    stamina += 4;
                    break;

                case "Elf":
                    stamina += 5;
                    break;

                case "Undead":
                    stamina += 7;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return stamina;
        }
        private int SetAgility(string race)
        {
            // Agility is the ability to move quickly and easily.
            var agility = 5;

            switch (race)
            {
                case "Human":
                    agility += 3;
                    break;

                case "Dwarf":
                    agility += 2;
                    break;

                case "Elf":
                    agility += 7;
                    break;

                case "Undead":
                    agility += 1;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return agility;
        }
        private int SetDexterity(string race)
        {
            // Dexterity is the readiness and grace in physical activity.
            var dexterity = 5;

            switch (race)
            {
                case "Human":
                    dexterity += 3;
                    break;

                case "Dwarf":
                    dexterity += 2;
                    break;

                case "Elf":
                    dexterity += 5;
                    break;

                case "Undead":
                    dexterity += 2;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return dexterity;
        }
        private int SetHealth(int stamina)
        {
            return 50 + (stamina * 3);
        }
        private int SetDefence(int stamina)
        {
            return 20 + stamina;
        }
        private double SetDodgeChance(int dexterity)
        {
            var maxDodgeChance = 0.95d;

            if (DodgeChance >= maxDodgeChance)
            {
                DodgeChance = maxDodgeChance;
                Console.WriteLine("Dodge chance maxed out(stop adding points to Dexterity)!");
            }
            else
            {
                DodgeChance += dexterity * 0.005;
            }

            return DodgeChance;
        }
        private int SetSpeed(int agility)
        {
            return 20 + (agility * 2);
        }
        private int SetAttackPower(int strength)
        {
            return 15 + (5 * strength);
        }
        public void IsLevelUpPossible(double experiencePoints)
        {
            if (experiencePoints >= 1)
            {
                Level++;
                Console.WriteLine("Level up! Congratulations\n" +
                    $"Your level is now {Level}");
                ExperiencePoints -= 1;
            }
            else
            {
                ExperiencePoints += experiencePoints;
            }
        }

        public void StatSet(string userName, string clanName)
        {
            UserName = userName;
            ClanName = clanName;
            Race = ChooseARace();
            ExperiencePoints = 0;
            Level = 1;
            Strength = SetStrength(Race);
            Stamina = SetStamina(Race);
            Agility = SetAgility(Race);
            Dexterity = SetDexterity(Race);
            Health = SetHealth(Stamina);
            Defence = SetDefence(Stamina);
            DodgeChance = SetDodgeChance(Dexterity);
            Speed = SetSpeed(Agility);
            AttackPower = SetAttackPower(Strength);
        }

        /*public double SaveExperiencePoints(double experiencePoints)
        {
           return SavedExperiencePoints += experiencePoints;
        }*/
    }
}
