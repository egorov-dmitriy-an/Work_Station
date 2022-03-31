// Задача 10. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе выводит перевёрнутое число, например:
// 456 -- > 654
// 782 -- > 287
// 918 -- > 819

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Reverse(int current_number)
            {
                int temp = current_number % 10 * 100 + current_number / 10 % 10 * 10 + current_number / 100;
                Console.WriteLine(current_number + " --> " + temp);
            }
            Console.WriteLine("Введите количество трехзначных чисел для переворота:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Random num = new Random();
            for (int i = 1; i <= quantity; i++)
            {
                int number = num.Next(100, 1000);
                Reverse(number);
            }
        }
    }
}