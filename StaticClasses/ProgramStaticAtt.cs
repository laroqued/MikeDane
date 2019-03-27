using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAttributes
{
    class ProgramStatic
    {
        //Static attributes is about the class.
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Led Zeppelin", 200);
            Console.WriteLine(Song.songCount);//First static attribute
            Song Kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            //static attribute belong to the class
            Console.WriteLine(Kashmir.getSongCount());//Second static attribute using the getSongCount() method.


            Console.ReadLine();
        }
    }
}

