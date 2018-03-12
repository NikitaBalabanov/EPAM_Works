using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.Trim();

            for (int i = 0; i<str.Length; i++)
            {
                if (char.IsPunctuation(str[i]))
                {
                    str = str.Remove(i,1);
                }
            }

            int WordCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsSeparator(str[i]))
                {
                    WordCount++;
                    str = str.Remove(i, 1);
                }
            }
            if (WordCount==0)
            {
                WordCount++;
            }
            Console.WriteLine($"Middle length of word in string is {str.Length/WordCount}");
            Console.ReadKey();
        }
    }
}
