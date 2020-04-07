using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            char gamer = '*';
            string graphicPosition = " "; 
            byte[] position = new byte[] {30, 10};
            Console.ForegroundColor = ConsoleColor.Green;

            label:

            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine();
                if (i == position[1])
                {
                    for (int k = 0; k <= position[0]; k++)
                    {
                        graphicPosition += " ";
                        if (k == position[0])
                        {
                            Console.Write(graphicPosition);
                            Console.WriteLine(gamer);
                            graphicPosition = " ";
                        }
                    }
                    
                }
            }

            Console.WriteLine("Введите символ, чтобы переместить фигуру '*'");

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.W && position[1] > 0)
                {
                    position[1] -= 1;
                    Console.Clear();
                    goto label;
                }               
                if (key.Key == ConsoleKey.S && position[1] < 20)
                {
                    position[1] += 1;
                    Console.Clear();
                    goto label;
                }
                if (key.Key == ConsoleKey.A && position[0] > 0)
                {
                    position[0] -= 1;
                    Console.Clear();
                    goto label;
                }
                if (key.Key == ConsoleKey.D && position[0] < 40)
                {
                    position[0] += 1;
                    Console.Clear();
                    goto label;
                }
                else
                {
                    Console.WriteLine("Перемещение не требуется, либо вы пытаетесь выйти за пределы поля!");
                }
            }
            while (key.Key != ConsoleKey.Escape); 
        }       
    }
}
