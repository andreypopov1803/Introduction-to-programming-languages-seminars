/*Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечетных позициях*/
//Console.Write("Введите количество элементов массива: ");
//int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int [6];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 5);
    Console.Write($"{array[i]}, ");
    if (i % 2 == 0)
    {
        sum = sum + array[i];
    }
}


Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна:{0}", sum);
