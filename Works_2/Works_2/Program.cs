
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Works_2
{
    class Program
    {
        public static Random Rnd = new Random();
        static int[] FillingArray(int Long)
        {
            int[] RandArr = new int[Long];

            for (int i = 0; i<RandArr.Length; i++)
            {
                RandArr[i] = Rnd.Next(0, 100);
            }

            return RandArr;
        }

        static int MaxEl(int[] Arr)
        {
            return Arr.Max();
        }

        static int MinEl(int[] Arr)
        {
            return Arr.Min();
        }


        static void Main(string[] args)
        {
            int Len = 20;
            int[] RandomArrey = FillingArray(Len);
            Console.WriteLine($"x = {MaxEl(RandomArrey)}");
            Console.WriteLine($"Min = { MinEl(RandomArrey)}");

            Array.Sort(RandomArrey);
            string result = string.Join(", ", RandomArrey);
            Console.WriteLine(result + ";");
            Console.ReadKey();

        }
    }
}
