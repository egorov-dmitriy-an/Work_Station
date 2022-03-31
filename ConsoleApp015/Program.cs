// Создание метода проверки кратности 7 и 23 одновременно
int Kratno(int number)
{
    if ((number % 7 == 0) & (number % 23 == 0))
        {
            Console.WriteLine(number + " -> да");
        }
    else Console.WriteLine(number + " -> нет");
    return number;
}
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Kratno(a);