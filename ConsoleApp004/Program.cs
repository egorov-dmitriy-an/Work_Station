// Определение названия дня недели через номер (if else)
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if(a == 1) Console.WriteLine("Понедельник");
            else if(a == 2) Console.WriteLine("Вторник");
                else if(a == 3) Console.WriteLine("Среда");
                    else if(a == 4) Console.WriteLine("Четверг");
                        else if(a == 5) Console.WriteLine("Пятница");
                            else if(a == 6) Console.WriteLine("Суббота");
                                else if(a == 7) Console.WriteLine("Воскресенье");
                                    else Console.WriteLine("Такого дня нет");
        }  
    }
}
