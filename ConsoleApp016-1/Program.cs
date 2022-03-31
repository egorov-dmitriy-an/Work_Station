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
            void Coup(string cur_symbol)
            {
                Console.WriteLine(cur_symbol + " --> " + cur_symbol[2] + cur_symbol[1] + cur_symbol[0]);
            }

            Console.WriteLine("Введите количество трехзначных чисел для переворота:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] turn = new int[length];
            int index = 0;

            while (index < length)
            {
                turn[index] = new Random().Next(100, 1000);
                Coup(Convert.ToString(turn[index]));
                index++;
            }
        }
    }
}