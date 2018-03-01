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
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());
            int j = 0; 
            for (int i = 0; i<N; i++)
            {
                string result = new string('*', i+1);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
