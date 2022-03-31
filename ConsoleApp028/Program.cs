// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Kub(int num_n)
            {
                int[] kubik = new int[num_n];
                for (int i = 0; i < num_n; i++)
                {
                    kubik[i] = (i + 1);
                    Console.Write(Math.Pow(kubik[i], 3) + ", ");
                }
            }
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Kub(n);
            Console.WriteLine("");
        }
    }
}