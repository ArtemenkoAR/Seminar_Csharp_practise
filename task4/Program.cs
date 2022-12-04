// Напишите программу, которая принимает на вход число и проверяет, кратно  ли оно одновременно 7 и 23.

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int a = 7;
int b = 23;

if (n % 7 == 0 && n % 23 == 0)
{
    Console.WriteLine("Кратно числам 7 и 23");
}
else
{
    Console.WriteLine("Не кратно числам 7 и 23");
}
