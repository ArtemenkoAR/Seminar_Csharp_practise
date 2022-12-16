// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine()!);
Triangle(a,b,c);

void Triangle(int a1, int b1, int c1)
{
    if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
{
    Console.WriteLine("Yes");
}
    else
{
    Console.WriteLine("No");
}
}