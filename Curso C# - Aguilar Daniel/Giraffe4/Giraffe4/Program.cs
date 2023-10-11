using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //========================================================================
            ////Better Calculator
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Operator");
            //}
            //========================================================================

            //Switch Statement
            Console.WriteLine(GetDay(5)+"\n");

            //========================================================================

            //While Loops

            int index = 1;
            while (index <= 5) {
                Console.WriteLine(index);
                index++;
            }

            index = 1;
            Console.WriteLine();
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

            //========================================================================

            Console.ReadKey();
        }

        static string GetDay(int dayNum) {
            string dayName;

            switch (dayNum) {
                case 0:
                    dayName = "Sunday"; 
                    break;
                case 1:
                    dayName = "Monday"; 
                    break;
                case 2:
                    dayName = "Tuesday"; 
                    break;
                case 3:
                    dayName = "Wednesday"; 
                    break;
                case 4:
                    dayName = "Thursday"; 
                    break;
                case 5:
                    dayName = "Friday"; 
                    break;
                case 6:
                    dayName = "Saturday"; 
                    break;
                default:
                    dayName = "Error, invalid day number";
                    break;
            }


            return dayName;
        }
    }
}
