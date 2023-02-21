/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(-10, 11);
    }
}
int minsum = 0;
int sum = 0;
SumStringArr(arr);
void SumStringArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            sum = sum + arr[i,j];
            Console.Write($"{arry[i, j],3}");
        }
        if (minsum > sum)
        {
            minsum = sum;
        }
        Console.WriteLine($"   Сумма чисел {i + 1} строки равна: {sum}");
        sum = 0;
    Console.WriteLine();
    }
}
FindStringArr(arr);
void FindStringArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            sum = sum + arr[i,j];
        }
        if (minsum == sum)
        {
            Console.Write($"   Минимальная сумма равна: {minsum}. Номер строки: {i + 1}");
        }
        sum = 0;
    }
}
