using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPow(3,2));

            int[,] numberGrid = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] myArray = new int[2, 3];
            Console.WriteLine(numberGrid[0,1]);

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            //catch(Exception e)
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //This piece of code is always executed.
            }

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
