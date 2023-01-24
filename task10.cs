/*Напишите программу, которая на вход принимает трехзначное 
число и на выходе показывает вторую цифру этого числа*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1, num2, num3;
Console.WriteLine(num);
num3 = num % 10;
num/=10;
num2 = num % 10;
num /= 10;
num1 = num % 10;
num /= 10;

Console.WriteLine($"Вторая цифра введенного числа это {num2}");