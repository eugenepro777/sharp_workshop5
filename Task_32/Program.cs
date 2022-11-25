// Задача 32: Напишите программу замены элементов массива:
//  положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

var array = FillArray(7);
Print(array);
Console.WriteLine();
ReplaceArray(array);
Print(array);

void ReplaceArray(int[] arr)
{
    for (int i=0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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
