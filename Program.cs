using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                PrintInstructions();
                string userInput = Console.ReadLine();
                string lowerCaseInput = userInput.ToLower();
                if (lowerCaseInput == "exit")
                {
                    active = false;
                }
                else
                {
                    int vowelCount = 0;
                    char[] charArray = lowerCaseInput.ToCharArray();
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (charArray[i] == 'a' || charArray[i] == 'e' || charArray[i] == 'i' || charArray[i] == 'o' || charArray[i] == 'u')
                        {
                            vowelCount++;
                        }
                    }
                    Console.WriteLine("\nNumber of vowels in \"{0}\": {1}\n", userInput, vowelCount);
                }
            }
        }

        private static void PrintInstructions()
        {
            Console.WriteLine("Please type in a word and the program will check how many vowels are in the word or type exit to leave the program: ");
        }
    }
}
