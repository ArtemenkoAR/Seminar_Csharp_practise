// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] Arr1(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
    return arr;
}

void Arr2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = Arr1(n);
Arr2(array);
Console.WriteLine();
Console.Write("Введите число для проверки: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    if (array[i] == num)
    {
        Console.WriteLine("Данный элемент в массиве есть");
        break;
    }

    else
    {
        Console.WriteLine("Данного элемента в массиве нет");
    }
}