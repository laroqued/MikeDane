using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class ProgramOM
    {
        static void Main(string[] args)
        {
            //Instantiate class, create new object
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonor ());
            Console.WriteLine(student2.HasHonor());

            Console.ReadLine();
        }
    }
}
