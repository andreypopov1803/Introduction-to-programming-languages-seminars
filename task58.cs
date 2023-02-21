/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
Console.WriteLine("Введите размер стороны матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] a = new int[m, m];
int[,] b = new int [m, m];
int[,] c =new int [m, m];
Random rnd = new Random();
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = rnd.Next(1, 5);
        Console.Write($"{a[i, j],3}");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
       {
          b[i, j] = rnd.Next(1, 5);
         Console.Write($"{b[i, j],3}");
       }
Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
Console.WriteLine();
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int k = 0; k < c.GetLength(1); k++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            c[i, k] += a[j, k]*b[i, j];  
        }
    Console.Write($"{c[i, k],3}");
    }
    Console.WriteLine();
}

