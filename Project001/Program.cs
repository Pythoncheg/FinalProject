﻿
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

