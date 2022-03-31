// Задача 10. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9, 
// второй умножает его на любое натуральное число от 2 до 9, 
// первый умножает результат на любое натуральное число от 2 до 9 и т. д. 
// Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 9 Доп ================");
            Console.Write("Первый игрок называет натуральное число от 2 до 9: ");
            int itog = Convert.ToInt32(Console.ReadLine());

            int mod = 0;
            int mnozitel;
            while (itog <= 1000)
            {
                if (mod == 1)
                {
                    Console.Write("Первый игрок вводит натуральное число от 2 до 9, на которое нужно умножить: ");
                    mnozitel = Convert.ToInt32(Console.ReadLine());
                    itog = itog * mnozitel;
                    Console.WriteLine("Результат = " + itog);
                    mod = 0;
                }
                else
                {
                    Console.Write("Второй игрок вводит натуральное число от 2 до 9, на которое нужно умножить: ");
                    mnozitel = Convert.ToInt32(Console.ReadLine());
                    itog = itog * mnozitel;
                    Console.WriteLine("Результат = " + itog);
                    mod = 1;
                }
            }
            if (mod == 1) Console.WriteLine("Победил второй игрок!");
            else Console.WriteLine("Победил первый игрок!");
            Console.WriteLine("========================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}