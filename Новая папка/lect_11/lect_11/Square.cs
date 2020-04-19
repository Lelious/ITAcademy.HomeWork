using System;
using System.Collections.Generic;
using System.Text;

namespace lect_11
{
    class Square : Figure
    {
        public Square(int value)
        {
            side = value;
        }
        public override void CalculateArea()
        {
            area = side * side;
            Console.WriteLine($"Area of Square = {area}");
        }
    }
}
