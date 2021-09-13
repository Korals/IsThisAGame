using MaybeGame.Config;
using MaybeGame.Enemies;
using MaybeGame.Players;
using System;
using System.Linq;
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
            PrintMenuData();
            var menuSelection = ParsePlayerInput();
            PlayerMenuChoice(menuSelection);
        }
        private void PrintMenuData()
        {
            Console.WriteLine("\nMenu:\n" +
                              "1. Add new player\n" +
                              "2. Add Enemies\n" +
                              "3. Select a character\n" +
                              "4. Dump all player information\n" +
                              "5. Dump all enemy information\n" +
                              "6. Quit\n");
        }
    
        private int ParsePlayerInput()
        {
            var success = int.TryParse(Console.ReadLine(), out var menu);
            if (success == false)
            {
                Console.WriteLine("Wrong option. Try again!");
                PrintMenuData();
                ParsePlayerInput();
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
                    var selection = ParseCharacterSelection();
                    GetPlayerById(selection);
                    break;
                case 4:
                    DumpPlayersData();
                    break;
                case 5:
                    DumpEnemiesData();
                    break;
                case 6:
                    playerWantsToQuit = true;
                    break;
                default:
                    Console.WriteLine("I am sorry. but this doesn't work");
                    break;
            }

            if (playerWantsToQuit) return;
            else Start();
        }
        private int ParseCharacterSelection()
        {
            DumpPlayerNameAndLevel();
            Console.WriteLine("Select your character:");
            var success = int.TryParse(Console.ReadLine(),out var selection);
            if (success == false)
            {
                Console.WriteLine("Please select one of the characters!");
                ParseCharacterSelection();
            }
            return selection;
        }
        private Player GetPlayerById(int id) => Players.FirstOrDefault(p => p.Id == id);
        public void DumpPlayerNameAndLevel()
        {
            var number = 1;
            foreach (var player in Players)
            {
                player.GetPlayerNameAndLevel(number);
                number++;
            }
        }
        private void AddNewPlayer()
        {
            var (userName, clanName, race, id) = ParsePlayerData();

            var player = new Player(userName, clanName, race, id);

            Players.Add(player);
        }

        private (string UserName, string ClanName, int Race, int Id) ParsePlayerData()
        {
            Console.WriteLine("Enter player name");
            var userName = Console.ReadLine();
            Console.WriteLine("Enter clan name");
            var clanName = Console.ReadLine();
            var race = ParseRace();
            var id = Players.Select(p => p.Id).Max() + 1;

            return (userName, clanName, race, id);
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