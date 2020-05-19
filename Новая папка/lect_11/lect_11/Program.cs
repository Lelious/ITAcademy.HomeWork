using System;
using System.Collections.Generic;

namespace lect_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<Figure>() {new Circle(7), new Square(10), new Triangle(5, 8)};

            foreach (var item in collection)
            {
                item.CalculateArea();                     
            }
        }
    }
}
