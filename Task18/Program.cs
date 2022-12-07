// Напишите программу, которая по заданному номеру четверти показывает дипозон возможных координат точек в этой четверти (X и Y)

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine()!);

if (num == 1) Console.WriteLine("X>0 && Y>0");
if (num == 2) Console.WriteLine("X<0 && Y>0");
if (num == 3) Console.WriteLine("X<0 && Y<0");
if (num == 4) Console.WriteLine("X>0 && Y<0");
