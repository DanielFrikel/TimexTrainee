using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SayHi("Mike", 33);
            //SayHi("John", 56);
            //SayHi("Tom", 12);

            //int cubedNumber = Cube(5);
            //Console.WriteLine(cubedNumber);


            //If Statement
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall) 
            {
                Console.WriteLine("You are not a man but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male or not tall");
            }

            //===========================================================================

            //More If Statements

            Console.WriteLine(GetMax(20,10,40));


            Console.ReadKey();
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello user " + name + ", you are " + age);
        }

        static int Cube(int num) 
        {
            int result = num * num * num;

            return result;
        }

        static int GetMax(int num1, int num2, int num3) {
            int result;
            if (num1 > num2 &&  num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3) {
                result = num2;
            }
            else {
                result = num3;
            }
            return result;
        }
    }
}
