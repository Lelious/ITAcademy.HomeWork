using System;
using System.Text;

namespace Task_01
{
    class Task_01
    {
        static bool fixAll;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            Console.WriteLine(@"Введите стихотворение в одну строку, разделяя его знаком ;");

            var enteredString = Console.ReadLine();
            sb.Append(enteredString);

            Console.WriteLine("Если вы хотите заменить все буквы О на букву А - введите 1, если только заглавные - 0");

            fixAll = Convert.ToBoolean(Convert.ToByte(Console.ReadLine()));
            sb.Replace(';', '\n');
            Replace_A_to_O_Method();
        }
        static void Replace_A_to_O_Method()
        {
            if (fixAll == false)
            {
                sb.Replace('О', 'А');
                Console.WriteLine(sb);
            }
            else
            {
                sb.Replace('O', 'A');
                sb.Replace('o', 'a');
                Console.WriteLine(sb);
            }
        }
    }
}
