Console.Write("Введите число, которое хотите проверить на четность: ");
double number = int.Parse(Console.ReadLine());
double remainder;
remainder = number % 2;
if (remainder>0)
Console.Write($"Число {number} является нечетным");
else
Console.Write($"Число {number} является четным");