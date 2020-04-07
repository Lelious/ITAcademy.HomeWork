using System;
using System.Text;
using System.Linq;

namespace Task_02
{    
    class Task_02
    {
        static string enteredString;
        static StringBuilder sb = new StringBuilder();
        static int maxLengthWord;
        static int minLengthWord;
        static int minIndex;
        static int maxIndex;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            enteredString = Console.ReadLine();
            string[] words = enteredString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < minLengthWord)
                {
                    minLengthWord = words[i].Length;
                    minIndex = i;
                }

                if (words[i].Length > maxLengthWord)
                {
                    maxLengthWord = words[i].Length;
                    maxIndex = i;
                }
            }

            Console.WriteLine("Введите: \n1 чтобы удалить самое длинное слово, \n" +
                              "2 чтобы поменять самое длинное и самое короткое слово местами\n" +
                              "3 чтобы подсчитать колличество знаков пунктуации: ");

            byte iterator = Convert.ToByte(Console.ReadLine());

            switch (iterator)
            {
                case 1:
                    DeleteMaxLengthWord(words);
                    break;
                case 2:
                    ReplaceMinWordAndMaxWord(words);
                    break;
                case 3:
                    CountOfPunctuationMarks(words);
                    break;
                default:
                    break;
            }
        }
        static string[] DeleteMaxLengthWord(string[] words)
        {
            Console.WriteLine("Удаляем самое длинное слово");
            words[maxIndex] =string.Empty;
            string buffer = string.Join(' ' , words);
            buffer.Trim();
            Console.WriteLine(buffer);
            return words;
        }
        static string[] ReplaceMinWordAndMaxWord(string[] words)
        {
            Console.WriteLine("Меняем местами самое длинное и самое короткое слово");
            string buffer = words[minIndex];
            words[minIndex] = words[maxIndex];
            words[maxIndex] = buffer;
            buffer = string.Join(' ', words);
            buffer.Trim();
            Console.WriteLine(buffer);
            return words;
        }
        static int CountOfPunctuationMarks(string[] words)
        {
            Console.Write("Колличество знаков пунктуации: ");
            string buffer = string.Concat(words);
            Console.WriteLine(buffer.Count(char.IsPunctuation));
            return 0;
        }
    }
}