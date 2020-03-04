using System;
using System.Linq;

namespace PasswordGenerator
{
    class Program
    {
        static readonly Random Random = new Random();
        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];
            var pattern = options.PadRight(length, 'l');
            var password = string.Empty;
            while (pattern.Length > 0)
            {
                var randomIndex = Random.Next(0, pattern.Length - 1);
                var category = pattern[randomIndex];
                pattern = pattern.Substring(0, randomIndex)
                          + pattern.Substring(randomIndex + 1, pattern.Length - randomIndex - 1);

                if (category == 'l') password += RandomLowerCase();
                else if (category == 'L') password += RandomUpperCase();
                else if (category == 'd') password += RandomDigit();
                else password += RandomSpecialCharacter();
            }
            Console.WriteLine(password);
              }
              
             static char RandomSpecialCharacter()
            {
                var allSpecialCharacter = "!\"#¤%&/(){}[]";
                var index = Random.Next(0, allSpecialCharacter.Length - 1);
                return allSpecialCharacter[index];
            }
             static char RandomDigit()
            {
                return Random.Next(0, 9).ToString()[0];
            }

        static char RandomUpperCase()
            {
                return GetRandomLetter('A', 'Z');
            }
            static char RandomLowerCase()
            {
                return GetRandomLetter('a', 'z');
            }
            static char GetRandomLetter(char min, char max)
            {
                return (char)Random.Next(min, max);
            }
            static bool IsValid(string[] args)
            {
                if (args.Length != 2) return false;

                var lengthStr = args[0];
                var options = args[1];
            if (options.Any(character => character != 'l'
                                         && character != 'L'
                                         && character != 'd'
                                         && character != 's'))
            {
                return false;
            }
            return lengthStr.All(char.IsDigit);
            }
            private static void ShowHelpText()
            {
                Console.WriteLine("PasswordGenerator <length> <options>");
                Console.WriteLine("  Options:");
                Console.WriteLine("  - l = lower case letter");
                Console.WriteLine("  - L = upper case letter");
                Console.WriteLine("  - d = digit");
                Console.WriteLine("  - s = special character (!\"#¤%&/(){}[]");
                Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
                Console.WriteLine("         Min. 1 lower case");
                Console.WriteLine("         Min. 1 upper case");
                Console.WriteLine("         Min. 2 special characters");
                Console.WriteLine("         Min. 2 digits");
            }
        }
        
    }

