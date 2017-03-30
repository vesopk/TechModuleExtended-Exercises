using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateInput = Console.ReadLine();
            int[] tokens = dateInput.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime date = new DateTime(tokens[2],tokens[1],tokens[0]);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
