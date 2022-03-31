using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитее координату Х для А: ");
            int coorAX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введитее координату Y для А: ");
            int coorAY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введитее координату Х для В: ");
            int coorBX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введитее координату Х для В: ");
            int coorBY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Точка A имеет координаты: (" + coorAX + ", " + coorAY + ")");
            Console.WriteLine("Точка B имеет координаты: (" + coorBX + ", " + coorBY + ")");

            double sum = (Math.Pow((coorAX - coorBX), 2) + Math.Pow((coorAY - coorBY), 2));
            Console.WriteLine("Расстояние между А и В равно: " + "{0: 0.00}", Math.Sqrt(sum));

        }
    }
}