using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2_3
{
    class Program
    {

        public static Random Rnd = new Random();
        static int[] FillingArray(int Long)
        {
            int[] RandArr = new int[Long];

            for (int i = 0; i < RandArr.Length; i++)
            {
                RandArr[i] = Rnd.Next(-10, 10);
            }

            return RandArr;
        }

        static int Sum(int[] Arr)
        {
            int sum = 0;
            for (int i =0; i < Arr.Length; i++)
            {
                if (Arr[i]>=0)
                {
                    sum += Arr[i];
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int Len = 20;
            int[] RandomArrey = FillingArray(Len);

            int sum = Sum(RandomArrey);
            
            Console.WriteLine($"Sum positivs elements = {sum}");

            string result = string.Join(", ", RandomArrey);
            Console.WriteLine(result + ";");
            Console.ReadKey();

        }
    }
}
