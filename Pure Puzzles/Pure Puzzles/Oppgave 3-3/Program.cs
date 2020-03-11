using System;

namespace Oppgave_3_3
{
    class Program
    {

        public static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int number = numbers.Length;
            Console.WriteLine();
            Console.Write(NumSortedOrNot(numbers, number) ? "Yes\n" : "No\n");
        }

        private static bool NumSortedOrNot(int[] numbers, int number)
        {

            for (int i = 1; i < numbers.Length; i++)

                if (numbers[i] < numbers[i - 1])
                    return false;

            return true;
        }
    }
}
