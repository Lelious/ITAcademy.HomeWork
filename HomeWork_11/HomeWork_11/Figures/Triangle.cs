using System;

namespace HomeWork_11
{
    public class Triangle : Figure
    {
        public Triangle(int value)
        {
            Name = "Triangle";
            Side = value;
        }
        public override double CalculateArea()
        {
            Area = ((Math.Cbrt(3)/4)*(Side*Side));
            return Area;
        }
    }
}
