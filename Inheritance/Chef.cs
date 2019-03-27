using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Cheg makes salad");
        }
        public virtual void MakesSpecialDish()
        {
            Console.WriteLine("The Chef make bbq ribs");
        }
    }
}
