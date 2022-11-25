// Задача 33: Задайте массив. Напишите программу, которая
//  определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

var array = FillArray(10);
Print(array);
Console.WriteLine();
Console.Write("Введите искомое число\t");
var userNum = Convert.ToInt32(Console.ReadLine());

if(FindNum(array, userNum))
{
    Console.WriteLine("Число есть в массиве");
}
else
{
    Console.WriteLine("Числа нет в массиве");
}

bool FindNum(int[] arr, int num) //задали булеву функцию возвращающую true || false
{
    foreach(var item in arr)
    {
        if(item == num)
        {
            return true;
        }
    }
    return false;
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

