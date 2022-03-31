// Задача 13: Напишите программу, которая выводит третью цифру (слева направо)
// заданного числа или сообщает, что третьей цифры нет, например:
// 645 --> 5
// 78 --> третьей цифры нет
// 32679 --> 6

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void FillAndPrintArray(int[] collection)
            {
                int length = collection.Length;
                int index = 0;

                Console.WriteLine("Введите нижнюю границу интервала значений чисел ");
                int minNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите верхнюю границу интервала значений чисел ");
                int maxNum = Convert.ToInt32(Console.ReadLine());

                while (index < length)
                {
                    collection[index] = new Random().Next(minNum, maxNum + 1);
                    index++;
                }
            }
            void SearchThird(int[] array_number)
            {
                int count = 0;
                int end = array_number.Length;

                while (count < end)
                {
                    string third = Convert.ToString(array_number[count]);

                    if (array_number[count] > 99)
                    {
                        Console.WriteLine("Третяя цифра числа " + array_number[count] + " --> " + third[2]);
                    }
                    else
                    {
                        Console.WriteLine("Третьей цифры у числа " + array_number[count] + " --> нет");
                    }
                    count++;
                }
            }

            Console.WriteLine("Введите количество чисел: ");
            int end_array = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[end_array];

            FillAndPrintArray(array);
            SearchThird(array);
        }
    }
}