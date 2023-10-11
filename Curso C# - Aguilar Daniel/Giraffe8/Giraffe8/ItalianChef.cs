using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe8
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italian Chef makes bbq ribs");
        }
        public void MakePasta() 
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
