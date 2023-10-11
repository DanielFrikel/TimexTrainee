using AppMenuDaniel.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel
{
    static class Menu
    {
        //op field for Option to select in the menu [1-5]
        private static string op;
        private static bool isValidNum;

        //Start the menu and request an option
        public static void startMenu()
        {            
            isValidNum = true;
            string[] optionsInMenu = new string[5] { "1", "2", "3", "4", "5" };

            //DoWhile loop to select another option, as long as the user wants it.
            do
            {
                showMenu();
                op = Console.ReadLine();
                
                switch (op)
                {
                    case "1":
                        Calculator.startCalculator();
                        break;
                    case "2":
                        DayGame.startDayGame();
                        break;
                    case "3":
                        PowGame.startPowGame();
                        break;
                    case "4":
                        GuessGame.SecretWord = "word";
                        GuessGame.startGuessGame();
                        break;
                    case "5":
                        MaxGame.startMaxGame();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nInvalid Option, must be [1-5]\n");
                        break;
                }                
            } while (!optionsInMenu.Contains<string>(op));

        }

        //Displays the menu
        public static void showMenu() {
            Console.WriteLine(                              
                              "====== MENU ======" +
                              "\nChoose an Option:" +
                              "\n1) Calculator" +
                              "\n2) Day of the Week" +
                              "\n3) Pow Number" +
                              "\n4) Guessing Game" +
                              "\n5) Max Number of 3\n"
                              );
        }

    }
}
