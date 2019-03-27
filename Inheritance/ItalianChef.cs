using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef: Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
        public override void MakesSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }

    }
}
