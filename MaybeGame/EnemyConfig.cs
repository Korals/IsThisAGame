using System;
using System.Collections.Generic;

namespace MaybeGame
{
    public static class EnemyConfig
    {
        public static List<Enemy> GenerateEnemies()
        {
            var enemies = new List<Enemy>();
            foreach (EnemyType e in Enum.GetValues(typeof(EnemyType)))
            {
                enemies.Add(new Enemy(e));
            }
            return enemies;
        }

        /* Enemy generation
        public static Enemy CreateZombie()
        {
            var enemy = new StatSettings();
            enemy.EnemyStatSet(EnemyType.Zombie.ToString());
            return enemy;
        }
        public static Enemy CreateSkeleton()
        {
            StatSettings enemyStats = new(); 
            enemyStats.EnemyStatSet(EnemyType.Skeleton.ToString());
            return (Enemy)enemyStats;
        }
        public static Enemy CreateBandit()
        {
            Enemy enemy = new();
            enemy.StatSet(EnemyType.Bandit.ToString());
            return enemy;
        }
        public static Enemy CreateThief()
        {
            Enemy enemy = new();
            enemy.StatSet(EnemyType.Thief.ToString());
            return enemy;
        }
        public static Enemy CreateWarrior()
        {
            Enemy enemy = new();
            enemy.StatSet(EnemyType.Warrior.ToString());
            return enemy;
        }
        public static Enemy CreateBerserker()
        {
            Enemy enemy = new();
            enemy.StatSet(EnemyType.Berserker.ToString());
            return enemy;
        }
        public static Enemy CreateRat()
        {
            Enemy enemy = new();
            enemy.StatSet(EnemyType.Rat.ToString());
            return enemy;
        }
        */
    }
}
