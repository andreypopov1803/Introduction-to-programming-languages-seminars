/* Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N*/
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? " ");
Console.WriteLine("Таблица квадратов чисел: ");
for (int i = 1; i < n; i++)
{
    Console.Write(Math.Pow(i, 3));
}
