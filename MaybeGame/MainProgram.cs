using System;

namespace MaybeGame
{
    partial class MainProgram
    {
        static void Main(string[] args)
        {
            //Main code goes here
            var gameManager = new GameMaster();

            Console.WriteLine("Hello and welcome to (Game name here)\n Created by Koralg\n");
            gameManager.Start();

        }
    }
}
