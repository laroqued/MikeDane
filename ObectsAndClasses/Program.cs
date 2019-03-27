using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object (instance of a class)
            //Book is the data type
            //.title is an attribute of the Book(object)
            Book myBook = new Book();
            myBook.title = "Harry Potter";
            myBook.author = "JK Rowling";
            myBook.pages = 440;

            //you can print out the attibute of the book
            Console.WriteLine(myBook.title);

            Book myBook2 = new Book();
            myBook2.title = "Lord of the Rings";
            myBook2.author = "Tolkein";
            myBook2.pages = 700;

            Console.WriteLine(myBook2.author);

            Console.ReadLine();
        }

    }
}
