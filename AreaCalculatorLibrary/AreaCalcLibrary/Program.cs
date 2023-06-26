using System;

namespace AreaCalculatorLibrary
{
    public class ShapeAreaCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            if (!IsValidTriangle(side1, side2, side3))
                throw new ArgumentException("Invalid triangle sides!");

            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        public static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double a = side1 * side1;
            double b = side2 * side2;
            double c = side3 * side3;

            return a + b == c || a + c == b || b + c == a;
        }
    }

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
