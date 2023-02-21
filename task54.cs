// /* Задача 54.   Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-10, 11);
//     }
// }

// void PrintArr(int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j],3}");
//         }
//     Console.WriteLine();
//     }
// }
// PrintArr(arr);


namespace BabbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите количество строк массива: ");
            int colCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            int rowCount = Convert.ToInt32(Console.ReadLine());
            int[,] arr = GenerateArray(rowCount, colCount);
            Console.WriteLine("Исходный массив");
            PrintArray(arr);
            Console.WriteLine("Сортировка по строкам: ");
            int[] row = new int[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                BubbleSort(row);
                Insert(true, i, row, arr);
            }
            PrintArray(arr);
            
        }
        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int k = 0; k < source.Length; k++)
            {
                if (isRow)
                    dest[dim, k] = source[k];
                else
                    dest[k, dim] = source[k];
            }
        }
        public static int[,] GenerateArray(int t, int i)
        {
            int[,] table = new int[t, i];
            Random random = new Random();
            for (int a = 0; a < t; a++)
            {
                for (int b = 0; b < i; b++)
                {
                    table[a, b] = random.Next(0, 9);
                }
            }
            return table;
        }
        public static void PrintArray(int[,] array)
        {
            for (int a = 0; a < array.GetLength(0); a++)
            {
                for (int b = 0; b < array.GetLength(1); b++)
                {
                    Console.Write(array[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] < inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
    }
}