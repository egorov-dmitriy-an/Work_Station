// Задача 2. На вход подаются год, номер месяца и день рождения человека.
// Определить возраст человека на момент 1 февраля 2022 года.

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Vozrast(int curDay, int curMonth, int curYear)
            {
                int tempDay = 0;
                if (curMonth == 1 || curMonth == 3 || curMonth == 5 || curMonth == 7 || curMonth == 8 || curMonth == 10 || curMonth == 12) tempDay = 32;
                if (curMonth == 4 || curMonth == 6 || curMonth == 9 || curMonth == 11 & curDay <= 30) tempDay = 31;
                if (curYear % 4 == 0 & curMonth == 2 & curDay <= 29) tempDay = 30;
                if (curYear % 4 != 0 & curMonth == 2 & curDay <= 28) tempDay = 29;

                if (curMonth <= 2 & curDay == 1)
                {
                    curDay = 0;
                    curMonth = 2 - curMonth;
                    curYear = 2022 - curYear;
                }
                else if (curMonth > 2 & curDay == 1)
                {
                    curDay = 0;
                    curMonth = 14 - curMonth;
                    curYear = 2022 - 1 - curYear;
                }
                else if (curMonth < 2 & curDay > 1)
                {
                    curDay = tempDay - curDay;
                    curMonth = 0;
                    curYear = 2022 - curYear;
                }
                else if (curMonth >= 2 & curDay > 1)
                {
                    curDay = tempDay - curDay;
                    curMonth = 14 - 1 - curMonth;
                    curYear = 2022 - 1 - curYear;
                }
                Console.WriteLine("на 01.02.2022 возраст составляет: " + curYear + " лет, " + curMonth + " месяцев, " + curDay + " дней.");
            }

            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Vozrast(day, month, year);
        }
    }
}