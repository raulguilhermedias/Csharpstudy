using System;
using System.Globalization;

namespace Datetime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpawnNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpawnNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);
            
            // var dateTime = DateTime.UtcNow;


            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            //     Console.WriteLine("-----------------");
            // }
            // Console.WriteLine(dateTime);

            // Console.WriteLine(dateTime.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Alberta/Toronto");
            // Console.WriteLine(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
            // Console.WriteLine(horaAustralia);
            // var pt = new CultureInfo("pt-BR");
            // var atual = CultureInfo.CurrentCulture;

            // Console.WriteLine(DateTime.Now.ToString("D", pt));
            // var data = DateTime.Now;
            // if (data.Date == DateTime.Now.Date)
            // {
            //     Console.WriteLine("É igual");
            // }

            // Console.WriteLine(data);
            // var data = DateTime.Now;
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.DayOfWeek);
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            // Console.WriteLine(data.AddDays(12));
            // Console.WriteLine(data.AddMonths(1));
            // Console.WriteLine(data.AddYears(1));
        }
    }
}
