// Напишите программу, которая на вход принимает два числа и выдает какое большее, а какое меньшее.
Console.Write("Введите первое число: ");
double numbera = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberb = double.Parse(Console.ReadLine());
if (numbera > numberb)
Console.WriteLine($"Наибольшим числом из введенных является: { numbera }, а наименьшим является число { numberb }");
else
Console.WriteLine($"Наибольшим числом из введенных является: { numberb }, а наименьшим является число { numbera }");