using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape, first section            
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|\r\n");


            //Variables, second section
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge + "\r\n");

            
            //Data Types, third section
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            //float, double, decimal (decimal the most price for numbers after the point,
            //used for money)
            double gpa = 3.2;
            bool isMale = true;

            Console.WriteLine("30\r\n");


            //Strings, fourth section
            Console.WriteLine("Giraffe\nAcademy");
            Console.WriteLine("Giraffe\"Academy");
            string phrase2 = "Giraffe Academy" + " is cool";
            Console.WriteLine(phrase2);
            Console.WriteLine(phrase2.Length);
            Console.WriteLine(phrase2.ToUpper());
            Console.WriteLine(phrase2.ToLower());
            Console.WriteLine(phrase2.Contains("Academy"));
            Console.WriteLine(phrase2[2]);
            Console.WriteLine(phrase2.IndexOf("Academy"));
            Console.WriteLine(phrase2.IndexOf('f'));
            //If the value doesn't exists it will return a negative integer (-1)
            Console.WriteLine(phrase2.IndexOf('z'));
            Console.WriteLine(phrase2.Substring(8));
            //Parameters means (start in specified position, number of characters after the initial position)
            Console.WriteLine(phrase2.Substring(8,3)+ "\n");


            //Numbers, fifth section
            Console.WriteLine(50);
            Console.WriteLine(5 % 2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);

            int num = 6;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Truncate(9.4) + "\n");


            //User Input, sixth section
            Console.WriteLine("Write your name here: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age1 = Console.ReadLine();
            Console.WriteLine("Hello " + name1 + ", you are " + age1);



            Console.ReadLine();
        }
    }
}
