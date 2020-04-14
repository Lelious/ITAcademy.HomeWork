using System;
using System.Collections.Generic;
using System.Text;

namespace lect_11
{
    public class Triangle : Figure
    {

        public int lowestTriangleSide { get; set; }
        public int triangleArea { get; set; }

        public int height { get; set; }
        public override void CalculateArea()
        {
            triangleArea = height * lowestTriangleSide / 2;
            Console.WriteLine($"Area of Triangle = {triangleArea}");
        }
    }
}
