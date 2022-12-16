//  Напишите программу замены элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

//1. Будут две функции, которые создают рандомный массив и выводят его в терминале.

int[] Random(int size,int min,int max)
{
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

void Print(int[] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
}

int[] array = Random(4, -8, 8);
Print(array);
Console.WriteLine();
Change(array);
void Change(int[] arr3)
{
    for (int i = 0; i < arr3.Length; i++)
    {
        arr3[i]*= -1;
        Console.Write($"{arr3[i]} ");
    }
}
