using System;
using System.Linq;
using System.Text;


namespace Oppgave_3_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            var key = "abcdefg".ToCharArray();
            var plainText = "bade";
            string cipherText = Encrypt(plainText, key, 11);

            string[] rng = new string[1];
            for (var i = 0; i < rng.Length; i++)
            {
                rng[i] = Encrypt(plainText, key, 1);
            }
            Console.WriteLine("Plain     : {0}", plainText);
            Console.WriteLine("Encrypted : {0}", rng);
            Console.ReadKey();
        }

        public static string Encrypt(string plainText, string key, int length)
        {
            key = "abcdefg";
            StringBuilder result = new StringBuilder(length);
            Random rnd = new Random();
            char[] chars = new char[plainText.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                result.Append(key[rnd.Next(plainText.Length)]);

            }
            return result.ToString();
        }


    }
}