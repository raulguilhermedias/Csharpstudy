using System;
using System.Globalization;

namespace Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 1056.25m;
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
            // Console.WriteLine(valor.ToString(
            //     "C",
            //     CultureInfo.CreateSpecificCulture("en-US")));
        }
    }
}
