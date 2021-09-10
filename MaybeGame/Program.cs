using System;

namespace MaybeGame
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Main code goes here
            var gameMaster = new GameManager();

            Console.WriteLine("Hello and welcome to (Game name here)\n Created by Koralg\n");
            gameMaster.Start();

        }
    }
}
