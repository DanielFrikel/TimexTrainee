using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuDaniel
{
    static class Calculator
    {
        private static char op;
        private static double num1, num2;
        private static bool validNum;
        private static string wannaGoMain;
        public static void startCalculator() {
            char[] options = new char[] { '+','-','/','*'};
            Console.Clear();
            validNum = true;
            //Greetings
            Console.WriteLine("====== Welcome to Basic Calculator ======");
            
            //Start Calculator
            do { 
                try
                {
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Operator: ");
                    op = Convert.ToChar(Console.ReadLine());
                    if (!options.Contains(op))
                    {
                        Console.WriteLine("\nError, ingrese un operador correcto. [+,-,*,/]");
                        continue;
                    }

                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                        
                    Console.WriteLine($"\nYour result is: {startOperation(op)}!");
                }
                catch (FormatException e) {
                    Console.Clear();                    
                    Console.WriteLine("\nError, invalid input. " + e + "\n");
                }
            } while (validNum);

        }

        public static double startOperation(char op) {
            validNum = false;
            if (op == '+')
            {
                return num1 + num2;
            }
            else if (op == '-')
            {
                return num1 - num2;
            }
            else if (op == '*')
            {
                return num1 * num2;
            }
            else if (op == '/')
            {
                return num1 / num2;
            }
            return 0;
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
