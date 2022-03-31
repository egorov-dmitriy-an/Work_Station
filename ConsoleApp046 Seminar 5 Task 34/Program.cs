// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например: [345, 897, 568, 234] -> 2.
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 5 Задача 34 ================");
            Console.Write("Введите размер массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int [] array_3zn = new int[len];
            int quantity = 0;
            for (int i = 0; i<len; i++) 
            {
                array_3zn[i] = new Random().Next(100, 1000);
                Console.Write(array_3zn[i] + ", ");
                if(array_3zn[i] % 2 == 0) quantity +=1;
            }
            Console.WriteLine("");
            Console.WriteLine($"Количество четных элементов в массиве составляет: {quantity}");
            Console.WriteLine("========================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}

