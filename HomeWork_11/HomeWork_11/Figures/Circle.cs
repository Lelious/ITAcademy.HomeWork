using System;

namespace HomeWork_11
{
    public class Circle : Figure
    {
        
        public Circle(int value)
        {
            Name = "Circle";
            Side = value;
        }
        public override double CalculateArea()
        {
            Area = Math.PI * (Side * Side);
            return Area;
        }
    }
}
