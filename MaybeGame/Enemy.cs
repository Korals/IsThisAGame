using System;

namespace MaybeGame
{
    public class Enemy
    {
        EnemyStats enemyStats = new();

        public string EnemyName { get; set; }

        public void DataDump()
        {
            Console.WriteLine($"{nameof(EnemyName)}: {EnemyName}\n" +
                $"Enemy stats:\n" +
                $"{nameof(enemyStats.Health)} - {enemyStats.Health}\n" +
                $"{nameof(enemyStats.Defence)} - {enemyStats.Defence}\n" +
                $"{nameof(enemyStats.DodgeChance)} - {enemyStats.DodgeChance * 100}%\n" +
                $"{nameof(enemyStats.AttackPower)} - {enemyStats.AttackPower}\n" +
                $"{nameof(enemyStats.Speed)} - {enemyStats.Speed}\n\n" +
                $"{nameof(enemyStats.Strength)} - {enemyStats.Strength}\n" +
                $"{nameof(enemyStats.Stamina)} - {enemyStats.Stamina}\n" +
                $"{nameof(enemyStats.Agility)} - {enemyStats.Agility}\n" +
                $"{nameof(enemyStats.Dexterity)} - {enemyStats.Dexterity}.\n");
        }
        public void StatSet(string enemyName)
        {
            EnemyName = enemyName;
            enemyStats.Strength = enemyStats.SetStrength(EnemyName);
            enemyStats.Stamina = enemyStats.SetStamina(EnemyName);
            enemyStats.Agility = enemyStats.SetAgility(EnemyName);
            enemyStats.Dexterity = enemyStats.SetDexterity(EnemyName);
            enemyStats.Health = enemyStats.SetHealth(enemyStats.Stamina);
            enemyStats.Defence = enemyStats.SetDefence(enemyStats.Stamina);
            enemyStats.DodgeChance = enemyStats.SetDodgeChance(enemyStats.Dexterity);
            enemyStats.Speed = enemyStats.SetSpeed(enemyStats.Agility);
            enemyStats.AttackPower = enemyStats.SetAttackPower(enemyStats.Strength);
        }
    }
}
