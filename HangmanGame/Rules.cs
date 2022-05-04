using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rules
    {
        int x = 0;
        bool thereIsLetter = false;

        public static List<char> attemptChar = new List<char>();
        public static List<string> attemptWord = new List<string>();

        Structure GettingMainStructure = new Structure();

        public void NotNumber(Char guessedLetter)
        {
            if (!char.IsLetter(guessedLetter))
            {
                Console.WriteLine("Please enter only letters.");
            }
            else if (char.IsLetter(guessedLetter) && !attemptChar.Contains(guessedLetter))
            {
                ReveallingWord(Inputs.secretWord, guessedLetter);
            }
            else
            {
                Console.WriteLine("Value already tried");
            }
        }

        public void ReveallingWord(string secretWord, char guessedLetter)
        {
            foreach (char l in secretWord)
            {
                if (secretWord[x] == guessedLetter)
                {

                    char[] tempArray = Structure.secretWordStructure.ToCharArray();
                    tempArray[x] = guessedLetter;
                    Structure.secretWordStructure = new string(tempArray);
                    Console.Clear();
                    GettingMainStructure.MainStructures();
                    Console.WriteLine(Structure.secretWordStructure + Structure.secretStruMessage);
                    Console.WriteLine("\n");
                    Winner();
                    thereIsLetter = true;
                }
                x++;
            }
            Attempts(guessedLetter);
            x = 0;
            thereIsLetter = false;
        }

        public void Attempts(char guessedLetter)
        {
            if (thereIsLetter == false && Inputs.failedInputCounter != 6)
            {
                Inputs.failedInputCounter++;
                attemptChar.Add(guessedLetter);
                Console.Clear();
                GettingMainStructure.MainStructures();
                Console.WriteLine(Structure.secretWordStructure + Structure.secretStruMessage);
                Console.WriteLine("\n");
            }
            else if (Inputs.failedInputCounter > 0 && Inputs.failedInputCounter < 6)
            {
                Console.Write($"You have tried letter: ");
            }

            foreach (object i in attemptChar)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\n");

            if (Inputs.failedInputCounter == 6)
            {
                Console.Clear();
                GettingMainStructure.MainStructures();
            }
        }

        public bool Winner()
        {
            if (Structure.secretWordStructure == Inputs.secretWord || Inputs.guessedWord == Inputs.secretWord)
            {
                Console.Clear();
                if (Inputs.guessCounter == 1)
                {
                    Console.WriteLine($"You are a good guesser, you got the word {Inputs.secretWord.ToUpper()} in {Inputs.guessCounter} attempt.");
                }else
                {
                    Console.WriteLine($"You are a good guesser, you got the word {Inputs.secretWord.ToUpper()} in {Inputs.guessCounter} attempts.");
                    Console.WriteLine("YOU ARE THE WINNER!");
                }
                return true;
            }
            return false;
        }

        public bool ThereIsNumber(string secretWord)
        {
            foreach (char y in secretWord)
            {
                if (char.IsLetter(y))
                {
                    continue;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
