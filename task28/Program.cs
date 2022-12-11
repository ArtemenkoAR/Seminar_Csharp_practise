// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение всех чисел от 1 до числа N равно = {Product(num)}");

int Product(int A)
{
    int i = 1;
    int b = 1;
    while (i <= A)
    {
        b *= i;
        i++;
    }
    return b;
}
