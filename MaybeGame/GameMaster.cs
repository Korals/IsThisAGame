using System;
using System.Collections.Generic;

namespace MaybeGame
{
    public class GameMaster
    {
        private List<Player> _players { get; } = new();
        private List<Enemy> _enemies { get; } = new();

        public void DumpPlayersData()
        {
            foreach (var p in _players)
                p.DataDump();
        }
        public void DumpEnemiesData()
        {
            foreach (var e in _enemies)
                e.DataDump();
        }

        public void Start()
        {
            WriteGameMenu();
        }

        private void WriteGameMenu()
        {
            Console.WriteLine("\nMenu:\n" +
                        "1. Add new player\n" +
                        "2. Add Enemies\n" +
                        "3. Dump all player information\n" +
                        "4. Dump all enemy information\n" +
                        "5. Quit\n");

            var success = int.TryParse(Console.ReadLine(), out var menu);
            if (success == false)
            {
                Console.WriteLine("You have entered a wrong number");
                WriteGameMenu();
            }

            var playerWantsToQuit = false;
            switch (menu)
            {
                case 1:
                    AddNewPlayer();
                    break;
                case 2:
                    AddEnemies();
                    break;
                case 3:
                    DumpPlayersData();
                    break;
                case 4:
                    DumpEnemiesData();
                    break;
                case 5:
                    playerWantsToQuit = true;
                    break;
                default:
                    Console.WriteLine("I am sorry. but this doesn't work");
                    break;
            }

            if (playerWantsToQuit) return;
            else Start();
        }

        private void AddNewPlayer()
        {
            Console.WriteLine("Enter player name");
            var userName = Console.ReadLine();
            Console.WriteLine("Enter clan name");
            var clanName = Console.ReadLine();
            var player = new Player();
            player.StatSet(userName, clanName);
            _players.Add(player);
        }
        private void AddEnemies()
        {
            Console.WriteLine("Adding enemies");
            _enemies.Add(EnemyConfig.CreateZombie());
            _enemies.Add(EnemyConfig.CreateSkeleton());
            _enemies.Add(EnemyConfig.CreateBandit());
            _enemies.Add(EnemyConfig.CreateTheif());
            _enemies.Add(EnemyConfig.CreateWarrior());
            _enemies.Add(EnemyConfig.CreateBerserker());
            _enemies.Add(EnemyConfig.CreateRat());
            Console.WriteLine("Enemies added!");

        }
    }
}
