using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local date and time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            
            // UTC Time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);
            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");

            Console.WriteLine($"Hour: {dt.Hour}");
            Console.WriteLine($"Minute: {dt.Minute}");
            Console.WriteLine($"Second: {dt.Second}");
            Console.WriteLine($"Millisecond: {dt.Millisecond}");

            var tenDaysFromNow = dt.AddDays( 10 );
            Console.WriteLine(tenDaysFromNow);

            var tenDaysAndTwentyHoursFromNow = dt.AddHours(20).AddDays(10);
            Console.WriteLine( tenDaysAndTwentyHoursFromNow);

            // Formatting the output
            Console.WriteLine("----------------");
            Console.WriteLine($"Standard Output: {dt}");
            Console.WriteLine(dt.ToString("dd-MM-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM-dd-yyyy"));
            Console.WriteLine(dt.ToString("hh:mm:ss"));

            var myDt = new DateTime(2024, 10, 7, 12, 30,15);
            Console.WriteLine(myDt);
         Console.ReadKey();
        }
    }
}
