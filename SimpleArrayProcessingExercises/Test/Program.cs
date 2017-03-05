using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[] {"yo","ma","nigga" };
            Console.WriteLine(string.Join(" ",test));
            var test1 = test.Reverse();
            Console.WriteLine(string.Join(test1[0]));
        }
    }
}
