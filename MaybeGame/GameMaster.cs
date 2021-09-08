using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeGame
{
    partial class MainProgram
    {
        public class GameMaster
        {
            private List<Player> _players { get; } = new();

            public void PlayerDataDump()
            {
                foreach (var p in _players)
                    p.DataDump();
            }

            public void Start()
            {
                Console.WriteLine("\nMenu:\n" +
                    "1. Add new player\n" +
                    "2. Dump all information\n" +
                    "3. Quit");

                var menu = int.Parse(Console.ReadLine());
                var playerWantsToQuit = false;

                switch (menu)
                {
                    case 1:
                        CaseOne();
                        break;
                    case 2:
                        PlayerDataDump();
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

            private void CaseOne()
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
