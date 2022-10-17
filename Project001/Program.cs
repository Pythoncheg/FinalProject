
int GetValue(int min, int max)
{
    return new Random().Next(min, max);
}


string[] CreateArray(int size)
{
    return new string[size];
}

void PrintArray(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i]}");

    }
    Console.WriteLine();
}

void Fill(string[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        int random = new Random().Next(48, 123);
        while (random > 57 && random < 65 || random > 89 && random < 97)
        {
            random = new Random().Next(48, 123);
        }
        array[i] += (char)random;
        i++;
    }
}

string[] FinalSort(string[] array)
{

    string[] final = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        char symbol = Convert.ToChar(array[i]);
        if (symbol >= '0' && symbol <= '9') continue;
        string symbols = Convert.ToString(symbol);
        final[i] = symbols;

    }
    return final;
}


int length = GetValue(50, 150);
string[] text = CreateArray(length);
Fill(text);
Console.WriteLine("Задан массив с псевдослучайными буквами и числами: ");
Console.WriteLine();
PrintArray(text);
Console.WriteLine();
Console.WriteLine("Получен отсортированный массив в котором теперь нет цифр:");
Console.WriteLine();
string[] finalText = FinalSort(text);
PrintArray(finalText);