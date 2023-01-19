// Напишите программу, которая на вход принимает два числа и выдает какое большее, а какое меньшее.
Console.Write("Введите первое число: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double number3 = double.Parse(Console.ReadLine());
double max = number1;
if (number2 > max)
max = number2;
if (number3 >max)
max = number3;
Console.Write($"Наибольшим числом из введенных трех является { max }" );