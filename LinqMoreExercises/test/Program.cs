using System;

namespace test
{
    class Program
    {
        static void Main()
        {
            DateTime startDateTime = new DateTime(2017,1,13);
            var now = DateTime.Now;
            var timeDif = now.Subtract(startDateTime);
            Console.WriteLine(timeDif.Days);
        }
    }
}
