using System;


namespace OOPLesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка шифровки и дешифровки по методу А");
            Console.WriteLine("Введите текст на русском языке без пробелов, запятых и других спец символов:");
            string text = Console.ReadLine();
            ACode aCode = new ACode();
            string resultACode = aCode.Encode(text);
            Console.WriteLine(resultACode);
            Console.WriteLine("Декодировка текста обратно методом А:");
            Console.WriteLine(aCode.Decode(resultACode));

            Console.WriteLine($"\nПроверка шифровки и дешифровки по методу Б.\n Шифровка строк {text}");
            BCode bCode = new BCode();
            string resultBCode = bCode.Encode(text);
            Console.WriteLine(resultBCode);
            Console.WriteLine("Декодировка текста обратно методом Б:");
            Console.WriteLine(bCode.Decode(resultBCode));
            Console.ReadLine();
        }
    }
}
