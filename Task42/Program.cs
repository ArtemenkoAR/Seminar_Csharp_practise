// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

int res = 0;
string a = String.Empty;
while (num > 0)
{
    res = num % 2;
    num = num / 2;
    a = res + a;
}
Console.Write(a);

