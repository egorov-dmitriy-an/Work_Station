// Задача 4. Дано натуральное число, в котором все цифры различны.
// Определить, какая цифра расположена в нем левее: максимальная или минимальная


void Num(string stroka)
{
    System.Console.WriteLine(stroka[1]);
}
Console.WriteLine("Введите трехзначное число ");
string str = Console.ReadLine();
while (str.Length != 3)
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
    str = Console.ReadLine();
}
Num(str);