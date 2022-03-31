// Задача 25: Напишите цикл, который принимает на вход два натуральных 
// числа (A и B) и возводит число A в степень B. Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 4 Задача 25 ================");
            int Stepen(int a_a, int b_b)
            {
                int step = 1;
                for (int i = 1; i <= b_b; i++) step = step * a_a;
                return step;
            }
            Console.Write("Введите число А = ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число В = ");
            int stepen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Число А = {numb} в степени B = {stepen} равно {Stepen(numb, stepen)}");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}