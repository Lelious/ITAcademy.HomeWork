using System;
using System.Collections.Generic;
using System.Text;

namespace lect_11
{
    class Circle : Figure
    {
        public int radius { get; set; }
        public double squareleCircle { get; set; }
        public override void CalculateArea()
        {
            squareleCircle = 3.14 * (radius*radius);
            Console.WriteLine($"Area of Circle = {squareleCircle}");
        }
    }
}
