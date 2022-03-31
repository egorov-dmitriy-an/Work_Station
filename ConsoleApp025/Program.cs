using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Kvadrat(int num_n)
            {
                int[] kvad = new int[num_n];
                for (int i = 0; i < num_n; i++)
                {
                    kvad[i] = (i + 1);
                    Console.Write(Math.Pow(kvad[i], 2) + ", ");
                }
            }
            Console.Write("Введите число N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Kvadrat(n);
            Console.WriteLine("");
        }
    }
}