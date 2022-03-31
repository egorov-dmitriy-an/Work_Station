// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// А(3, 6, 8); В(2, 1, -7) -> 15,84
// А(7, 5, 0); В(1, -1, 9) -> 11,53

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введитее координату Х для А: ");
            int coorAX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введитее координату Y для А: ");
            int coorAY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введитее координату Z для А: ");
            int coorAZ = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Введитее координату Х для В: ");
            int coorBX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введитее координату Y для В: ");
            int coorBY = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введитее координату Z для В: ");
            int coorBZ = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("Точка A имеет координаты: (" + coorAX + ", " + coorAY + ", " + coorAZ + ")");
            Console.WriteLine("Точка B имеет координаты: (" + coorBX + ", " + coorBY + ", " + coorBZ + ")");

            Console.WriteLine("Расстояние между А и В равно: " + "{0: 0.000}", Math.Sqrt(Math.Pow((coorAX - coorBX), 2) + Math.Pow((coorAY - coorBY), 2) + Math.Pow((coorAZ - coorBZ), 2)));
        }
    }
}