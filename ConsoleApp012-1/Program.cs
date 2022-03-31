// Нахождение наибольшей цифры в двухзначном числе в интервале от 10 до 99

Random rnd = new Random();

for (int i=1; i<=10; i++)
{
    int number = rnd.Next(10, 100);
    Sravnenie(number);
}

void Sravnenie(int current_number)
{
    int t_place = current_number / 10;
    int d_place = current_number % 10;

    if (t_place > d_place) 
    {
        Console.WriteLine(current_number + " >> " + t_place);
    }
    else 
    {
        Console.WriteLine(current_number + " >> " + d_place);
    }
}