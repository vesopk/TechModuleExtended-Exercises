using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point firstPoint = new Point() {X = firstNumbers[0], Y = firstNumbers[1]};
            Point secondPoint = new Point() {X = secondNumbers[0], Y = secondNumbers[1]};
            var result = CalculateDistance(firstPoint,secondPoint);
            Console.WriteLine("{0:F3}",result);
        }

        public static double CalculateDistance(Point firstPoint,Point secondPoint)
        {
            var a = Math.Abs(firstPoint.X - secondPoint.X);
            var b = Math.Abs(firstPoint.Y - secondPoint.Y);
            var c = Math.Pow(a, 2) + Math.Pow(b, 2);
            var distance = Math.Sqrt(c);
            return distance;
        }
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}