// Задача 1. На ввод подаётся номер четверти.
// Создаются 3 случайные точки в этой четверти. 
// Определите самый оптимальный маршрут для торгового менеджера,
// который выезжает из центра координат.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 1 Доп ================");
            int[] PointsX(int quarter_number_X) // Метод для определения координаты Х точки
            {
                int[] cur_coordX = new int[4];
                int mod_x = 0;
                if (quarter_number_X == 1) mod_x = 1;
                else if (quarter_number_X == 2) mod_x = -1;
                else if (quarter_number_X == 3) mod_x = -1;
                else if (quarter_number_X == 4) mod_x = 1;

                Random rand = new Random();
                cur_coordX[0] = 0;
                for (int i = 1; i <= 3; i++)
                {
                    cur_coordX[i] = mod_x * rand.Next(1, 100);
                }
                return cur_coordX;
            }

            int[] PointsY(int quarter_number_Y) // Метод для определения координаты Y точки
            {
                int[] cur_coordY = new int[4];
                int mod_y = 0;
                if (quarter_number_Y == 1) mod_y = 1;
                else if (quarter_number_Y == 2) mod_y = 1;
                else if (quarter_number_Y == 3) mod_y = -1;
                else if (quarter_number_Y == 4) mod_y = -1;

                Random rand = new Random();
                cur_coordY[0] = 0;
                for (int i = 1; i <= 3; i++)
                {
                    cur_coordY[i] = mod_y * rand.Next(1, 100);
                }
                return cur_coordY;
            }

            int[] coordX = new int[4]; // Введение номера четверти
            int[] coordY = new int[4];
            Console.Write("Введите номер четверти: ");
            int quarter = Convert.ToInt32(Console.ReadLine());
            if (quarter < 1 || quarter > 4) Console.WriteLine("Введен неправильный номер четверти");
            else
            {
                coordX = PointsX(quarter);
                coordY = PointsY(quarter);
            }
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("Координаты точки = (" + coordX[i] + ", " + coordY[i] + ")");
            }

            double Distance(int x_a1, int y_a1, int x_a2, int y_a2) // Определение расстояния между точками
            {
                double dist = Math.Sqrt(Math.Pow((x_a1 - x_a2), 2) + Math.Pow((y_a1 - y_a2), 2));
                return dist;
            }

            double full_way = 0; // Определение полного пути
            int min_number = 0;
            for (int j = 3; j > 0; j = j - 1)
            {
                double min_dist = Distance(coordX[0], coordY[0], coordX[1], coordY[1]);
                for (int k = 0; k < j; k++)
                {
                    double temp_dist = Distance(coordX[0], coordY[0], coordX[k + 1], coordY[k + 1]);
                    Console.WriteLine("Путь от точки (" + coordX[0] + ", " + coordY[0] + ") до точки (" + coordX[k + 1] + ", " + coordY[k + 1] + ") равен " + "{0: 0.00}", temp_dist);
                    if (temp_dist <= min_dist)
                    {
                        min_number = k + 1;
                        min_dist = temp_dist;
                    }
                }

                full_way = full_way + min_dist;
                Console.WriteLine("Минимальный путь равен: " + "{0:0.00}", min_dist);
                Console.WriteLine("Полный пройденный путь на текущем шаге: " + "{0:0.00}", full_way);
                Console.WriteLine("");

                int[] new_coordX = new int[j + 1];
                int[] new_coordY = new int[j + 1];

                for (int m = 1; m <= j; m++)
                {
                    if (m < min_number)
                    {
                        new_coordX[m] = coordX[m];
                        new_coordY[m] = coordY[m];
                        Console.WriteLine("Координаты точки = (" + coordX[m] + ", " + coordY[m] + ")");
                    }
                    else if (m == min_number)
                    {
                        coordX[0] = coordX[m];
                        coordY[0] = coordY[m];
                        Console.WriteLine("Теперь расстояния определяем от точки = (" + coordX[0] + ", " + coordY[0] + ")");
                    }
                    else if (m > min_number)
                    {
                        new_coordX[m - 1] = coordX[m];
                        coordX[m - 1] = new_coordX[m - 1];
                        new_coordY[m - 1] = coordY[m];
                        coordY[m - 1] = new_coordY[m - 1];
                        Console.WriteLine("Координаты точки = (" + coordX[m] + ", " + coordY[m] + ")");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Полный кратчайший путь равен:" + "{0: 0.00}", full_way);
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}