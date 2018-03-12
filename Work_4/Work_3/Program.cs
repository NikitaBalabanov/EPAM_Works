using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(4,5,6);
            Console.WriteLine(R1.GetLength());
            Console.WriteLine(R1.GetArea());
            Console.ReadKey();
        }
    }
}
