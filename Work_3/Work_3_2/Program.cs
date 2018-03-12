using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first string: ");
            string FirstStr = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Write second string: ");
            string SecondStr = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < SecondStr.Length; i++)
            {
                for (int j = 0; j < SecondStr.Length; j++)
                {
                    if (SecondStr[i]== SecondStr[j] && i!=j)
                    {
                        SecondStr = SecondStr.Remove(j,1);
                    }
                }
            }

            
            for (int i = 0; i < SecondStr.Length; i++)
            {
                for (int j = 0; j < FirstStr.Length; j++)
                {
                    if (SecondStr[i] == FirstStr[j])
                    {
                        FirstStr = FirstStr.Insert(j, SecondStr[i].ToString());
                        j++;
                    }

                }

            }

            Console.WriteLine(FirstStr);
            Console.ReadKey();
        }
    }
}
