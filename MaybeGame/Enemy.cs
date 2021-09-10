using System;

namespace MaybeGame
{
    public class Enemy
    {
        EnemyStats enemyStats = new();

        public string EnemyName { get; set; }
        public EnemyStats Stats { get; set; }

        public void EnemyDataDump()
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
        
    }
}
