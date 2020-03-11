using System;

namespace Oppgave_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var iValue = new[] { 0, 1, 2, 3, 3, 2, 1, 0 };
            foreach (var i in iValue) Row(i);
        }
        private static void Row(int i)
        {
            Space(i);
            Hash(i + 1);
            Space(12 - i * 4);
            Hash(i + 1);
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

        private static void Space(int count)
        {
            for (var i = 0; i < count; i++) Space();
        }

        private static void Space()
        {
            Console.Write(" ");
        }
    }
}

