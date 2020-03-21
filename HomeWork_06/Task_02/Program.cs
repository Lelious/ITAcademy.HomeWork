using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string positionOfLaskNumber;
            string enteredArrayNum;
            string consoleNumber;

            Console.Write("Введите размер массива: ");
            consoleNumber = Console.ReadLine();

            int.TryParse(consoleNumber, out int arrayLength);
            int[] taskArray = new int[arrayLength];

            for (int i = 0; i < taskArray.Length - 1; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                enteredArrayNum = Console.ReadLine();
                int.TryParse(enteredArrayNum, out taskArray[i]);
               
            }
            Console.WriteLine("Введённый массив:");

            for (int k = 0; k < taskArray.Length - 1; k++)
            {
                Console.WriteLine($"{taskArray[k]}");               
            }

            Console.Write("Введите последнее число для массива: ");
            enteredArrayNum = Console.ReadLine();
            int.TryParse(enteredArrayNum, out taskArray[taskArray.Length - 1]);

            Console.Write("Введите место в массиве, куда необходимо переместить последнее введённое число: ");
            positionOfLaskNumber = Console.ReadLine();
            int.TryParse(positionOfLaskNumber, out int num);

            for (int j = taskArray.Length - 1; j != num-1; j--)
            {
                int numberOfArray = taskArray[j];
                taskArray[j] = taskArray[j - 1];
                taskArray[j - 1] = numberOfArray;
            }
            Console.WriteLine("Массив после перестановки: ");

            for (int i = 0; i < taskArray.Length; i++)
            {
                Console.WriteLine(taskArray[i]);                
            }
        }
    }
}
