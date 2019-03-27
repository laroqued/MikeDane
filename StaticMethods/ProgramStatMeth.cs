using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class ProgramStatMeth
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.Sqrt(144));

            //You do not have to make an instance of th UsefulTool because it's static
            //UsefulTools can be called directly
            UsefulTools.SayHi("Donnyves");

            Console.ReadLine();
        }
    }
}
//Math is a static class.  You do not have to 
//create instance of the class or create an object.

//You can not create an instance of a static class

