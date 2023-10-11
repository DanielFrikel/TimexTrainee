using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400 );
            Console.WriteLine(book1.title);

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);
            book2.title = "The Hobbit";
            Console.WriteLine(book2.title);

            Book book3 = new Book();
            Console.WriteLine();

            //======================================================================

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadKey();
        }
    }
}
