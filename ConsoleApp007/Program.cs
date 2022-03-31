// Вывод значений от - N до N с шагом 1 способ 2
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            number = Math.Abs(number);
            for (int i = (- 1) * number; i <= number; i++)
            {
                Console.Write(i + ", ");
            }
        }
    }
}