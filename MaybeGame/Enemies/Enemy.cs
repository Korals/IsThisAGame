using System;
using MaybeGame.Stats;

namespace MaybeGame.Enemies
{
    public class Enemy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EnemyStats Stats { get; set; }
        public EnemyRace Race { get; set; }

        public Enemy(string name, EnemyRace race)
        {
            Name = name;
            Race = race;
            Stats = new EnemyStats(Race);
        }

        public void DumpEnemyData()
        {
            Console.WriteLine($"{nameof(Name)}: {Name}\n" +
                              $"Enemy stats:\n" +
                              $"{nameof(EnemyStats.Health)} - {Stats.Health}\n" +
                              $"{nameof(EnemyStats.Defence)} - {Stats.Defence}\n" +
                              $"{nameof(EnemyStats.DodgeChance)} - {Math.Round(Stats.DodgeChance * 100, 2)}%\n" +
                              $"{nameof(EnemyStats.AttackPower)} - {Stats.AttackPower}\n" +
                              $"{nameof(EnemyStats.Speed)} - {Stats.Speed}\n\n" +
                              $"{nameof(EnemyStats.Strength)} - {Stats.Strength}\n" +
                              $"{nameof(EnemyStats.Stamina)} - {Stats.Stamina}\n" +
                              $"{nameof(EnemyStats.Agility)} - {Stats.Agility}\n" +
                              $"{nameof(EnemyStats.Dexterity)} - {Stats.Dexterity}.\n");
        }
    }
}