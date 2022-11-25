// Задача 35: Задайте одномерный массив из 123 случайных чисел. \
//Найдите количество элементов массива, значения которых
//  лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

var array = FillArray(123);
Print(array);
Console.WriteLine();
Console.Write($"Количество чисел в отрезке [10,99] = {GetCount(array)}");

int GetCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item >= 10 && item <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 501);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}