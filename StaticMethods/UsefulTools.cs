using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    static class UsefulTools
    {

        //You cannot make an instance of SayHi if the class UsefulTools is declared static
        //UsefulTools tools = new UsefulTools();// this allows this the static is removed

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
