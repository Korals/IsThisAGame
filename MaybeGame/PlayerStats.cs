using System;

namespace MaybeGame
{
    public class PlayerStats
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public double DodgeChance { get; set; }
        public double Speed { get; set; }
        public int AttackPower { get; set; }
        public int StatPoints { get; set; }

        public int SetStrength(string race)
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
        public int SetStamina(string race)
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
        public int SetAgility(string race)
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
        public int SetDexterity(string race)
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
        public int SetHealth(int stamina)
        {
            return 50 + (stamina * 3);
        }
        public int SetDefence(int stamina)
        {
            return 20 + stamina;
        }
        public double SetDodgeChance(int dexterity)
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
        public int SetSpeed(int agility)
        {
            return 20 + (agility * 2);
        }
        public int SetAttackPower(int strength)
        {
            return 15 + (5 * strength);
        }
    }
}
