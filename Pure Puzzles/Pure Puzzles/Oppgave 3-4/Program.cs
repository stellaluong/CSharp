using System;
using System.Net.Security;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace Oppgave_3_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rng = new Random();
            string key = "jfkgotmyvhspcandxlrwebquiz";
            string plainText = "i had a fat meal";
            string cipherText = Encrypt(plainText, key);
            string decryptText = Decrypt(cipherText, key);

            int rngNum = rng.Next(decryptText.Length);

            Console.WriteLine("Plain     : {0}", plainText);
            Console.WriteLine("Encrypted : {0}", cipherText[rngNum.Length]);
            Console.WriteLine("Decrypted : {0}", plainText);
            Console.ReadKey();
        }

        static string Encrypt(string plainText, string key)
        {
            char[] chars = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = plainText[i] - 97;
                    chars[i] = key[j];
                }
            }
            return new string(chars);
        }

        static string Decrypt(string cipherText, string key)
        {
            char[] chars = new char[cipherText.Length];

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = key.IndexOf(cipherText[i]) - 97;
                    chars[i] = (char)j;
                }
            }

            return new string(chars);
        }
    }
}

