using System;
//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = CreateArray();
string[] result = FindElementsInArray(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindElementsInArray(string[] array, int n)
{
    string[] resultArray = new string[CountElements(array, n)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            resultArray[j] = array[i];
            j++;
        }
    }

    return resultArray;
}

int CountElements(string[] array, int n)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            count++;
        }
    }

    return count;
}

string[] CreateArray()
{
    Console.Write("Задайте значения массива через пробел: ");
    return Console.ReadLine().Split(" ");
}