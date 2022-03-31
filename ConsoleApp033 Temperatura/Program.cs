// Задача 5. Дан массив средних температур (массив заполняется случайно)
// за последние 10 лет. На ввод подают номер месяца и год начала и конца.
// Определить самые высокие и низкие температуры для лета, осени, зимы и весны
// в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("================ Семинар 3 Задача 5 Доп ================");
            Console.WriteLine("");

            int Month_day(int mumb_month1, int numb_year1) // Возвращаем количество дней в месяце по его номеру и году
            {
                int month_day = 0;
                if (mumb_month1 == 0 || mumb_month1 == 2 || mumb_month1 == 4 || mumb_month1 == 6 || mumb_month1 == 7 || mumb_month1 == 9 || mumb_month1 == 11) month_day = 31;
                else if (mumb_month1 == 3 || mumb_month1 == 5 || mumb_month1 == 8 || mumb_month1 == 10) month_day = 30;
                else if (mumb_month1 == 1 & numb_year1 % 4 == 0) month_day = 29;
                else if (mumb_month1 == 1 & numb_year1 % 4 != 0) month_day = 28;
                return month_day;
            }

            int[] Fill_month(int mumb_month2, int numb_year2)// Наполнение месяца температурами
            {
                int count1 = Month_day(mumb_month2, numb_year2);
                int[] month_array = new int[count1];

                for (int i1 = 0; i1 < count1; i1++)
                {
                    month_array[i1] = new Random().Next(-35, 36);
                }
                return month_array;
            }

            int Max_month(int[] month_array2) // Нахождение максимального значения в месяце
            {
                int count_max = month_array2.Length;
                int max1 = month_array2[0];
                for (int i3 = 1; i3 < count_max; i3++)
                {
                    if (month_array2[i3] > max1) max1 = month_array2[i3];
                }
                return max1;
            }

            int Min_month(int[] month_array2) // Нахождение минимального значения в месяце
            {
                int count_min = month_array2.Length;
                int min1 = month_array2[0];
                for (int i8 = 1; i8 < count_min; i8++)
                {
                    if (month_array2[i8] < min1) min1 = month_array2[i8];
                }
                return min1;
            }

            int[,][] years_arr = new int[10, 12][]; // Заполнение массива температур за 10 лет в период c 01.01.2012 по 31.12.2021
            for (int i4 = 0; i4 < 10; i4++)
            {
                for (int j4 = 0; j4 < 12; j4++)
                {
                    years_arr[i4, j4] = Fill_month(i4, j4 + 2012);
                }
            }

            Console.Write("Введите номер начального месяца: "); // Введение интервала определяемых значений
            int start_month = (Convert.ToInt32(Console.ReadLine()) - 1);
            Console.Write("Введите номер начального года: ");
            int start_year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер конечного месяца: ");
            int finish_month = (Convert.ToInt32(Console.ReadLine()) - 1);
            Console.Write("Введите номер конечного года: ");
            int finish_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");


            int max_winter = 0;
            int max_spring = 0;
            int max_summer = 0;
            int max_autumn = 0;

            int min_winter = 0;
            int min_spring = 0;
            int min_summer = 0;
            int min_autumn = 0;


            int mod_win = 0;
            int mod_spr = 0;
            int mod_sum = 0;
            int mod_aut = 0;

            int i6;
            int j6;

            if (start_year == finish_year)
            {
                for (i6 = start_year - 2012; i6 <= finish_year - 2012; i6++)
                {
                    for (j6 = start_month; j6 <= finish_month; j6++)
                    {
                        if (j6 == 0 || j6 == 1 || j6 == 11)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_winter) max_winter = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_winter) min_winter = Min_month(years_arr[i6, j6]);
                            mod_win = 1;
                        }
                        else if (j6 == 2 || j6 == 3 || j6 == 4)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_spring) max_spring = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_spring) min_spring = Min_month(years_arr[i6, j6]);
                            mod_spr = 1;
                        }
                        else if (j6 == 5 || j6 == 6 || j6 == 7)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_summer) max_summer = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_summer) min_summer = Min_month(years_arr[i6, j6]);
                            mod_sum = 1;
                        }
                        else if (j6 == 8 || j6 == 9 || j6 == 10)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_autumn) max_autumn = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_autumn) min_autumn = Min_month(years_arr[i6, j6]);
                            mod_aut = 1;
                        }
                    }
                }
            }

            else if (finish_year - start_year == 1)
            {
                for (i6 = start_year - 2012; i6 < start_year - 2012 + 1; i6++)
                {
                    for (j6 = start_month; j6 <= 11; j6++)
                    {
                        if (j6 == 0 || j6 == 1 || j6 == 11)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_winter) max_winter = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_winter) min_winter = Min_month(years_arr[i6, j6]);
                            mod_win = 1;
                        }
                        else if (j6 >= 2 & j6 <= 4)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_spring) max_spring = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_spring) min_spring = Min_month(years_arr[i6, j6]);
                            mod_spr = 1;
                        }
                        else if (j6 >= 5 & j6 <= 7)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_summer) max_summer = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_summer) min_summer = Min_month(years_arr[i6, j6]);
                            mod_sum = 1;
                        }
                        else if (j6 >= 8 & j6 <= 10)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_autumn) max_autumn = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_autumn) min_autumn = Min_month(years_arr[i6, j6]);
                            mod_aut = 1;
                        }
                    }
                }

                for (i6 = start_year - 2012 + 1; i6 <= finish_year - 2012; i6++)
                {
                    for (j6 = 0; j6 <= finish_month; j6++)
                    {
                        if (j6 == 0 || j6 == 1 || j6 == 11)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_winter) max_winter = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_winter) min_winter = Min_month(years_arr[i6, j6]);
                            mod_win = 1;
                        }
                        else if (j6 >= 2 & j6 <= 4)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_spring) max_spring = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_spring) min_spring = Min_month(years_arr[i6, j6]);
                            mod_spr = 1;
                        }
                        else if (j6 >= 5 & j6 <= 7)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_summer) max_summer = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_summer) min_summer = Min_month(years_arr[i6, j6]);
                            mod_sum = 1;
                        }
                        else if (j6 >= 8 & j6 <= 10)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_autumn) max_autumn = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_autumn) min_autumn = Min_month(years_arr[i6, j6]);
                            mod_aut = 1;
                        }
                    }
                }
            }

            else if (finish_year - start_year > 1)
            {
                for (i6 = start_year - 2012; i6 < start_year - 2012 + 1; i6++)
                {
                    for (j6 = start_month; j6 <= 11; j6++)
                    {
                        if (j6 == 0 || j6 == 1 || j6 == 11)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_winter) max_winter = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_winter) min_winter = Min_month(years_arr[i6, j6]);
                            mod_win = 1;
                        }
                        else if (j6 >= 2 & j6 <= 4)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_spring) max_spring = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_spring) min_spring = Min_month(years_arr[i6, j6]);
                            mod_spr = 1;
                        }
                        else if (j6 >= 5 & j6 <= 7)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_summer) max_summer = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_summer) min_summer = Min_month(years_arr[i6, j6]);
                            mod_sum = 1;
                        }
                        else if (j6 >= 8 & j6 <= 10)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_autumn) max_autumn = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_autumn) min_autumn = Min_month(years_arr[i6, j6]);
                            mod_aut = 1;
                        }
                    }
                }

                for (i6 = start_year - 2012 + 1; i6 < finish_year - 2012 - 1; i6++)
                {
                    for (j6 = 0; j6 <= 11; j6++)
                    {
                        if (j6 == 0 || j6 == 1 || j6 == 11)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_winter) max_winter = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_winter) min_winter = Min_month(years_arr[i6, j6]);
                            mod_win = 1;
                        }
                        else if (j6 >= 2 & j6 <= 4)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_spring) max_spring = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_spring) min_spring = Min_month(years_arr[i6, j6]);
                            mod_spr = 1;
                        }
                        else if (j6 >= 5 & j6 <= 7)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_summer) max_summer = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_summer) min_summer = Min_month(years_arr[i6, j6]);
                            mod_sum = 1;
                        }
                        else if (j6 >= 8 & j6 <= 10)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_autumn) max_autumn = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_autumn) min_autumn = Min_month(years_arr[i6, j6]);
                            mod_aut = 1;
                        }
                    }
                }

                for (i6 = finish_year - 2012; i6 < finish_year - 2012 + 1; i6++)
                {
                    for (j6 = 0; j6 <= finish_month; j6++)
                    {
                        if (j6 == 0 || j6 == 1 || j6 == 11)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_winter) max_winter = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_winter) min_winter = Min_month(years_arr[i6, j6]);
                            mod_win = 1;
                        }
                        else if (j6 >= 2 & j6 <= 4)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_spring) max_spring = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_spring) min_spring = Min_month(years_arr[i6, j6]);
                            mod_spr = 1;
                        }
                        else if (j6 >= 5 & j6 <= 7)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_summer) max_summer = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_summer) min_summer = Min_month(years_arr[i6, j6]);
                            mod_sum = 1;
                        }
                        else if (j6 >= 8 & j6 <= 10)
                        {
                            if (Max_month(years_arr[i6, j6]) > max_autumn) max_autumn = Max_month(years_arr[i6, j6]);
                            if (Min_month(years_arr[i6, j6]) < min_autumn) min_autumn = Min_month(years_arr[i6, j6]);
                            mod_aut = 1;
                        }
                    }
                }
            }

            Console.WriteLine($"Значения за зиму: ");
            if (mod_win == 0) Console.WriteLine($"Определить не удалось");
            else Console.WriteLine($"min = {min_winter}, max = {max_winter}");
            Console.WriteLine("");

            Console.WriteLine($"Значения за весну: ");
            if (mod_spr == 0) Console.WriteLine($"Определить не удалось");
            else Console.WriteLine($"min = {min_spring}, max = {max_spring}");
            Console.WriteLine("");

            Console.WriteLine($"Значения за лето: ");
            if (mod_sum == 0) Console.WriteLine($"Определить не удалось");
            else Console.WriteLine($"min = {min_summer}, max = {max_summer}");
            Console.WriteLine("");

            Console.WriteLine($"Значения за осень: ");
            if (mod_aut == 0) Console.WriteLine($"Определить не удалось");
            else Console.WriteLine($"min = {min_autumn}, max = {max_autumn}");

            Console.WriteLine("==================================================");
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}