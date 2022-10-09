/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите число x1: ");
double x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число j1: ");
double j1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число j2: ");
double j2 = double.Parse(Console.ReadLine());

/* double z1 = Math.Pow(x2 - x1, 2);
double z2 = Math.Pow(y2 - y1, 2);
double z3 = Math.Pow(j2 - j1, 2); */

double dist=Math.Sqrt(Math.Pow (x2 - x1, 2)+Math.Pow (y2 - y1, 2)+Math.Pow (j2 - j1, 2));
Console.WriteLine(dist);
