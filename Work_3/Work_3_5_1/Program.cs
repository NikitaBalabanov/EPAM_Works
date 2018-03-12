using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
namespace Work_3_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string str = Console.ReadLine();
            string str = "< b > Это </ b > текст < i > с </ i > < font color =”red”> HTML </ font > кодами";
            //<[^<] *>

            //Match match = regex.Match(str);
            string pattern = "<[^<]*>";
            string input = Regex.Replace(str, pattern, "_");
            Console.WriteLine(input);
            Console.ReadKey();

        }
    }
}
