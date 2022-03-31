// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99.
// Определите самый часто встречающийся элемент в массиве.
// Если таких элементов несколько, вывести их все.
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 4 Задача 3 Доп ================");
            Console.WriteLine("Исходный массив:");
            int[] array = new int[100]; // заполнение массива
            for (int i = 0; i < 100; i++)
            {
                array[i] = new Random().Next(1, 100);
                Console.Write($"{array[i]}, ");
            }

            int Find_numb(int[] array2, int temp_numb) // метод подсчета количества одинаковых элементов
            {
                int count = 0;
                for (int k = 0; k < 100; k++) if (array[k] == temp_numb) count += 1;
                return count;
            }

            int max_numb = 0; // поиск количества самого частого элемента
            for (int j = 0; j < 100; j++) if (Find_numb(array, array[j]) >= max_numb) max_numb = Find_numb(array, array[j]);

            List<int> list_max = new List<int>(); // список самых частых элементов

            for (int m = 0; m < 100; m++) if (Find_numb(array, array[m]) == max_numb) list_max.Add(array[m]);

            int[] array_max = list_max.ToArray(); // отсеиваем из списка повторяющиеся элементы

            Console.WriteLine("");
            Console.Write("Список самых частых элементов: ");
            List<int> list_0 = new List<int>();
            int leng = 1;
            list_0.Add(array_max[0]);
            Console.Write(list_0[0] + " ");
            for (int n = 0; n < array_max.Length; n++)
            {
                int mod = 0;
                for (int n2 = 0; n2 < leng; n2++)
                {
                    if (array_max[n] == list_0[n2]) mod = 1;
                }
                if (mod == 0)
                {
                    list_0.Add(array_max[n]);
                    Console.Write(array_max[n] + " ");
                    leng += 1;
                }
            }
            Console.WriteLine($"повторяющихся {max_numb} раз");
            Console.WriteLine("========================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
