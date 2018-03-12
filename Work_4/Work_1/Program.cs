using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            Console.WriteLine(per1.name);
            Console.WriteLine(per1.fam);
            Console.WriteLine(per1.otch);
            Console.WriteLine(per1.date);
            per1.name = "";
            Console.ReadKey();

    }
}
}
