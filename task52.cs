/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце*/
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(-5,6);
    }
}
PrintArr(arr);

void PrintArr (double[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],8}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Среднее арифметическое каждого столбца равно: ");
double average = 0;
SumArr(arr);
void SumArr (double[,] arry)

{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            average = average + arry[i, j];
        }
        Console.Write($"{Math.Round(average / m , 2), 8}");
        average = 0;
    }
}

