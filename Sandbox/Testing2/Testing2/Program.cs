using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    interface IAnimal 
    {
        void animalSound();
        void animalName();
    }

    interface ILegs 
    {
        void howManyLegs();
    }

    public class Cow : IAnimal, ILegs {
        public void animalSound()
        {
            Console.WriteLine("The animal says: Muuu");
        }
        public void animalName()
        {
            Console.WriteLine("The animal is a Cow.");
        }


        public void howManyLegs()
        {
            Console.WriteLine("The Cow has 4 legs.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 26;
            //C# does not support "multiple inheritance"
            //(a class can only inherit from one base class).
            //However, it can be achieved with interfaces,
            //because the class can implement multiple interfaces.
            //Note: To implement multiple interfaces,
            //separate them with a comma (see example below).
            Cow cow = new Cow();
            cow.animalSound();
            cow.animalName();

            cow.howManyLegs();            
            Action anonymousFunction = () => Console.WriteLine("Funcion Anonima");
            anonymousFunction();
            
            //<type of first parameter, type of second, output(type of return value)>
            Func<int, int, int> multiply = (num1, num2) => num1 * num2;
            Console.WriteLine(multiply(3, 3));            

            Func<int, string> isAdult1 = edadThis =>
            {
                if (age >= 18)
                {
                    return "Is Adult!";
                }
                else
                {
                    return "Isn't Adult!";
                }
            };

            Func<int, string> isAdult2 = edadThis => (age >= 18) ? "Is Adult!" : "Isn't Adult!";

            Console.WriteLine(isAdult1(age)+"\n");
            ////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("================ Data Tables ==================");
            TestingDataTables test = new TestingDataTables();

            test.testingDataTables();

            Console.ReadKey();
        }
    }
}
