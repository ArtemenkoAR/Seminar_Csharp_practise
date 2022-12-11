// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Array1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    // int i = 0;
    // while (i < array.Length)
    // {
    //     array[i] = new Random().Next(0, 2);
    // }
    // i++;
}
void Array2(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write($"{print[i]} ");
    }
    // int i = 0;
    // while (i < print.Length)
    // {
    //     Console.WriteLine(print[i]);
    //     i++;
    // }
}

int[] array = new int[8];
Array1(array);
Array2(array);
