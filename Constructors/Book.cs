using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Book
    {
        //class is a specification
       
            //define class attributes
            public string title;
            public string author;
            public int pages;


        //Make a constructor
        //Make a method with name of the class
        //You can create a book with no parameters.
        public Book()
        {

        }

        //You can use the parameters to add the attributes
        public Book(string aTitle, string aAuthor, int aPages)
        {
            //name is passed in
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
        

        }
    }
