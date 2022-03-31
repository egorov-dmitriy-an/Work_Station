// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// Например: [3 7 22 2 78] -> 76

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 5 Задача 38 ================");
            double Razn(int len)
            {
                double[] array_rand = new double[len];
                double max = 0;
                double min = 0;
                for (int i = 0; i < len; i++)
                {
                    array_rand[i] = new Random().Next();
                    Console.Write(array_rand[i] + ", ");
                    if (i == 0)
                    {
                        max = array_rand[i];
                        min = array_rand[i];
                    }
                    else 
                    {
                        if (array_rand[i] > max) max = array_rand[i];
                        else if (array_rand[i] < min) min = array_rand[i];
                    }               
                }
                Console.WriteLine("");
                Console.WriteLine(max);
                Console.WriteLine(min);

                return (max - min);
            }
            Console.Write("Введите размер массива: ");
            int len2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Razn(len2)}");
            Console.WriteLine("=====================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}