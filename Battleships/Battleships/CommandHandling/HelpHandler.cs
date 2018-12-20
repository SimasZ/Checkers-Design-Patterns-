using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.CommandHandling
{
    class HelpHandler : Handler
    {
        public override void HandleLocal(string command, List<string> args, string line)
        {
            switch (command)
            {
                case "help":
                {
                    Console.WriteLine("Available commands:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("print map");
                    Console.ResetColor();
                    Console.WriteLine(" - shows a game board.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("print opponent map");
                    Console.ResetColor();
                    Console.WriteLine(" - prints opponent's map (works only in gameplay state).");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("print placed units");
                    Console.ResetColor();
                    Console.WriteLine(" - shows all placed ships.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("print unplaced units");
                    Console.ResetColor();
                    Console.WriteLine("- shows all unplaced ships.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("place -ship's name -x -y -rotation (0 - horizontal, 1 - vertical)/");
                    Console.ResetColor();
                    Console.WriteLine(" - places a ship on board.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("name -name");
                    Console.ResetColor();
                    Console.WriteLine(" - sets your name.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("say -message");
                    Console.ResetColor();
                    Console.WriteLine(" - sends a message to opponent.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("attack -x -y [-weapon]");
                    Console.ResetColor();
                    Console.WriteLine(" - attacks enemy's board.");
                    return;
                }
                case "print map":
                {

                    return;
                }
            }
            base.HandleLocal(command, args, line);
        }
    }
}
