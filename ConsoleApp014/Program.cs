// Проверка является ли одно число кратно другому
Console.WriteLine("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Kratno(int Current_number1, int Current_number2)
{
if(number2%Current_number1 == 0) Console.WriteLine("Число " + Current_number2 + " кратно числу " + Current_number1);
else Console.WriteLine("Число " + Current_number2 + " не кратно числу " + Current_number1 + ", остаток " +  Current_number2%Current_number1);
}

Kratno(number1, number2);