using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var pointsList = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Point currentPoint = new Point() {X = numbers[0], Y = numbers[1]};
                pointsList.Add(currentPoint);
            }
            var minimumDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;
            for (int first = 0; first < pointsList.Count; first++)
            {
                for (int second = first+1; second < pointsList.Count; second++)
                {
                    var firstpoint = pointsList[first];
                    var secondpoint = pointsList[second];
                    var distance = CalculateDistance(firstpoint, secondpoint);
                    if (distance<minimumDistance)
                    {
                        minimumDistance = distance;
                        firstPointResult = firstpoint;
                        secondPointResult = secondpoint;
                    }
                }
            }
            Console.WriteLine($"{minimumDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());

        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
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

    public string Print()
    {
        return $"({X}, {Y})";
    }
}