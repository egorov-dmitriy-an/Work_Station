// Вывод значений от - N до N с шагом 1 способ 2

using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N ");
            double N = Convert.ToDouble(Console.ReadLine());
            N = (int)N;
            double count = - Math.Abs(N);             
                while(count <= N)
                {
                    Console.Write(count + ", ");
                    count++;
                }
        }   
    }
}