using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorFuction
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(String title, String author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

    }
}
