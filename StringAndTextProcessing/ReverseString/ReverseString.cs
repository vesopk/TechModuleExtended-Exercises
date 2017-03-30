using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = input.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", result));

        }
    }
}
