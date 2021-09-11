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
                $"{nameof(EnemyStats.Health)} - {enemyStats.Health}\n" +
                $"{nameof(EnemyStats.Defence)} - {enemyStats.Defence}\n" +
                $"{nameof(EnemyStats.DodgeChance)} - {enemyStats.DodgeChance * 100}%\n" +
                $"{nameof(EnemyStats.AttackPower)} - {enemyStats.AttackPower}\n" +
                $"{nameof(EnemyStats.Speed)} - {enemyStats.Speed}\n\n" +
                $"{nameof(EnemyStats.Strength)} - {enemyStats.Strength}\n" +
                $"{nameof(EnemyStats.Stamina)} - {enemyStats.Stamina}\n" +
                $"{nameof(EnemyStats.Agility)} - {enemyStats.Agility}\n" +
                $"{nameof(EnemyStats.Dexterity)} - {enemyStats.Dexterity}.\n");
        }
        public Enemy()
        {
        }
        public Enemy(EnemyType enemy)
        {
            StatSettings enemyStats = new();
            enemyStats.EnemyStatSet(enemy);
        }

    }
}
