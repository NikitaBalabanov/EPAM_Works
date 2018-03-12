using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Round C1 = new Round();
            C1.x = 10;
            C1.y = 10;
            C1.R = 5;

            Console.WriteLine(C1.GetLength());
            Console.WriteLine(C1.GetArea());
            int r = 0;
            M1(C1, r);
            if (C1.R == r)
            {
                //; logic
            }
            Console.ReadKey();
        }

        private static void M1(Round r, int radius)
        {
            r.R = radius;
        }
    }
}
