/*Напишите программу, которая принимает на вход число и выдает сумму цифр этого числа*/
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1, num2, num3, num4, num5, num6, result;
num6 = num % 10; num /= 10;
num5 = num % 10; num /= 10;
num4 = num % 10; num /= 10;
num3 = num % 10; num /= 10;
num2 = num % 10; num /= 10;
num1 = num % 10; num /= 10;
result = num1 + num2 + num3 + num4 + num5 + num6;
Console.WriteLine($"Сумма цифр числа N равна: {result}");


