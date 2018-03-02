using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write adge of the rectangle ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("One or two your adge is null or low then null");
            }
            else
            {
                Console.WriteLine($"Area of the rectangle = {a * b}");

            }
            Console.ReadKey();
        }
    }
}
