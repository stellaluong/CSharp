using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace oppgave_3_7
{
    class Program
    {
        static void Occurrence(int[] numbers)
        {
            var groups = numbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            Console.WriteLine("The most common number is {0} and it appears {1} times", largest.Key, largest.Count());
        }
        public static void Main(string[] args)
        {

            int[] array = new int[20] { 3, 6, 8, 5, 4, 5, 4, 4, 4, 3, 2, 4, 5, 7, 6, 4, 3, 4, 5, 6 };
            Occurrence(array);

        }
    }
}
