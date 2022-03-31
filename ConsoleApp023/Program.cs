// Программа для определения координат для четверти

void Qvarta(int qwr_number)
{
    if (qwr_number == 1) Console.WriteLine("x > 0, y > 0");
    else if (qwr_number == 2) Console.WriteLine("x < 0, y > 0");
    else if (qwr_number == 3) Console.WriteLine("x < 0, y < 0");
    else if (qwr_number == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Такой четверти нет");
}
Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());
Qvarta(number);