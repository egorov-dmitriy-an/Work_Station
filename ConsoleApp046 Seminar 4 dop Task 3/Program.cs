// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99.
// Определите самый часто встречающийся элемент в массиве.
// Если таких элементов несколько, вывести их все.

int[] array = new int[100]; // заполнение массива
for (int i = 0; i < 100; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]}, ");
}

int Find_numb(int[] array2, int temp_numb) // метод подсчета количества одинаковых элементов
{
    int count = 0;
    for (int k = 0; k < 100; k++) if (array[k] == temp_numb) count += 1;
    return count;
}

int max_numb = 0; // поиск количества самого частого элемента
for (int j = 0; j < 100; j++) if (Find_numb(array, array[j]) >= max_numb) max_numb = Find_numb(array, array[j]);

Console.WriteLine("");
List<int> list_max = new List<int>(); // список самых частых элементов
for (int m = 0; m < 100; m++)
{
    if (Find_numb(array, array[m]) == max_numb)
    {
        list_max.Add(array[m]);
        Console.Write($"{array[m]}, ");
    }
}
int[] array_max = list_max.ToArray();

int[] Ravno(int[] array3)
{
    for (int i2 = 0; i2 < array3.Length; i2++)
    {
        int temp_numb2 = array3[i2];
        for (int i3 = 1; i3 < array3.Length; i3++)
        {
            if(array3[i3] == temp_numb2)

        }
    }



}