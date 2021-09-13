using MaybeGame.Config;
using MaybeGame.Enemies;
using MaybeGame.Players;
using System;
using System.Collections.Generic;

namespace MaybeGame
{
    public class GameManager
    {
        private List<Player> Players { get; } = new();
        private List<Enemy> Enemies { get; } = new();

        private void DumpPlayersData()
        {
            foreach (var p in Players)
                p.DumpPlayerData();
        }

        private void DumpEnemiesData()
        {
            foreach (var e in Enemies)
                e.DumpEnemyData();
        }

        public void Start()
        {
            WriteGameMenu();
        }
        private void WriteGameMenu()
        {
            var menuSelection = ParseMenuData();
            PlayerMenuChoice(menuSelection);
        }
        private int ParseMenuData()
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
                ParseMenuData();
            }
            return menu;
        }
        private void PlayerMenuChoice(int menu)
        {
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
            var (userName, clanName, race) = ParsePlayerData();

            var player = new Player(userName, clanName, race);

            Players.Add(player);
        }

        private (string UserName, string ClanName, int Race) ParsePlayerData()
        {
            Console.WriteLine("Enter player name");
            var userName = Console.ReadLine();
            Console.WriteLine("Enter clan name");
            var clanName = Console.ReadLine();
            var race = ParseRace();

            return (userName, clanName, race);
        }

        private static int ParseRace()
        {
            Console.WriteLine("Please select your race:\n" +
                              "1. Human\n" +
                              "2. Drawf\n" +
                              "3. Elf\n" +
                              "4. Undead\n");

            var race = Console.ReadLine();

            return int.TryParse(race, out var raceNo) ? raceNo : ParseRace();
        }

        private void AddEnemies()
        {
            Console.WriteLine("Adding enemies...");
            Enemies.AddRange(EnemyConfig.GenerateEnemies());
            Console.WriteLine("Enemies added!");
        }
    }
}