using System;
using System.Collections.Generic;
using System.Linq;

namespace Boxes
{
    class Boxes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var boxes = new List<Box>();

            while (inputLine!="end")
            {
                var inputLineParams = inputLine.Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries).ToList();

                var firstPoint = Point.Parse(inputLineParams[0]);
                var secondPoint = Point.Parse(inputLineParams[1]);
                var thirdPoint = Point.Parse(inputLineParams[2]);
                var fourthPoint = Point.Parse(inputLineParams[3]);

                var currentBox = Box.Parse(firstPoint, secondPoint, thirdPoint, fourthPoint);
                boxes.Add(currentBox);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var perimter = Box.CalculatePerimeter(box.Width, box.Height);
                var area = Box.CalculateArea(box.Width, box.Height);

                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {perimter}");
                Console.WriteLine($"Area: {area}");
            }
        }
    }
}

class Box
{
    public Point UpperLeft { get; set; }
    public Point UpperRight { get; set; }
    public Point BottomLeft { get; set; }
    public Point BottomRight { get; set; }

    public int Width => Point.CalculateDistance(UpperLeft, UpperRight);
    public int Height => Point.CalculateDistance(UpperLeft, BottomLeft);

    public static int CalculatePerimeter(int width,int height)
    {
        var perimeter = (2 * width) + (2 * height);
        return perimeter;
    }

    public static int CalculateArea(int width, int height)
    {
        var area = width * height;
        return area;
    }

    public static Box Parse(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
    {
        return new Box()
        {
            UpperLeft = upperLeft,
            UpperRight = upperRight,
            BottomLeft = bottomLeft,
            BottomRight = bottomRight
        };
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static int CalculateDistance(Point firstPoint, Point secondPoint)
    {
        var a = Math.Abs(firstPoint.X - secondPoint.X);
        var b = Math.Abs(firstPoint.Y - secondPoint.Y);
        var c = Math.Pow(a, 2) + Math.Pow(b, 2);
        var distance = (int)Math.Sqrt(c);
        return distance;
    }

    public static Point Parse(string inputLine)
    {
        var inputLineParams = inputLine.Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries).ToList();

        return new Point()
        {
            X = int.Parse(inputLineParams[0]),
            Y = int.Parse(inputLineParams[1])
        };
    }
}