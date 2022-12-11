// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе равно = {CountNum(num)}");

int CountNum(int A)
{
    int count = 0;

    while (A > 0)
    {
        count++;
        A = A / 10;
    }
    return count;
}
