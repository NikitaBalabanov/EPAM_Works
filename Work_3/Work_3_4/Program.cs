using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Work_3_4
{
    class Program
    {
        static void Time(int N)
        {
            Stopwatch stopWatch = new Stopwatch();
            string str = string.Empty;
            //string str = new string();
            var sb = new StringBuilder();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.Write("RunTime " + stopWatch.Elapsed.TotalMilliseconds + " ");
            stopWatch.Reset();
            //Console.WriteLine();
            stopWatch.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatch.Stop();
            Console.Write("RunTime-bilder " + stopWatch.Elapsed.TotalMilliseconds + " ");
            Console.Write("for " + N + " ");
            Console.WriteLine();
            stopWatch.Reset();
        }
        static void Main(string[] args)
        {
            Time(1);
            Time(1);
            Time(2);
            Time(3);
            Time(5);
            Time(10);
            Time(50);
            Time(100);
            Time(1000);
            Time(10000);
            //Time(100000);
            Console.ReadKey();
        }
    }
}
