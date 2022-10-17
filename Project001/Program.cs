
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
