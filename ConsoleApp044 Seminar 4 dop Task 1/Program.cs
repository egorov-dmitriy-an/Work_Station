// Задача 1. На вход подаётся натуральное десятичное число.
// Проверьте, является ли оно палиндромом в двоичной записи.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 4 Задача 1 Доп ================");
                void Palindrom(int number)
                {
                    List<int> dvoich = new List<int>();
                    int save_numb = number;
                    for (int i = 0; number >= 1; i++)
                    {
                        dvoich.Add(number % 2);
                        number = number / 2;
                    }
                    int[] num = dvoich.ToArray();
                    Console.Write($"Число {save_numb} в двоичной системе счисления равное ");
                    for (int j = 0; j < num.Length; j++) Console.Write(num[num.Length - 1 - j]);
                    
                    int mod = 0;
                    for (int k = 0; k < num.Length / 2; k++)
                    {
                        if (num[k] != num[num.Length - 1 - k]) mod = 1;            
                    }
                    if (mod == 1) Console.Write($" не является палиндромом.");
                    else Console.Write($" является палиндромом.");
                }
                Console.Write("Введите натуральное десятичное число: ");
                int numb = Convert.ToInt32(Console.ReadLine());
                Palindrom(numb);
                Console.WriteLine("");
                Console.WriteLine("========================================================");
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey(true);
        }
    }
}