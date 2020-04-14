using System;

namespace lect_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.lowestTriangleSide = 5;
            triangle.height = 8;
            triangle.CalculateArea();

            Square square = new Square();
            square.squareSide = 10;
            square.CalculateArea();

            Circle circle = new Circle();
            circle.radius = 7;
            circle.CalculateArea();
        }
    }
}
