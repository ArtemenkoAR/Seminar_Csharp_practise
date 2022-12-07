// Написать программу,которая принимает на вход координаты точки (X и Y), причем X!= 0 и Y!= 0 и выдает номер четверти, в которой находится эта точка

Console.WriteLine("Введите координату X");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0) Console.WriteLine("1");
if (X < 0 && Y > 0) Console.WriteLine("2");
if (X < 0 && Y < 0) Console.WriteLine("3");
if (X > 0 && Y < 0) Console.WriteLine("4");
