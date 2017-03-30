using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        public static void Main()
        {
            var inputLIne = Console.ReadLine();
            var format = "d-M-yyyy";
            var date = DateTime.ParseExact(inputLIne,format,CultureInfo.InvariantCulture);
            var day = date.DayOfWeek;
            Console.WriteLine(day);
        }
    }
}
