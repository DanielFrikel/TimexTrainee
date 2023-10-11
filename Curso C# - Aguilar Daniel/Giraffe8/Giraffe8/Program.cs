using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek","Adam Adamson", "PG");
            //G, PG, PG-13, R, NR
            shrek.Rating = "Dog";
            Console.WriteLine(shrek.Rating+"\n");
            
            //====================================================================================================

            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            //songCount is a static atribute that belongs to the class
            //Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());
            Console.WriteLine(kashmir.artist + "\n");

            //====================================================================================================

            //UsefulTools tools = new UsefulTools();
            UsefulTools.SayHi("Daniel" + "\n");

            //====================================================================================================

            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();



            Console.ReadKey();
        }
    }
}
