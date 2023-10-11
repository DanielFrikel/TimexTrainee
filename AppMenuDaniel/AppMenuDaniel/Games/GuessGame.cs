using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel
{
    static class GuessGame
    {
        //wanna field for request if want to go back.
        //secretWord is the secret word to guess.
        private static string wannaGoMain;
        private static string secretWord = "giraffe";

        //Starts the GuessGame
        public static void startGuessGame() {
            //Clear the console to remove unnecessary content.
            Console.Clear();            

            //guess is the input of the user
            //guessCount is count of trys.
            //guessLimit is the limit of trys.
            //outOfGuesses means if the user guessed the word.
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            //Greetings
            Console.WriteLine("====== Welcome to Guess Game ======");
            Console.WriteLine("Only 3 Oportunities");

            //While loop as long as the guessLimit or if the secretWord is guessed
            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            }

            //if user guessed, show won, if user didnt guess show loss.
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");
            }


        }

        //Property to change the secretWord to guess.
        public static string SecretWord {
            get { return secretWord;  }
            set { secretWord = value; }
        }

        //Method to return to the MainMenu.
        //If the user input "yes", he will go back.
        static void backToMenu()
        {
            Console.WriteLine("\nType 'yes' to go Back to Main Menu. Any else to exit.");

            wannaGoMain = Console.ReadLine();
            wannaGoMain.ToLower();
            wannaGoMain.Trim();

            if (wannaGoMain == "yes")
            {
                Console.Clear();
                Menu.startMenu();
            }
        }

    }
}
