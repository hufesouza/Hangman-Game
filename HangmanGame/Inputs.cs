using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inputs

    {
        Structure gettingSecretStructure = new Structure();
        Rules rules = new Rules();
        
        static public string guessedWord = " ";
        static public string secretWord;
        static public int failedInputCounter;
        static public int guessCounter = 0;

        bool isNotLetter = false;
        char guessedLetter = ' ';

        public void Start()
        {
            Console.WriteLine("Enter the secret word:");
            secretWord = Console.ReadLine().ToLower();

            foreach (char n in secretWord)
            {
                if (!char.IsLetter(n))
                {
                    isNotLetter = true;
                }

            }
            if (!isNotLetter && secretWord.Length > 0)
            {
                gettingSecretStructure.SecretStructure(secretWord, guessedLetter);
                gettingSecretStructure.MainStructures();
                GuessInput();
            }
            else
            {
                Console.WriteLine("Please, enter only alphabetic values. Press 'enter' to try again.");
                Console.ReadLine();
                Console.Clear();
                isNotLetter = false;
                Start();
            }
        }

        public void GuessInput()
        {
            Console.WriteLine(Structure.secretWordStructure + Structure.secretStruMessage);
            Console.WriteLine("\n");

            for (failedInputCounter = 0; failedInputCounter < 6;)
            {
                Console.WriteLine("Please enter letter or if your feeling luck you can risk it all trying to guess the word: ");
                guessedWord = Console.ReadLine();
                guessedWord = guessedWord.ToLower();

                if (guessedWord.Length > 1)
                {
                    guessCounter++;
                    if (guessedWord.Contains(" ") || guessedWord.Contains("\t") || rules.ThereIsNumber(guessedWord))
                    {
                        Console.WriteLine("Invalid enter, press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                        gettingSecretStructure.MainStructures();
                        GuessInput();
                    }
                    else if (rules.Winner())
                    {
                        break;
                    }

                    else if (!rules.Winner())
                    {
                        Console.Clear();
                        failedInputCounter = 6;
                        gettingSecretStructure.MainStructures();
                        break;             
                    }
                }
                else if (guessedWord.Length < 2 && guessedWord != "")
                {
                    guessedWord.ToCharArray();
                    rules.NotNumber(guessedWord[0]);                   
                }
                guessCounter++;
                if (rules.Winner())
                {
                    break;
                }
            }         
        }
    }
}
