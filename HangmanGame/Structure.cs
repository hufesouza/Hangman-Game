using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Structure
    {
        public static string secretWordStructure;
        public static string secretStruMessage;
        public void SecretStructure(string secretWord, char guessedLetter)
        {
            if (guessedLetter == ' ')
            {
                foreach (char l in secretWord)
                {
                    secretWordStructure = "-" + secretWordStructure;
                }
                Console.Clear();

                if (secretWord.Length > 1)
                {
                    secretStruMessage = $"   the secret word contains {secretWordStructure.Length} letters";
                }
                else
                {
                    secretStruMessage = $"   the secret word contains {secretWordStructure.Length} letter";
                }
            }
        }

        public void MainStructures()
        {
            switch (Inputs.failedInputCounter)
            {
                case 0:
                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    break;

                case 1:

                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        O ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    break;

                case 2:
                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        O");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    break;

                case 3:
                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        O");
                    Console.WriteLine(@"    |       \|");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    break;

                case 4:
                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        O");
                    Console.WriteLine(@"    |       \|/");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    break;

                case 5:
                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        O");
                    Console.WriteLine(@"    |       \|/");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |       / ");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    break;

                case 6:
                    Console.WriteLine("     ________");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        |");
                    Console.WriteLine("    |        O");
                    Console.WriteLine(@"    |       \|/");
                    Console.WriteLine("    |        |");
                    Console.WriteLine(@"    |       / \");
                    Console.WriteLine("    |         ");
                    Console.WriteLine("____|____     ");
                    Console.WriteLine("\n");
                    Console.WriteLine($"You tried the word: {Inputs.guessedWord}, and lost everything. The correct word is {Inputs.secretWord.ToUpper()}");
                    break;

                default:
                    break;
            }
            
        }
    }
}
