// Подпрограмма для определения второй цифры трехзначного числа
int Num (int number)
{
    Console.WriteLine("Второй цифрой числа " + number + " является " + (number % 100) / 10);
    return number;
}
Console.WriteLine("Введите трехзначное число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Num(number2);
