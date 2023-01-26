/*Напишите программу, которая принимает на вход координаты двух точек, а на выходе дает
расстояние между ними в 3D пространстве*/
Console.WriteLine("Введите координаты точки А: ");
Console.Write("Ax: ");
int ax = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Ay: ");
int ay = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Az: ");
int az = int.Parse(Console.ReadLine() ?? " ");
Console.WriteLine("Введите координаты точки B: ");
Console.Write("Bx: ");
int bx = int.Parse(Console.ReadLine() ?? " ");
Console.Write("By: ");
int by = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Bz: ");
int bz = int.Parse(Console.ReadLine() ?? " ");
double x = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
Console.WriteLine($"Расстояние между точками равно {x}");
