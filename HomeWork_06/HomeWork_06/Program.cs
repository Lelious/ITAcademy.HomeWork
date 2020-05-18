using System;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string magicNumber = "          ";
            int[] randomArray = new int[10];
            int[] consoleArray = new int[10];
            int[] sumArray = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(0, 100);
            }
            for (int k = 0; k < consoleArray.Length; k++)
            {
                Console.WriteLine($"Введите {k+1} число");
                input = Console.ReadLine();
                if (int.TryParse(input, out consoleArray[k]))
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine("Вы ввели не число! Попробуйте ещё раз!");
                    --k;
                }               
            }
            for (int j = 0; j < sumArray.Length; j++)
            {
                sumArray[j] = randomArray[j] + consoleArray[j];
            }

            Console.Clear();

            for (int h = 0; h < sumArray.Length; h++)
            {                
                 Console.WriteLine($"{randomArray[h]}{magicNumber}{consoleArray[h]}{magicNumber}{sumArray[h]}");               
            }           
        }
    }
}
