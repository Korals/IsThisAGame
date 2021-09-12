using System;
using System.Collections.Generic;
using System.Linq;
using MaybeGame.Enemies;

namespace MaybeGame.Config
{
    public static class EnemyConfig
    {
        public static readonly EnemyRace[] EnemyRaces = Enum.GetValues<EnemyRace>().ToArray();

        public static IEnumerable<Enemy> GenerateEnemies() =>
            EnemyRaces.Select(enemyRace => new Enemy(enemyRace.ToString(), enemyRace));
    }
}