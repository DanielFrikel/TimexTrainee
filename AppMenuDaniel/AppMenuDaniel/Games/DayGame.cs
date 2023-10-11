using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel
{
    static class DayGame
    {
        //Private fields of the dayGame.
        private static int dayNum;
        private static bool validNum;
        private static string wannaGoMain;

        //Start the DayGame
        public static void startDayGame() {
            Console.Clear();
            validNum = true;

            //Greetings
            Console.WriteLine("====== Welcome to Day Game ======");

            //Try Catch in DoWhile loop to input a valid number.
            do {
                try
                {   //The user input a number to select a Day
                    Console.WriteLine("Please, insert a Number [0-6]:");
                    dayNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n"+GetDay(dayNum));
                }
                //Catch to show errors and exceptions of the number to input.
                catch (FormatException e) {
                    Console.Clear();                    
                    Console.WriteLine("\nError, the Number must be [0-6]. " + e+"\n");
                }
                //Bool validNum means that the user inputted a valid Number
            } while (validNum);
        }

        //string method that returns the day according to the number sent
        static string GetDay(int dayNum)
        {
            string dayName;
            //validNum turns to false, to stop repeating the dowhile valid num loop
            validNum = false;

            //Switch that evalueate the day number
            switch (dayNum)
            {
                case 0:
                    dayName = "Your day is Sunday!";
                    break;
                case 1:
                    dayName = "Your day is Monday";
                    break;
                case 2:
                    dayName = "Your day is Tuesday";
                    break;
                case 3:
                    dayName = "Your day is Wednesday";
                    break;
                case 4:
                    dayName = "Your day is Thursday";
                    break;
                case 5:
                    dayName = "Your day is Friday";
                    break;
                case 6:
                    dayName = "Your day is Saturday";
                    break;
                default:
                    dayName = "Error, invalid day number";
                    break;
            }

            //the methods return the corresponding string value.
            return dayName;
        }

        //backToMenu method to return to main menu
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
