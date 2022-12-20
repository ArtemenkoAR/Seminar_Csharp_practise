// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
string Decimal(int n)
{
int res = 0;
string a = String.Empty;
while (n > 0)
{
    res = n % 2;
    n = n / 2;
    a = res + a;
}
return a;
}
Console.Write(Decimal(num));
