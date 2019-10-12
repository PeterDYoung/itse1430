// Peter Young Itse1430 10/11/19

using System;

namespace Itse1430.Maze {
    enum Direction { north = 0, south = 2, east = 1, west = 3 };
    enum DirectionOffset {left = -1, forward = 0, right = 1, around = 2 };
    class Program {
        static void Main() {
            Maze myMaze = new Maze();
            Console.WriteLine ("This is the maze");
            Console.WriteLine (myMaze.GetMazePrintout ());
            Console.WriteLine ("\n");
            CommandParser (myMaze);
        }

        static void CommandParser (Maze currMaze) {
            bool run = true;
            while (run){               
                Console.WriteLine ("Enter Command");
                string currLine = Console.ReadLine ();
                currLine = currLine.ToLower ();
                if (String.IsNullOrEmpty (currLine))
                        continue;
                switch (currLine){                   
                    case "q":
                    case "quit":
                        run =Quit();
                        break;
                    case "h":
                    case "help":
                        Help();
                        break;
                    case "f":
                    case "move forward":
                    case "moveforward":
                        currMaze.Move (DirectionOffset.forward);
                        break;
                    case "b":
                    case "movebackward":
                    case "move backward":
                        currMaze.Move (DirectionOffset.around);
                        break;
                    case "l":
                    case "moveleft":
                    case "move left":
                        currMaze.Move (DirectionOffset.left);
                        break;
                    case "r":
                    case "move right":
                    case "moveright":
                        currMaze.Move (DirectionOffset.right);
                        break;
                    case "turn around":
                        currMaze.Turn(DirectionOffset.around);
                        break;
                    case "turn right":
                        currMaze.Turn (DirectionOffset.right);
                        break;
                    case "turn left":
                        currMaze.Turn (DirectionOffset.left);
                        break;
                    case "look":
                    case "k":
                        currMaze.Examine ();
                        break;
                    default:
                        Console.WriteLine ("Command not recognized");
                        break;
                }

            }

        }
        static bool Quit() {
            Console.WriteLine ("Are you sure you wish to exit? (Y/N)");
            string response = Console.ReadLine ().ToLower();
            if (response=="y")
                return false;
            return true;
        }
        static void Help() {
            string output = "";
            output+= "\nCommands\n";
            output+= "(H)elp".PadRight (14, ' ');
            output+= "(Q)uit".PadRight (15, ' ');
            output+= "Loo(k)".PadRight (15, ' ');
            output+= "\nTurn Around".PadRight (15, ' ');
            output+= "Turn Right".PadRight (15, ' ');
            output+= "Turn Left".PadRight (15, ' ');

            output+= "\nMove(L)eft".PadRight (15, ' ');
            output+= "Move(R)ight".PadRight (15, ' ');
            output+= "Move(B)ackward".PadRight (15, ' ');
            output+= "\nMove(F)orward".PadRight (15, ' ');
            output+= "\n";
            Console.WriteLine (output);
        }
        
    }
}
