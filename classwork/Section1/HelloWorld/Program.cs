using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( /*string[] args*/ )
        {
            String title, description;
            int runLength, releaseYear;
            bool hasSeen;

            Char input = DisplayMenu ();
            if (input == 'A')
            {
                AddMovie ();
            } else
            {

            }
        }
        static void DisplayMovie () {
            //Title, description, release year, run length, hasSeen
            Console.WriteLine (title);
            Console.WriteLine (description);
            //2) Printf
            //Console.WriteLine("Run time: {0}", runLength);

            //3) String formatting
            var formattedString = String.Format ("Run time: {0}", runLength);
            Console.WriteLine (formattedString);
            //4) string interpolation


        }
        private static void AddMovie ()
        {
            Console.WriteLine ("Title: ");
            title = Console.ReadLine ();
            Console.WriteLine ("Description: ");
            description = Console.ReadLine ();
            releaseYear = ReadInt32 ("Realease Year: ");
            runLength = ReadInt32 ("runtime (in minutes: ");
            hasSeen = ReadBool ("Have Seen?");

        }

        static int ReadInt32 ( string message )
        {
            while (true)
            {
                Console.WriteLine (message);
                string input = Console.ReadLine ();

                int result;
                if (Int32.TryParse (input, out result))
                    return result;
            };
        }
        static bool ReadBool ( string message )
        {
            while (true)
            {
                Console.WriteLine (message);
                string input = Console.ReadLine ();

                bool result;
                if (Boolean.TryParse (input, out result))
                    return result;
            };
        }
        private static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("Q)uit");

                String input = Console.ReadLine ().ToUpper ();

                if (input == "A")
                {
                    return 'A';
                } else if (input == "Q")
                {
                    return 'Q';
                } else
                {
                    Console.WriteLine ("invalid input");
                }
            } while (true);
        }


        private static void DemoLanguage ()
        {
            String name = "bob";
            String name2;
            name2 = Console.ReadLine ();
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");
        }


        static void DemoArray ()
        {

            double[] payRates = new double[100];
            payRates[49] = 7.25;

        }
        static String title, description;
        static int runLength, releaseYear;
        static bool hasSeen;
    }

}
