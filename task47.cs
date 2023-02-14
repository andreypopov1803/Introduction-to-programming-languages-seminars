/*Задайте двумерный массив размером m*n заполненный случайными вещественными числами*/
Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];

for (int row = 0; row < arr.GetLength(0); row++)
{
    for (int col = 0; col < arr.GetLength(1); col++)
    {
        arr[row,col] = Math.Round(new Random().NextDouble()*10,1);
    }
}
PrintArr(arr);

void PrintArr (double[,] arry)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write($" {arry[row, col],3} ");
        }
        Console.WriteLine();
    }
}
