// Определение квадрата числа
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Напиши число");
           int number = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Квадрат числа " + number + " = " + (number*number));
        }
    }
}