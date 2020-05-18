using System;
using System.Text;

namespace Task_03
{
    class Task_03
    {
        static StringBuilder sb = new StringBuilder();
        static char ch;
        static void Main(string[] args)
        {
            sb.Append("1a!2.3!!..4.!.? 6 7!.. ?");
            Console.WriteLine(Convert.ToString(sb));
            Console.WriteLine("Введите символ . или ! которые необходимо удалить до первого знака ? в строке");
            ch = Convert.ToChar(Console.ReadLine());
            DeletePunctuationMarks();
        }
        static void DeletePunctuationMarks()
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i].Equals('?'))
                {
                    for (int j = i+1; j < sb.Length; j++)
                    {
                        sb.Replace(' ', '_');
                    }
                    Console.WriteLine("Отредактированная строка: " + Convert.ToString(sb));
                    return;
                }
                else
                {
                    if (sb[i].Equals(ch))
                    {
                        sb.Remove(i,1);
                        i--;
                    }                   
                }
            }
        }
    }
}
