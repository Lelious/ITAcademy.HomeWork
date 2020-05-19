using System;

namespace lect_11
{
    public class Circle : Figure
    {
        public Circle(int value)
        {
            side = value;
        }
        public override void CalculateArea()
        {
            area = Math.PI * (side*side);
            Console.WriteLine($"Area of Circle = {area}");
        }
    }
}
