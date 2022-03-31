// Задача 29: Напишите программу, которая задаёт массив
// из 8 случайных целых чисел и выводит отсортированный
// по модулю массив. Например:
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 4 Задача 29 ================");
            
            void Sortirovka(int[] array_number) // создание метода сортировки
            {
                Console.WriteLine("Отсортированный массив:");
                for (int i = 0; i < array_number.Length; i++)
                {                                    
                    int min_position = i;

                    for (int j = i + 1; j < array_number.Length; j++)
                    {
                        if (Math.Abs(array_number[j]) < Math.Abs(array_number[min_position])) min_position = j;
                    }
                    int replace = array_number[i];
                    array_number[i] = array_number[min_position];
                    array_number[min_position] = replace;
                    Console.Write(array_number[i] + ", ");
                }
            }
            int[] array = new int[8]; // заполнение массива из 8 элементов
            Console.WriteLine("Заданный массив:");
            for (int k = 0; k < 8; k++) 
            {
                array[k] = new Random().Next(-100, 100);
                Console.Write(array[k] + ", ");
            }
            Console.WriteLine("");
            Sortirovka(array);
            Console.WriteLine("");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
        