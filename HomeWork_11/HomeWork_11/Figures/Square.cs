using System;

namespace HomeWork_11
{
    class Square : Figure
    {
        public Square(int value)
        {
            Name = "Square";
            Side = value;
        }
        public override double CalculateArea()
        {
            Area = Side * Side;
            return Area;
        }
    }
}
