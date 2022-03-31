// Задача 7. Из центра координат к точке А(x, y) проведён отрезок АО.
// Напишите программу, определяющую наименьший угол наклона отрезка AO к оси X.
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 7 Доп ================");
            void Ugol(int x1, int y1)
            {
                if (x1 == 0 && y1 == 0) Console.Write("Отрезок АО - нулевой");
                else if (x1 == 0) Console.Write("Наименьший угол равен 90");
                else Console.Write("Наименьший угол равен {0:0.00}", Math.Atan(y1 / x1) * (180 / Math.PI));
            }

            int x, y;
            Console.Write("Введите координату X точки А: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y точки А: ");
            y = Convert.ToInt32(Console.ReadLine());
            Ugol(x, y);
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}