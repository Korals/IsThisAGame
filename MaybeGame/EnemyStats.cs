using System;

namespace MaybeGame
{
    public class EnemyStats : BaseStats
    {
        public int SetStrength(EnemyType enemy)
        {
            // Strength is the quality or state of being physically strong.

            var strength = 5;

            switch (enemy)
            {
                case EnemyType.Skeleton or EnemyType.Zombie or EnemyType.Thief:
                    strength += 2;
                    break;

                case EnemyType.Berserker:
                    strength += 5;
                    break;

                case EnemyType.Rat:
                    strength += 1;
                    break;

                case EnemyType.Bandit or EnemyType.Warrior:
                    strength += 4;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return strength;
        }
        public int SetStamina(EnemyType enemy)
        {
            // Stamina is the ability to sustain prolonged physical or mental effort.

            var stamina = 5;

            switch (enemy)
            {
                case EnemyType.Bandit or EnemyType.Zombie or EnemyType.Skeleton:
                    stamina += 5;
                    break;

                case EnemyType.Berserker or EnemyType.Thief:
                    stamina += 2;
                    break;

                case EnemyType.Rat:
                    stamina += 1;
                    break;

                case EnemyType.Warrior:
                    stamina += 7;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return stamina;
        }
        public int SetAgility(EnemyType enemy)
        {
            // Agility is the ability to move quickly and easily.
            var agility = 5;

            switch (enemy)
            {
                case EnemyType.Warrior or EnemyType.Bandit:
                    agility += 3;
                    break;

                case EnemyType.Skeleton:
                    agility += 2;
                    break;

                case EnemyType.Berserker or EnemyType.Thief or EnemyType.Rat:
                    agility += 7;
                    break;

                case EnemyType.Zombie:
                    agility += 1;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return agility;
        }
        public int SetDexterity(EnemyType enemy)
        {
            // Dexterity is the readiness and grace in physical activity.
            var dexterity = 5;

            switch (enemy)
            {
                case EnemyType.Skeleton or EnemyType.Zombie:
                    dexterity += 3;
                    break;

                case EnemyType.Berserker or EnemyType.Bandit:
                    dexterity += 2;
                    break;

                case EnemyType.Warrior or EnemyType.Rat or EnemyType.Thief:
                    dexterity += 5;
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
