// Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру в нем.

int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int a = n / 100;
int b = n % 10;
int c = n / 100;
int d = a * 10 + b;

Console.WriteLine($"трехзначное Число после удаления 2 цифры превращается в {d}");
