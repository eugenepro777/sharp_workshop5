// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму
//  отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//  положительных чисел равна 29,
//  сумма отрицательных равна -20.

var array = FillArray(12);
Print(array);
Console.WriteLine();
Console.Write
($"Сумма положительных чисел = {SumMoreZero(array)}\nСумма отрицательных чисел = {SumLessZero(array)}");

int SumMoreZero(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item >= 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumLessZero(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item < 0)
        {
            sum += item;
        }
    }
    return sum;
}

int[] FillArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-50, 51);
    }
    return result;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

