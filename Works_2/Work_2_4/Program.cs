using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2_4
{
    class Program
    {
        public static Random Rnd = new Random();
        static int[,] FillingArray(int x, int y)
        {
            int[,] RandArr = new int[x, y];

            for (int i = 0; i < RandArr.GetLength(0); i++)
            {
                for (int j = 0; j < RandArr.GetLength(1); j++)
                {
                    RandArr[i, j] = Rnd.Next(-10, 10);
                }
            }

            return RandArr;
        }

        static int Sum(int[,] Arr)
        {
            int sum = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    if ((i+j) % 2 == 0)
                    {
                        sum += Arr[i,j];
                    }
                }
            }

            return sum;
        }

        static void DisplayArr(int[,] InArr)
        {

            for (int i = 0; i < InArr.GetLength(0); i++)
            {
                for (int j = 0; j < InArr.GetLength(1); j++)
                {
                    Console.Write($" {InArr[i, j]}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int x = 10, y = 10; ;
            int[,] RandomArrey = FillingArray(x,y);

            int sum = Sum(RandomArrey);

            Console.WriteLine($"Sum positivs elements = {sum}");

            DisplayArr(RandomArrey);
            Console.ReadKey();
        }
    }
}
