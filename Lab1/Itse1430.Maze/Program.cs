using System;

namespace Itse1430.Maze {
    class Program {
        static void Main() {
            Maze myMaze = new Maze();
            Console.WriteLine (myMaze.ToString());
            Console.WriteLine ("he");
        }

        static void CommandParser () {
            bool run = true;
            while (!run){
                Console.WriteLine ("Enter Command");
                string currLine = Console.ReadLine ();
                currLine = currLine.ToLower ();
                if (String.IsNullOrEmpty (currLine))
                        continue;
                switch (currLine){                   
                    case "q":
                        run =false;
                        break;
                    case "quit":
                        run =false;
                        break;
                    case "h":
                        HelpCommand ();
                        break;
                    case "help":
                        HelpCommand ();
                        break;
                    case "f":
                        //run =false;
                        break;
                    case "moveforward":
                        //run =false;
                        break;
                    case "b":
                        //run =false;
                        break;
                    case "movebackward":
                        //run =false;
                        break;
                    case "l":
                        //run =false;
                        break;
                    case "moveleft":
                        //run =false;
                        break;
                    case "r":
                        //run =false;
                        break;
                    case "moveright":
                        //run =false;
                        break;

                }

            }

        }
        static void HelpCommand () {
            string output = "";
            output+= "(H)elp".PadRight (15, ' ');
            output+= "(Q)uit".PadRight (15, ' ');
            output+= "Move(F)orward".PadRight (15, ' ');
            Console.WriteLine (output);
        }
    }
}
