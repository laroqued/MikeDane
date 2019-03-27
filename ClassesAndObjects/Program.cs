using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.numPages = 400;

            Console.WriteLine(book1.title);

            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "JRR Tolkien";
            book2.numPages = 300;

            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
