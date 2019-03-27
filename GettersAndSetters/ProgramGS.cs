using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class ProgramGS
    {
        static void Main(string[] args)
        {
            //If you want to make PG-13 with certain condition use Properties (getters and setters).

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            //These are the only rating we want to use: G, PG, PG-13, R, NR 
            //(getters and setters enforce these rules)
            //Using (.Rating) from the getter and setter method Rating()

            Console.WriteLine(avengers.Rating);
            Console.ReadLine();

        }
    }
}
