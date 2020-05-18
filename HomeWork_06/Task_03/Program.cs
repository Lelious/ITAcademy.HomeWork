using System;
using System.Diagnostics;
using System.Linq;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {            
            Stopwatch timeOfMethod = new Stopwatch();
            int buffer;
            string consoleNumber;
            Random rnd = new Random();

            Console.Write("Введите размер массива: ");
            consoleNumber = Console.ReadLine();

            int.TryParse(consoleNumber, out int arrayLength);
            int[] taskArray = new int[arrayLength];

            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = rnd.Next(0, 100);
            }
            Console.Clear();
            timeOfMethod.Start();

            for (int k = 0; k < taskArray.Length/2; k++)
            {
                buffer = taskArray[k];
                taskArray[k] = taskArray[taskArray.Length - k - 1];
                taskArray[taskArray.Length - k - 1] = buffer;
            }
            timeOfMethod.Stop();
            TimeSpan ts = timeOfMethod.Elapsed;

            for (int j = 0; j < taskArray.Length; j++)
            {
                Console.WriteLine(taskArray[j]);
            }

            Console.WriteLine("RunTime " + ts + "My method");            
            timeOfMethod.Reset();
            timeOfMethod.Start();
            taskArray.Reverse();
            timeOfMethod.Stop();
            ts = timeOfMethod.Elapsed;
            Console.WriteLine("RunTime " + ts + "Microsoft method");
        }
        
    }
}
