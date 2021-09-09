using System;

namespace MaybeGame
{
    public class EnemyStats
    {
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public double DodgeChance { get; set; }
        public int Speed { get; set; }
        public int AttackPower { get; set; }

        public int SetStrength(string enemy)
        {
            // Strength is the quality or state of being physically strong.

            var strength = 5;

            switch (enemy)
            {
                case "Zombie":
                    strength += 2;
                    break;

                case "Skeleton":
                    strength += 2;
                    break;

                case "Bandit":
                    strength += 3;
                    break;

                case "Theif":
                    strength += 2;
                    break;

                case "Warrior":
                    strength += 4;
                    break;
                
                case "Berserker":
                    strength += 7;
                    break;
                
                case "Rat":
                    strength += 0;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return strength;
        }
        public int SetStamina(string enemy)
        {
            // Stamina is the ability to sustain prolonged physical or mental effort.

            var stamina = 5;

            switch (enemy)
            {
                case "Zombie":
                    stamina += 2;
                    break;

                case "Skeleton":
                    stamina += 2;
                    break;

                case "Bandit":
                    stamina += 3;
                    break;

                case "Theif":
                    stamina += 2;
                    break;

                case "Warrior":
                    stamina += 5;
                    break;

                case "Berserker":
                    stamina += 2;
                    break;

                case "Rat":
                    stamina += 1;
                    break;
            }

            return stamina;
        }
        public int SetAgility(string enemy)
        {
            // Agility is the ability to move quickly and easily.
            var agility = 5;

            switch (enemy)
            {
                case "Zombie":
                    agility += 2;
                    break;

                case "Skeleton":
                    agility += 2;
                    break;

                case "Bandit":
                    agility += 4;
                    break;

                case "Theif":
                    agility += 7;
                    break;

                case "Warrior":
                    agility += 2;
                    break;

                case "Berserker":
                    agility += 5;
                    break;

                case "Rat":
                    agility += 5;
                    break;
            }

            return agility;
        }
        public int SetDexterity(string enemy)
        {
            // Dexterity is the readiness and grace in physical activity.
            var dexterity = 5;

            switch (enemy)
            {
                case "Zombie":
                    dexterity += 2;
                    break;

                case "Skeleton":
                    dexterity += 3;
                    break;

                case "Bandit":
                    dexterity += 3;
                    break;

                case "Theif":
                    dexterity += 5;
                    break;

                case "Warrior":
                    dexterity += 4;
                    break;

                case "Berserker":
                    dexterity += 1;
                    break;

                case "Rat":
                    dexterity += 3;
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
