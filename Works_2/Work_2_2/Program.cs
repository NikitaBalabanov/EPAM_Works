using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2_2
{
    class Program
    {

        public static Random Rnd = new Random();
        static int[,,] FillingArray(int X, int Y, int Z)
        {
            int[,,] RandArr = new int[X ,Y, Z];

            for (int i = 0; i < RandArr.GetLength(0); i++)
            {
                for (int j =0; j < RandArr.GetLength(1); j++)
                {
                    for (int l = 0; l < RandArr.GetLength(2); l++)
                    {
                        RandArr[i, j,l] = Rnd.Next(-100, 100);
                    }
                }
                
            }

            return RandArr;
        }

        static void DisplayArr(int[,,] InArr)
        {
            
            for (int i = 0; i < InArr.GetLength(0); i++)
            {
                for (int j = 0; j < InArr.GetLength(1); j++)
                {
                    for (int l = 0; l < InArr.GetLength(2); l++)
                    {
                        Console.Write($" {InArr[i, j,l]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine();
            }
        }

        static int[,,] ProcassingArr(int[,,] InArr)
        {
            for (int i = 0; i < InArr.GetLength(0); i++)
            {
                for (int j = 0; j < InArr.GetLength(1); j++)
                {
                    for (int l = 0; l < InArr.GetLength(2); l++)
                    {
                        if (InArr[i, j, l]>0)
                        {
                            InArr[i, j, l] = 0;
                        }
                    }
                }
            }
            return InArr;
        }

        static void Main(string[] args)
        {
            int x = 4, y = 4, z= 4;
            int[,,] RandArr = FillingArray(x,y,z);

            Console.WriteLine("Array 1");
            Console.WriteLine();

            DisplayArr(RandArr);

            Console.WriteLine("Array 2");
            Console.WriteLine();

            RandArr =ProcassingArr(RandArr);

            DisplayArr(RandArr);

            Console.ReadKey();
        }
    }
}
