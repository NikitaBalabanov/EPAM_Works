using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum all counts before 1000, multiple 3 or 5 ");
            int sum = 0;
            int sum1 = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 1000; i+=3)
            {
                sum += i;
                if ( i % 5 == 0)  
                {
                    sum1 += i;
                }
            }
            for (int i = 0; i < 1000; i += 5)
            {
                sum += i;
            }
            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            watch.Reset();
            sum -= sum1;

            watch.Start();
            var sum2 = 0;
            for (int i = 0; i < 1000; i ++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum2 += i;
                }
            }

            watch.Stop();
            Console.WriteLine(watch.Elapsed.TotalMilliseconds);
            Console.WriteLine($"Sum = {sum}");
            Console.ReadKey();
        }
    }
}
