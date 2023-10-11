using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel
{
    static class PowGame
    {
        //private static char op;
        private static int num1, num2;
        private static bool validNum;
        private static string wannaGoMain;
        public static void startPowGame() {
            Console.Clear();
            validNum = true;

            //Greetings
            Console.WriteLine("====== Welcome to Pow Number ======");

            do
            {
                try
                {
                    Console.Write("Enter a Number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Another Number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());                    

                    Console.WriteLine($"\nThe result is: {GetPow(num1,num2)}!");
                }
                catch (FormatException e)
                {
                    Console.Clear();                    
                    Console.WriteLine("\nError, invalid input. " + e + "\n");
                }
            } while (validNum);

        }

        static int GetPow(int baseNum, int powNum)
        {
            validNum = false;
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }

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

