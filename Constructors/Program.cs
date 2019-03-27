using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
           //new Book() is connect to the constructor pulic Book()
           //three fields are passed into the parameters
            Book myBook = new Book("Harry Potter","Rowling",400);
            //You can print out one of the fields/arguments
            Console.WriteLine(myBook.author);
        

            Book myBook2 = new Book("Lord of the Rings", "Tolkein",700);
            //you can overwrite the field
            myBook2.author = "Donnyves Laroque";
            Console.WriteLine(myBook2.author);

            //My new obect with no parameters
            Book myBook3 = new Book();
            myBook3.author = "Stephen King";
            Console.WriteLine(myBook3.author);


            Console.ReadLine();
        }
    }
}
