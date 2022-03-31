// Вид 1 - ничего не принимают ничего не возвращают
void Method1()
{
    Console.WriteLine("Author...");
}
//Method1();


// Вид 2 - ничего не возвращают, но принимают аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2(msg: "Текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(count: 4, msg: "New Text"); - Можно менять местами если именованные переменные

// Вид 3 - что-то возвращает, не принимают аргументы

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);


// Вид 4 - что-то возвращает и принимает аргументы
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// Console.WriteLine(Method4(4, "abc"));

// Вид 4.1 - for что-то возвращает и принимает аргументы
string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// Console.WriteLine(Method41(4, "z "));

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        // Console.WriteLine($"{i} x {j} = {i*j}");
    }
    // Console.WriteLine();
}

string text = "– Я думаю, – сказал князь улыбаясь, – что "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}            
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();


