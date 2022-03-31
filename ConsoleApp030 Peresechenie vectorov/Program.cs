// Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли векторы AB и CD?

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 2 Доп ================");
            double Angular_coefficient(int x1, int y1, int x2, int y2) // Определение углового коэффициента линейной функции
                {        
                double ang_coeff = (y2 - y1) / (x2 - x1);
                return ang_coeff;
                }

            double Zero_element_Y(int new_y2, double coef, int new_x2) // Определение значения Y при Х = 0
            {
                double zero_Y = (new_y2 - coef * new_x2);
                return zero_Y;
            }

            double Intersection_point_X(double zero_Y1, double coeff1, double zero_Y2, double coeff2) // Определение значения X пересечения векторов
            {
                double inter_X = (zero_Y2 - zero_Y1) / (coeff1 - coeff2);
                return inter_X;
            }

            double Intersection_point_Y(double ang_coef, double inter_X, double zero_Y3) // Определение значения Y пересечения векторов
            {
                double inter_Y = ang_coef * inter_X + zero_Y3;
                return inter_Y;
            }

            double Length_segment(double x_A, double y_A, double x_B, double y_B) // Определение длины отрезка
            {
                double leng = Math.Sqrt(Math.Pow((x_B - x_A), 2) + Math.Pow((y_B - y_A), 2));
                return leng;
            }

            double Affiliation(double x_len_a, double y_len_a, double x_len_b, double y_len_b, double x_len_m, double y_len_m) // Определение принадлежности точки отрезку
            {
                double affil_point = Length_segment(x_len_a, y_len_a, x_len_m, y_len_m) + Length_segment(x_len_b, y_len_b, x_len_m, y_len_m);
                if (affil_point == Length_segment(x_len_a, y_len_a, x_len_b, y_len_b))
                {
                    affil_point = 1;
                    return affil_point;
                }
                else 
                {
                    affil_point = 0;
                    return affil_point;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 2 Доп ================");

            Console.Write("Введите координату X точки А: ");
            int x_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y точки А: ");
            int y_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату X точки B: ");
            int x_b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y точки B: ");
            int y_b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату X точки C: ");
            int x_c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y точки C: ");
            int y_c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату X точки D: ");
            int x_d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y точки D: ");
            int y_d = Convert.ToInt32(Console.ReadLine());

            double inter_point_X = 0;
            double inter_point_Y = 0;
            double zero_Y_AB;
            double zero_Y_CD;
            double ang_coeff_AB = 0;
            double ang_coeff_CD = 0;
            int mod;

            if(x_a == x_b & x_c == x_d)
            {
                mod = 1;
            }
            else if(x_a == x_b)
            {
                inter_point_X = x_a;
                ang_coeff_CD = Angular_coefficient(x_c, y_c, x_d, y_d);
                zero_Y_CD = Zero_element_Y(y_d, ang_coeff_CD, x_d);
                inter_point_Y = Intersection_point_Y(ang_coeff_CD, inter_point_X, zero_Y_CD);
                mod = 2;
            }
            else if(x_c == x_d)
            {
                inter_point_X = x_c;
                ang_coeff_AB = Angular_coefficient(x_a, y_a, x_b, y_b);
                zero_Y_AB = Zero_element_Y(y_b, ang_coeff_AB, x_b);
                inter_point_Y = Intersection_point_Y(ang_coeff_AB, inter_point_X, zero_Y_AB);
                mod = 2;
            }
            else
            {   ang_coeff_AB = Angular_coefficient(x_a, y_a, x_b, y_c);
                zero_Y_AB = Zero_element_Y(y_b, ang_coeff_AB, x_b);

                ang_coeff_CD = Angular_coefficient(x_c, y_c, x_d, y_d);
                zero_Y_CD = Zero_element_Y(y_d, ang_coeff_CD, x_d);

                inter_point_X = Intersection_point_X(zero_Y_AB, ang_coeff_AB, zero_Y_CD, ang_coeff_CD);
                inter_point_Y = Intersection_point_Y(ang_coeff_AB, inter_point_X, zero_Y_AB);
                
                mod =2;

                if(ang_coeff_AB == ang_coeff_CD)
                {
                    mod = 3;
                }
            }

            double affil_AB = Affiliation(x_a, y_a, x_b, y_b, inter_point_X, inter_point_Y);
            double affil_CD = Affiliation(x_c, y_c, x_d, y_d, inter_point_X, inter_point_Y);

            if(mod == 1)
            {
                Console.WriteLine("Векторы вертикальны и не пересекаются");
            }
            else if(mod == 3)
            {
                Console.WriteLine("Векторы параллельны и не пересекаются");
            }
            else if(affil_AB == 1 && affil_CD == 1)
            {
                Console.WriteLine("Векторы пересекаются в точке: (" + inter_point_X + "; " + inter_point_Y + ")");
            }
            else 
            {
                Console.WriteLine("Векторы не пересекаются");
            }
            Console.WriteLine("");
            Console.WriteLine("========================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}