using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Work_3_3
{
    class Program
    {
        public static void Culture (string cult)
        {
            CultureInfo current = CultureInfo.CurrentUICulture;
            //Console.WriteLine("The current UI culture is {0}", current.Name);
            CultureInfo newUICulture;
            if (current.Name.Equals(cult))
                newUICulture = new CultureInfo("hr-HR");
            else
                newUICulture = new CultureInfo(cult);

            CultureInfo.CurrentUICulture = newUICulture;
            Console.WriteLine("The current UI culture is now {0}",
                              CultureInfo.CurrentUICulture.Name);
            Console.WriteLine(newUICulture.NumberFormat.CurrencyDecimalDigits);
            Console.WriteLine(newUICulture.NumberFormat.CurrencyDecimalSeparator);
            Console.WriteLine(newUICulture.NumberFormat.CurrencyGroupSeparator);
            Console.WriteLine(newUICulture.NumberFormat.CurrencyGroupSizes);
            Console.WriteLine(newUICulture.NumberFormat.CurrencyNegativePattern);
            Console.WriteLine(newUICulture.NumberFormat.CurrencyPositivePattern);
            Console.WriteLine(newUICulture.NumberFormat.CurrencySymbol);
            Console.WriteLine(newUICulture.NumberFormat.DigitSubstitution);

        }
        static void Main(string[] args)
        {
            Culture("ru-RU");
            Culture("en-UK");
            Culture("fr-FR");
            Console.ReadKey();
        }
    }
}
