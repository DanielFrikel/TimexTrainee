using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel.Games
{
    internal class MaxGame
    {
        //private static char op;
        private static double num1, num2, num3;
        private static bool validNum;
        private static string wannaGoMain;
        public static void startMaxGame()
        {
            Console.Clear();
            validNum = true;

            //Greetings
            Console.WriteLine("====== Welcome to Max Number ======");
            do
            {
                try
                {
                    Console.Write("Enter the First Number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the Second Number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the Third Number: ");
                    num3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nThe Biggest is: {GetMax(num1, num2, num3)}!");                    
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.WriteLine("\nError, invalid input. Must be a number, please, try again. " + e + "\n");
                }
            } while (validNum);

            Console.WriteLine("\nType 'yes' to go Back to Main Menu. Any else to exit.");
            wannaGoMain = Console.ReadLine();
            backToMenu();
        }
        static double GetMax(double num1, double num2, double num3)
        {            
            validNum = false;
            double result;
            if (num1 > num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        static void backToMenu() {

            Console.WriteLine("\nType 'yes' to go Back to Main Menu. Any else to exit.");

            wannaGoMain = Console.ReadLine();            
            wannaGoMain.ToLower();
            wannaGoMain.Trim();

            if (wannaGoMain == "yes") {
                Console.Clear();
                Menu.startMenu();
            }
        }
    }
}
