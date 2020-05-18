using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 26; i++)
            {
                Console.Write($"{Convert.ToChar(90-i)};");
            }
        }
    }
}
