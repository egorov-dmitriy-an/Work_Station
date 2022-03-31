// Задача 3. Иван в январе года открыл счет в банке, вложив 1000 руб.
// Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы.
// Определить размер депозита через n месяцев.

void Vklad(int month, int start)
{
    int index = 0;
    double sum = start;
    while (index < month)
    {
        sum = sum + 0.015 * sum;
        index++;
    }
    Console.WriteLine("Размер депозита через " + month + " месяцев составит:" + "{0: 0.00}", sum);
}

Console.Write("Введите количество месяцев: ");
int n_month = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начальную сумму: ");
int summa = Convert.ToInt32(Console.ReadLine());
Vklad(n_month, summa);