// Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100)
// нулей и единиц. Размер массива должен совпадать с квадратом количества единиц в нём.


using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 4 Задача 2 Доп ================");
            void Fill_array()
            {
                int count = new Random().Next(1, 11);
                List<int> one_null_list = new List<int>();
                int sum_one = 0;
                for (int i = 0; i < count * count; i++)
                {
                    if (count - sum_one == count * count - i)
                    {
                        one_null_list.Add(1);
                        sum_one += 1;
                    }
                    else if (sum_one < count)
                    {
                        one_null_list.Add(new Random().Next(0, 2));
                        if (one_null_list[i] == 1) sum_one += 1;
                    }
                    else one_null_list.Add(0);
                }
                int[] num = one_null_list.ToArray();
                for (int j = 0; j < num.Length; j++) Console.Write(num[j] + ", ");
                Console.WriteLine("");
                Console.WriteLine($"Количество единиц в массиве равно {count} размер массива {count*count}");
            }
            Fill_array();
            Console.WriteLine("========================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}