using System;
using System.Collections.Generic;
using System.Text;

namespace lect_11
{
    public class Triangle : Figure
    {
        public int height;
        public Triangle(int value, int value2)
        {
            height = value;
            side = value2;
        }
        public override void CalculateArea()
        {
            area = side * height / 2;
            Console.WriteLine($"Area of Triangle = {area}");
        }
    }
}
