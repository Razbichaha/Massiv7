using System;

namespace Massiv7
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringText = "Дана строка с текстом, используя метод строки String.Split() " +
                         "получить массив слов, которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.";

            string[] stringArray = stringText.Split(' ');

            foreach(string str in stringArray)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
