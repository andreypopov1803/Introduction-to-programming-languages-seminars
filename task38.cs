/*38.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементами массива*/
double[] array = new double [6];
double max = 0;
double min = 1000;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write($"{array[i]}, ");
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
double dif = max - min;
Console.WriteLine("Максимальное значение массива равно:{0}", max);
Console.WriteLine("Минимальное значение массива равно:{0}", min);
Console.WriteLine("Разница между максимальным и минимальным значениями массива равно:{0}", dif);