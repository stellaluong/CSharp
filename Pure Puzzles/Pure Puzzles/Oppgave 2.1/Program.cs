using System;

namespace Pure_Puzzles
{
    class Program
    {

        static void Main(string[] args)
        {
            for (var i = 3; i > 0; i--)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }

            for (var i = 0; i < 4; i++)
            {
                Space(i);
                Hash(8 - 2 * i);
                NewLine();
            }

            NewLine();
        }

        private static void Hash(int count)
        {
            for (var i = 0; i < count; i++) Hash();
        }

        private static void Hash()
        {
            Console.Write("#");
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }

        private static voice Space(int count)
        {
            for (var i = 0; i < count; i++) Space();
        }

        private static void Space()
        {
            Console.Write(" ");
        }
    }
}






