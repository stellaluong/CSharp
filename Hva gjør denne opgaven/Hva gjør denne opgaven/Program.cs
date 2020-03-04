using System;

namespace Hva_gjør_denne_opgaven
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            int allLetters = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine() ?? string.Empty;
                foreach (var character in text.ToUpper())
                {
                    allLetters++;
                    counts[character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        double percentage = 100 * counts[i] / allLetters;
                        string show = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - show.Length - 1;
                        Console.WriteLine(show);
                    }
                }
            }
        }
    }
}