// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество чисел Фибоначчи: ");
int N = int.Parse(Console.ReadLine()!);

int[] Fib(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    // Console.Write(array[0] + " " + array[1] + " ");
    while (i < n)
    {
        array[i] = array[i - 2] + array[i - 1];
        // Console.Write(array[i]+" ");
        i++;
    }
    return array;
}
int[] arr = Fib(N);
Console.WriteLine(string.Join(" ", arr));

// int[] array = new int[N];
// array[0] = 0;
// array[1] = 1;
// int i=2;
// Console.Write(array[0] + " " + array[1] + " ");
// while (i<N)
// {
//     array[i] = array[i-2]+array[i-1];
//     Console.Write(array[i]+" ");
//     i++;
// }
