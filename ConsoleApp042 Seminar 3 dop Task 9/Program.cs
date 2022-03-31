// Задача 9. Напишите программу, который выводит на консоль таблицу умножения от 1 до n,
// где n задаётся случайно от 2 до 100.


using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 9 Доп ================");
            int n = new Random().Next(2, 101);
            Console.WriteLine($"Число n = {n}");
            Console.WriteLine("-------------");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++) Console.WriteLine($"{i} x {j} = {i * j}");
                Console.WriteLine("-------------");
            }
            Console.WriteLine("========================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}