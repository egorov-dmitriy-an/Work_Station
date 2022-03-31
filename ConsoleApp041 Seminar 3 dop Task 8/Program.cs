// Задача 8. Массив из ста элементов заполняется случайными числами от 1 до 100.
// Удалить из массива все элементы, содержащие число 3.
// Вывести в консоль новый массив и количество удалённых элементов.
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 8 Доп ================");
            int Search_3(string number)
            {
                int mod = 0;
                char three_symbol = '3';
                Convert.ToString(number);
                int count2 = number.Length;
                for (int count = 0; count < count2; count++) if (number[count] == three_symbol) mod = 1;
                return mod;
            }
            Console.WriteLine($"Исходный массив");
            int[] sto_array = new int[100];
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                sto_array[i] = rand.Next(1, 101);
                Console.Write($"{sto_array[i]}, ");
            }

            Console.WriteLine($"");
            Console.WriteLine($"Новый массив");
            int sum_three = 0;
            int[] no_three_array = new int[100];
            for (int i = 0; i < 100; i++)
            {
                string three_text = Convert.ToString(sto_array[i]);
                if (Search_3(three_text) == 1) 
                {
                    sum_three = sum_three + 1;
                }
                else
                {
                    no_three_array[i - sum_three] = sto_array[i];
                    Console.Write($"{no_three_array[i - sum_three]}, ");
                }    
            }
            Console.WriteLine($"");
            Console.WriteLine($"Количество удаленных элементов сотавило - {sum_three}");
            Console.WriteLine("========================================================");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}