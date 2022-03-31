// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе. Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 4 Задача 27 ================");

            int Sum_numb(string numb)
            {
                int sum = 0;
                int count = numb.Length;
                int temp = Convert.ToInt32(numb);
                for (int i = 0; i < count; i++)
                {
                    sum = sum + temp % 10;
                    temp = temp / 10; ;
                }
                return sum;
            }
            Console.Write("Введите число А = ");
            string number = Console.ReadLine();
            Console.WriteLine($"Сумма цифр числа {number} равна {Sum_numb(number)}");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}