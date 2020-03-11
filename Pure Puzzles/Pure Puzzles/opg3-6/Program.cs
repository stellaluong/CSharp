using System;
using System.Dynamic;
using System.Linq;

namespace opg3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                var random = new Random();
                var key = "ABCDEF".ToCharArray();

                var plaintext = "ABCDEF";

                for (int i = 0; i < key.Length; i++)
                {
                    do
                    {

                        var randomindex = random.Next(i, key.Length);
                        swap(key, i, randomindex);


                    } while (key[i] == plaintext[i] && i < key.Length - 1);
                }

                if (key.Last() == plaintext.Last())
                {
                    swap(key, key.Length - 1, key.Length - 2);
                }

                Console.WriteLine(key);
                Console.ReadLine();
            }
        }
        private static void swap(char[] key, int i, int j)
        {
            var temp = key[i];
            key[i] = key[j];
            key[j] = temp;
        }
    }
}
