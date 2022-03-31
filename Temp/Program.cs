// Задача 1. На вход подаётся натуральное десятичное число.
// Проверьте, является ли оно палиндромом в двоичной записи.

using System;
using System.Collections.Generic;
{
    void Perevod(int number)
    {
        List<int> dvoich = new List<int>();
        for (int i = 0; number >= 1; i++)
        {
            dvoich.Add(number % 2);
            number = number / 2;
            i++;
        }
        int[] num = dvoich.ToArray();
        Console.WriteLine(num.Length);
        Console.WriteLine("");
        for (int j = 0; j < num.Length; j++) Console.Write(num[num.Length - 1 - j] + ", ");
    }
    int numb = 100;
    Perevod(numb);    
}

