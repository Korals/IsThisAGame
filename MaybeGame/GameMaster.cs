using System;
using System.Collections.Generic;

namespace MaybeGame
{
    partial class MainProgram
    {
        public class GameMaster
        {
            private List<Player> _players { get; } = new();

            public void DumpPlayersData()
            {
                foreach (var p in _players)
                    p.DataDump();
            }

            public void Start()
            {
                WriteGameMenu();
            }

            private void WriteGameMenu()
            {
                Console.WriteLine("\nMenu:\n" +
                            "1. Add new player\n" +
                            "2. Dump all information\n" +
                            "3. Quit" +
                            "4. LevelUp");

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
                        DumpPlayersData();
                        break;
                    case 3:
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
        }
    }
}
