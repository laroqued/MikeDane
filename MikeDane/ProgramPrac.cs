using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikeDane
{
    class ProgramPrac
    {
        public static int Bet(int num)
        {
            int row1 = 1;
            for (int i = 3; i < 37; i += 3)
            {
                Console.WriteLine(i);
            }
            return row1;
        }
        static void Main(string[] args)
        {
            Bet(39);
            Console.ReadLine();
        }
    }
}
