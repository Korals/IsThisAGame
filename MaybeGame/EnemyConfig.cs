namespace MaybeGame
{
    public static class EnemyConfig
    {
        public static Enemy CreateZombie()
        {
            var enemy = new Enemy();
            enemy.StatSet("Zombie");
            return enemy;
        }

        public static Enemy CreateSkeleton()
        {
            Enemy enemy = new();
            enemy.StatSet("Skeleton");
            return enemy;
        }
        public static Enemy CreateBandit()
        {
            Enemy enemy = new();
            enemy.StatSet("Bandit");
            return enemy;
        }
        public static Enemy CreateTheif()
        {
            Enemy enemy = new();
            enemy.StatSet("Theif");
            return enemy;
        }
        public static Enemy CreateWarrior()
        {
            Enemy enemy= new();
            enemy.StatSet("Warrior");
            return enemy;
        }
        public static Enemy CreateBerserker()
        {
            Enemy enemy = new();
            enemy.StatSet("Berserker");
            return enemy;
        }
        public static Enemy CreateRat()
        {
            Enemy enemy = new();
            enemy.StatSet("Rat");
            return enemy;
        }
    }
}
