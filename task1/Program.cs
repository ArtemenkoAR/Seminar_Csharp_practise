// Написать программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

int n = new Random().Next(10, 100);
Console.WriteLine(n);
int a = n / 10;
int b = n % 10;
intmax = a;

if (b > a)
    max = b;

Console.WriteLine($"Максимальная цифра в числе {n} --> {max}");
