// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите X1");
int X1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y1");
int Y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите X2");
int X2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Y2");
int Y2 = int.Parse(Console.ReadLine()!);

int AB = X2 - X1;
int BC = Y2 - Y1;
double a = AB * AB;
double b = BC * BC;
double d = a +b;

double c = Math.Sqrt(d);


Console.WriteLine($"Расстояние между двумя точками = {c}");

