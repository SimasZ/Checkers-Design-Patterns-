using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.CommandHandling {
	class TurnHandler : Handler{
		public GameInstance instance;

		public override void HandleLocal(string command, List<string> args, string line) {
			switch (command) {
                case "attack":
                    {
                        if (args.Count != 3 && args.Count != 2)
                        {
                            break;
                        }
                        if (!instance.yourTurn)
                        {
                            Console.WriteLine("Not your turn!");
                            return;
                        }
                        
                        int x, y;
                        Int32.TryParse(args[0], out x);
                        Int32.TryParse(args[1], out y);

                        string weaponType = "regular";
                        if (args.Count == 3)
                        {
                            weaponType = args[2];
                        }

                        if (instance.OpponentTileIsHit(x, y))
                        {
                            Console.WriteLine("This tile is already hit");
                            return;
                        }

                        bool unitDestroyed;
                        bool unitHasBeenHit = instance.HitOpponentBoard(x, y, out unitDestroyed);
                        if (unitHasBeenHit)
                        {
                            Console.WriteLine("The tile containing unit has been hit");
                            if (unitDestroyed)
                            {
                                Console.WriteLine("Unit destroyed");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The tile you hit was empty");
                        }
                        Program.connection.SendCommand(String.Format("hit {0} {1} {2}", x, y, unitHasBeenHit ? (unitDestroyed ? "destroyed" : "hit") : "miss"));
                        Program.connection.SendCommand("endturn");
                        instance.yourTurn = !instance.yourTurn;
                        return;
                    }
			    case "print":
			    {
			        if (args[0].Equals("map"))
			        {
			            instance.yourBoard.PrintMap();
                    }
			        return;
			    }
			}
			base.HandleLocal(command, args, line);
		}

		public override void HandleOut(string command, List<string> args, string line) {
			switch (command) {
                case "endturn":
                    {
                        Console.WriteLine("Opponent ended his turn");
                        instance.yourTurn = !instance.yourTurn;
                    }
                    return;
                case "hit":
                    {
                        int x, y;
                        Int32.TryParse(args[0], out x);
                        Int32.TryParse(args[1], out y);
                        string hitStatus = args[2];
                        if (hitStatus == "hit")
                        {
                            hitStatus = " and hit your unit";
                        }
                        else if (hitStatus == "destroyed")
                        {
                            hitStatus = " and destroyed your unit";
                        }
                        else
                        {
                            hitStatus = ", but missed";
                        }
                        Console.WriteLine("Opponent shot at x:{0} y:{1}{2}", x, y, hitStatus);
                    }                    
                    return;
			}
			base.HandleOut(command, args, line);
		}
	}
}
