// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным, например:
// 6 --> да
// 7 --> да
// 1 --> нет

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Vihod(int den)
            {
                if ((den == 6) || (den == 7))
                {
                    Console.WriteLine(den + " --> Выходной :) ");
                }
                else if ((den > 0) & (den < 6))
                {
                    Console.WriteLine(den + " --> Не выходной :( ");
                }
                else
                {
                    Console.WriteLine(" --> Нет такого дня ");
                }
            }
            Console.WriteLine("Введите номер дня недели ");
            int number = Convert.ToInt32(Console.ReadLine());
            Vihod(number);
        }
    }
}
