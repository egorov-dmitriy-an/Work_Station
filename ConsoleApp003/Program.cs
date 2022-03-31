// Определение является ли одно число квадратом другого
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Kvadrat(number1, number2);

            void Kvadrat(int a, int b)
            {
                if (b * b == a)
                {
                    Console.WriteLine("Число " + a + " явлется квадратом числа " + b);
                }

                else
                {
                    Console.WriteLine("Число " + a + " не явлется квадратом числа " + b);
                }
            }
        }
    }
}