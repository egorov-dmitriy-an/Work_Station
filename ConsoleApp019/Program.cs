// Задача 1. Написать программу, которая определяет,
// является ли треугольник со сторонами a, b, c равнобедренным.
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Triangle(int len_a, int len_b, int len_c)
            {
                if ((len_a == len_b) & (len_a == len_c))
                    Console.WriteLine(" Треугольник равнобедренный и равносторонний");
                else if ((len_a == len_c) || (len_a == len_b) || (len_c == len_b))
                    Console.WriteLine(" Треугольник равнобедренный ");
                else Console.WriteLine(" Треугольник неравнобедренный ");
            }

            Console.WriteLine("Введите длину первой стороны ");
            int storona_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны ");
            int storona_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны ");
            int storona_c = Convert.ToInt32(Console.ReadLine());

            Triangle(storona_a, storona_b, storona_c);
        }
    }
}