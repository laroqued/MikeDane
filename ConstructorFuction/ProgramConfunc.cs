using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorFuction
{
    class ProgramConfunc
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling",400);
        

            Console.WriteLine(book1.title);

            Book book2 = new Book("Lord of the Rings", "JRR Tolkien",300);
         

            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}
