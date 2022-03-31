// Определение названия дня недели через номер (Switch and case)
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                Console.WriteLine("Понедельник");
                break;                
                
                case 2:
                Console.WriteLine("Вторник");
                break;
                
                case 3:
                Console.WriteLine("Среда");
                break;
                
                case 4:
                Console.WriteLine("Четверг");
                break;
                
                case 5:
                Console.WriteLine("Пятница");
                break;
                
                case 6:
                Console.WriteLine("Суббота");
                break;

                case 7:
                Console.WriteLine("Воскресенье");
                break;

                default:
                Console.WriteLine("Такого дня нет");
                break;
            }
        }
    }
}