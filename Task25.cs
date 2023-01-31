/*Напишите цикл, который принимает на вход два числа (А и В) и возводит А в натуральную степень В.*/
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int result = 1;
int count = 1;
while(count <= B)
{
    result = result * A;
    count ++;
}
Console.WriteLine(result);