/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
int n = 4;
int[,] arr = new int[n, n];
int sum = 0;
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum++;
        Console.Write($"{sum, 4}");
    }
    Console.Write("\n");
    Console.Write("\n");
}
sum = sum + 8;
Console.Write($"{sum, 4}");
sum++;
Console.Write($"{sum, 4}");
sum++;
Console.Write($"{sum, 4}");
sum = sum - 9;
Console.Write($"{sum, 4}");
Console.Write("\n");
Console.Write("\n");
sum = sum + 6;
Console.Write($"{sum, 4}");
sum = sum + 5;
Console.Write($"{sum, 4}");
sum--;
Console.Write($"{sum, 4}");
sum = sum - 9;
Console.Write($"{sum, 4}");
Console.Write("\n");
Console.Write("\n");
sum = sum + 4;
Console.Write($"{sum, 4}");
sum--;
Console.Write($"{sum, 4}");
sum--;
Console.Write($"{sum, 4}");
sum--;
Console.Write($"{sum, 4}");
