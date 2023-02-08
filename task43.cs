/*Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1 и y = k2 * x + b2 */
Console.Write("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
Console.WriteLine($"Координаты точки пересечения двух прямых:({x};{y})");
