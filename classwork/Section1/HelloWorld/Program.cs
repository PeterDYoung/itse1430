using System;

namespace HelloWorld
{
    class Program{
        static void Main ( /*string[] args*/ ){
            String title, description;
            int runLength, releaseYear;
            bool hasSeen;

            Char input = DisplayMenu ();
            if ( input == 'A'){
                AddMovie ();
            } else {

            }
        }

        private static void AddMovie (){
            Console.WriteLine ("Title: ");
            String title = Console.ReadLine ();
            Console.WriteLine ("Description: ");
            String discription = Console.ReadLine ();
            int releaseYear = ReadInt32("Realease Year: ");
            int runtime = ReadInt32 ("runtime (in minutes: ");
            bool hasSeen = ReadBool ("Have Seen?");

        }

        static int ReadInt32(string message ){
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
        private static char DisplayMenu () {
            do{
                Console.WriteLine ("A)dd Movie");
                Console.WriteLine ("Q)uit");

                String input = Console.ReadLine().ToUpper();
                
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


        private static void DemoLanguage (){
            String name = "bob";
            String name2;
            name2 = Console.ReadLine ();
            Console.WriteLine (name2);
            Console.WriteLine ("Hello World!");
        }
    }
}
