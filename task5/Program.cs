// Составить программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5,25 - да
// 4,16 - да
// 8,9 - нет

Console.WriteLine("Введите число 1");
int a1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2");
int a2 = int.Parse(Console.ReadLine()!);
int c = a2*a2;
int d = a1*a1;
// if (a1 == a2*a2 || a2 == a1*a1)
if (a1 == c || a2 == d)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}