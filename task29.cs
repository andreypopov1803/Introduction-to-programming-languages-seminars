/*Напишите программу, которая задает массив из N элементов в заданном пользователем диапазоне
и выводит их на экран*/
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число А, обозначающее нижнюю границу диапазона: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В, обозначающее верхнюю границу диапазона: ");
int B = int.Parse(Console.ReadLine());
int [] array = new int [N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(A,B);
    Console.WriteLine(array[i]);
}