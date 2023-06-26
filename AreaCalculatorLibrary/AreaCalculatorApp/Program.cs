using AreaCalculatorLibrary;
using System;

namespace AreaCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the ShapeAreaCalculator library
            double circleRadius = 5.0;
            double triangleSide1 = 3.0;
            double triangleSide2 = 4.0;
            double triangleSide3 = 5.0;

            double circleArea = ShapeAreaCalculator.CalculateCircleArea(circleRadius);
            Console.WriteLine($"Circle area: {circleArea}");

            double triangleArea = ShapeAreaCalculator.CalculateTriangleArea(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Triangle area: {triangleArea}");

            bool isValidTriangle = ShapeAreaCalculator.IsValidTriangle(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Is valid triangle: {isValidTriangle}");

            bool isRightTriangle = ShapeAreaCalculator.IsRightTriangle(triangleSide1, triangleSide2, triangleSide3);
            Console.WriteLine($"Is right triangle: {isRightTriangle}");
        }
    }
}
