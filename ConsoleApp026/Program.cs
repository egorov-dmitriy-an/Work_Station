// Задача 19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Например:
// 14212-> нет
// 23432-> да
// 12821-> да

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Polindrom(string num_str)
            {
                if (num_str[0] == num_str[4] && num_str[1] == num_str[3])
                {
                    Console.WriteLine("число " + num_str + " является полиндромом");
                }
                else
                {
                    Console.WriteLine("число " + num_str + " не является полиндромом");
                }
            }
            Console.WriteLine("Введите пятизначное число: ");
            string five = Console.ReadLine();
            while (five.Length != 5)
            {
                Console.WriteLine("Введите пятизначное число: ");
                five = Console.ReadLine();
            }
            Polindrom(five);
        }
    }
}