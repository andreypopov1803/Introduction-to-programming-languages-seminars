/*Напишите программу, которая принимает на вход позиции элемента в двумерном массиве
 и возвращает значение этого элемента или же указание, что такого элемента нет*/
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int row = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = new Random().Next(-5,5);
    }
}
PrintArr(arr);

void PrintArr (int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],3}");
        }
        Console.WriteLine();
    }
}

PrintSearchNumber(arr);

void PrintSearchNumber (int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i == col) && (j == row))
            {
                Console.WriteLine($"Число под выбранным индексом: {arry[col - 1,row - 1]}");
            }
        }
    }
}
if (n < row | m < col)
{
    Console.WriteLine($"Введенного индекса не существует");
}









