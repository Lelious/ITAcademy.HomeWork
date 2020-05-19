using System;
using System.Collections.Generic;

namespace HomeWork_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int side;
            
            for (int i = 1; i < 11; i++)
            {
                side = i;
                var collection = new List<Figure>() { new Circle(side), new Square(side), new Triangle(side) };

                foreach (var item in collection)
                {
                    Console.WriteLine($"This is [{item.Name}]. " +
                                      $"CLR Type is [{item.GetType()}]. " +
                                      $"Square is [{item.CalculateArea()}]");
                }

                Console.WriteLine("-----------------------------------------------------------------------------");
            }
        }
    }
}
