using System;
using MaybeGame.Enemies;

namespace MaybeGame.Stats
{
    public class EnemyStats : BaseStats
    {
        public EnemyStats(EnemyRace race)
        {
            Strength = CalculateStrength(race);
            Stamina = CalculateStamina(race);
            Agility = CalculateAgility(race);
            Dexterity = CalculateDexterity(race);
            Health = CalculateHealth();
            Defence = CalculateDefence();
            DodgeChance = CalculateDodgeChance();
            Speed = CalculateSpeed();
            AttackPower = CalculateAttackPower();
        }

        private static int CalculateStrength(EnemyRace enemy)
        {
            // Strength is the quality or state of being physically strong.

            var strength = 5;

            switch (enemy)
            {
                case EnemyRace.Skeleton or EnemyRace.Zombie or EnemyRace.Thief:
                    strength += 2;
                    break;

                case EnemyRace.Berserker:
                    strength += 5;
                    break;

                case EnemyRace.Rat:
                    strength += 1;
                    break;

                case EnemyRace.Bandit or EnemyRace.Warrior:
                    strength += 4;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return strength;
        }

        private int CalculateStamina(EnemyRace enemy)
        {
            // Stamina is the ability to sustain prolonged physical or mental effort.

            var stamina = 5;

            switch (enemy)
            {
                case EnemyRace.Bandit or EnemyRace.Zombie or EnemyRace.Skeleton:
                    stamina += 5;
                    break;

                case EnemyRace.Berserker or EnemyRace.Thief:
                    stamina += 2;
                    break;

                case EnemyRace.Rat:
                    stamina += 1;
                    break;

                case EnemyRace.Warrior:
                    stamina += 7;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return stamina;
        }

        private int CalculateAgility(EnemyRace enemy)
        {
            // Agility is the ability to move quickly and easily.
            var agility = 5;

            switch (enemy)
            {
                case EnemyRace.Warrior or EnemyRace.Bandit:
                    agility += 3;
                    break;

                case EnemyRace.Skeleton:
                    agility += 2;
                    break;

                case EnemyRace.Berserker or EnemyRace.Thief or EnemyRace.Rat:
                    agility += 7;
                    break;

                case EnemyRace.Zombie:
                    agility += 1;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return agility;
        }

        private int CalculateDexterity(EnemyRace enemy)
        {
            // Dexterity is the readiness and grace in physical activity.
            var dexterity = 5;

            switch (enemy)
            {
                case EnemyRace.Skeleton or EnemyRace.Zombie:
                    dexterity += 3;
                    break;

                case EnemyRace.Berserker or EnemyRace.Bandit:
                    dexterity += 2;
                    break;

                case EnemyRace.Warrior or EnemyRace.Rat or EnemyRace.Thief:
                    dexterity += 5;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return dexterity;
        }

        private int CalculateHealth() => 50 + (Stamina * 3);
        private int CalculateDefence() => 20 + Stamina;

        private double CalculateDodgeChance()
        {
            var maxDodgeChance = 0.95d;

            if (DodgeChance >= maxDodgeChance)
            {
                DodgeChance = maxDodgeChance;
                Console.WriteLine("Dodge chance maxed out(stop adding points to Dexterity)!");
            }
            else
            {
                DodgeChance += Dexterity * 0.005;
            }

            return DodgeChance;
        }

        private int CalculateSpeed() => 20 + (Agility * 2);
        private int CalculateAttackPower() => 15 + (5 * Strength);
    }
}