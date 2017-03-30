using System;
using System.Linq;

namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main()
        {
            var firstPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondPoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstRectangle = new Rectangle() { Left = firstPoints[0],Top = firstPoints[1],Width = firstPoints[2], Height = firstPoints[3]};
            var secondRectangle = new Rectangle() { Left = secondPoints[0],Top = secondPoints[1],Width = secondPoints[2], Height = secondPoints[3]};
            var result = IsInside(firstRectangle,secondRectangle);
            Console.WriteLine(result ? "Inside" : "Not Inside");
        }

        private static bool IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            var coditionOne = firstRectangle.Left >= secondRectangle.Left;
            var conditionTwo = firstRectangle.Top <= secondRectangle.Top;
            var conditionThree = firstRectangle.Right <= secondRectangle.Right;
            var conditionFour = firstRectangle.Bottom <= secondRectangle.Bottom;
            return coditionOne && conditionTwo && conditionThree && conditionFour;
        }
    }
}

class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Bottom
    {
        get { return Top + Height; }
    }

    public int Right
    {
        get { return Left + Width; }
    }
}
