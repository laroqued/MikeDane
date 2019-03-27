using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ProgramInheritance
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakesSpecialDish();
            Console.WriteLine();
            ItalianChef italianchef = new ItalianChef();
            italianchef.MakePasta();
            italianchef.MakesSpecialDish();


            Console.ReadLine();
        }
    }
}
