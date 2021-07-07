using System;
using System.Collections.Generic;
using System.Text;

namespace lect_11
{
    class Square : Figure
    {
        public int squareSide { get; set; }
        public int squareleArea { get; set; }
        public override void CalculateArea()
        {
            squareleArea = squareSide * squareSide;
            Console.WriteLine($"Area of Square = {squareleArea}");
        }
    }
}
