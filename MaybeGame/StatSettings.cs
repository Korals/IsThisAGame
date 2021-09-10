namespace MaybeGame
{
    public class StatSettings
    {
        public void PlayerStatSet(string userName, string clanName)
        {
            Player player = new();
            PlayerStats playerStats = new();
            PlayerExperience playerExperience = new();
            player.UserName = userName;
            player.ClanName = clanName;
            player.Race = (PlayerRace)player.RaceInfo();
            playerExperience.ExperiencePoints = 0;
            playerExperience.Level = 1;
            playerStats.Strength = playerStats.SetStrength(player.Race);
            playerStats.Stamina = playerStats.SetStamina(player.Race);
            playerStats.Agility = playerStats.SetAgility(player.Race);
            playerStats.Dexterity = playerStats.SetDexterity(player.Race);
            playerStats.Health = playerStats.SetHealth(playerStats.Stamina);
            playerStats.Defence = playerStats.SetDefence(playerStats.Stamina);
            playerStats.DodgeChance = playerStats.SetDodgeChance(playerStats.Dexterity);
            playerStats.Speed = playerStats.SetSpeed(playerStats.Agility);
            playerStats.AttackPower = playerStats.SetAttackPower(playerStats.Strength);
        }
        public void EnemyStatSet(EnemyType enemyType)
        {
            Enemy enemy = new();
            EnemyStats enemyStats = new();
            enemy.EnemyName = enemyType.ToString();
            enemyStats.Strength = enemyStats.SetStrength(enemyType);
            enemyStats.Stamina = enemyStats.SetStamina(enemyType);
            enemyStats.Agility = enemyStats.SetAgility(enemyType);
            enemyStats.Dexterity = enemyStats.SetDexterity(enemyType);
            enemyStats.Health = enemyStats.SetHealth(enemyStats.Stamina);
            enemyStats.Defence = enemyStats.SetDefence(enemyStats.Stamina);
            enemyStats.DodgeChance = enemyStats.SetDodgeChance(enemyStats.Dexterity);
            enemyStats.Speed = enemyStats.SetSpeed(enemyStats.Agility);
            enemyStats.AttackPower = enemyStats.SetAttackPower(enemyStats.Strength);
        }
    }
}
