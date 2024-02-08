using System;

namespace Datetime
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var data = DateTime.Now;
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.DayOfWeek);
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            Console.Clear();

            var data = DateTime.Now;
            
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));
        }
    }
}
