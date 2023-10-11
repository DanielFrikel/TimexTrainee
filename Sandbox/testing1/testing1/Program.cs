using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car objmodel            
            Car mustang = new Car("Mustang","Gray",2010,"mx");                        
            Console.WriteLine(mustang.brand);
            Console.WriteLine(mustang.Nationality);
            Console.WriteLine(mustang.getCarCount());

            Car laxus = new Car("Laxus", "Silver", 2020, "us");
            Console.WriteLine(laxus.brand);
            laxus.Nationality = "us";
            Console.WriteLine(laxus.Nationality);
            Console.WriteLine(laxus.getCarCount() + "\n");            

            //Bike objmodel            
            Bike yamaha = new Bike("Yamaha",2,2,"Activa 5G");            
            Console.WriteLine(yamaha.brand);
            Console.WriteLine(yamaha.Model);
            Console.WriteLine(yamaha.getBikeCount());

            Bike fuji = new Bike("Fuji Bike", 2, 2, "Jari 1.5");
            Console.WriteLine(fuji.brand);
            fuji.Model = "Jari 1.5";
            Console.WriteLine(fuji.Model);
            Console.WriteLine(fuji.getBikeCount() + "\n");
            
            useFulTools.greetings();

            Console.ReadKey();
        }
    }
}
