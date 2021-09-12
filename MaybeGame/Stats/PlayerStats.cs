using System;
using MaybeGame.Players;

namespace MaybeGame.Stats
{
    public class PlayerStats : BaseStats
    {
        public PlayerStats(PlayerRace race)
        {
            Strength = SetStrength(race);
            Stamina = SetStamina(race);
            Agility = SetAgility(race);
            Dexterity = SetDexterity(race);
            Health = SetHealth(Stamina);
            Defence = SetDefence(Stamina);
            DodgeChance = SetDodgeChance(Dexterity);
            Speed = SetSpeed(Agility);
            AttackPower = SetAttackPower(Strength);
        }

        public int SetStrength(PlayerRace race)
        {
            // Strength is the quality or state of being physically strong.

            var strength = 5;

            switch (race)
            {
                case PlayerRace.Human:
                    strength += 2;
                    break;

                case PlayerRace.Dwarf:
                    strength += 5;
                    break;

                case PlayerRace.Elf:
                    strength += 1;
                    break;

                case PlayerRace.Undead:
                    strength += 4;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return strength;
        }

        public int SetStamina(PlayerRace race)
        {
            // Stamina is the ability to sustain prolonged physical or mental effort.

            var stamina = 5;

            switch (race)
            {
                case PlayerRace.Human or PlayerRace.Elf:
                    stamina += 5;
                    break;

                case PlayerRace.Dwarf:
                    stamina += 4;
                    break;

                case PlayerRace.Undead:
                    stamina += 7;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return stamina;
        }

        public int SetAgility(PlayerRace race)
        {
            // Agility is the ability to move quickly and easily.
            var agility = 5;

            switch (race)
            {
                case PlayerRace.Human:
                    agility += 3;
                    break;

                case PlayerRace.Dwarf:
                    agility += 2;
                    break;

                case PlayerRace.Elf:
                    agility += 7;
                    break;

                case PlayerRace.Undead:
                    agility += 1;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return agility;
        }

        public int SetDexterity(PlayerRace race)
        {
            // Dexterity is the readiness and grace in physical activity.
            var dexterity = 5;

            switch (race)
            {
                case PlayerRace.Human:
                    dexterity += 3;
                    break;

                case PlayerRace.Dwarf or PlayerRace.Undead:
                    dexterity += 2;
                    break;

                case PlayerRace.Elf:
                    dexterity += 5;
                    break;

                default:
                    Console.WriteLine("Error 404: Race not found");
                    break;
            }

            return dexterity;
        }

        public int SetHealth(int stamina) => 50 + (stamina * 3);
        public int SetDefence(int stamina) => 20 + stamina;

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

        public int SetSpeed(int agility) => 20 + (agility * 2);
        public int SetAttackPower(int strength) => 15 + (5 * strength);
    }
}