/*Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая
покажет количество четных чисел в массиве*/
int[] array = new int [10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]}, ");
if (array[i] % 2 == 0)
    {
        count++;
    }

}
Console.WriteLine("Количество четных чисел в массиве:{0}", count);

