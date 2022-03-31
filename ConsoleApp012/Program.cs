// Нахождение наибольшей цифры в двухзначном числе в интервале от 10 до 99
void Fill(int[] collection)
{
    int index = 0;
    while (index < 10)
    {
        collection[index] = new Random().Next(10, 100);
        index++;
    }
}

void Print(int[] col)
{
    int position = 0;
    while (position < 10)
    {
        Console.WriteLine(col[position] + ", ");
        position++;
    }
}

void Zifra(int[] nakopl)
{
    int count = 0;
    while (count < 10)
    {
        int number = nakopl[count];
        int number1 = number / 10;
        int number2 = number % 10;
        if (number1 >= number2) Console.WriteLine("наибльшая цифра числа " + number + " равна " + number1);
        else Console.WriteLine("наибльшая цифра числа " + number + " равна " + number2);
        count++;
    }

}

int[] array = new int[10];
Fill(array);
Print(array);

Console.WriteLine();

Zifra(array);
