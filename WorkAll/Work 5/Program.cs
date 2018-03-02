using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_5
{
    class Program
    {
        static void Pyramid(int N, int N1)
        {
            for (int i = 0; i < N; i++)
            {
                string result = new string(' ', N1 - 1);
                Console.Write(result);
                N1--;
                string result1 = new string('*', i * 2 + 1);
                Console.Write(result1);

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i<=N; i++)
            {
                Pyramid(i, N);
            }
            

            Console.ReadKey();
        }
    }
}
