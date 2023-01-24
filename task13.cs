/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1, num2, num3;
Console.WriteLine(num);
if (num>99)
{
    num3 = num % 10;
    num/=10;
    num2 = num % 10;
    num /= 10;
    num1 = num % 10;
    num /= 10;
    Console.WriteLine($"Третья цифра введенного числа равна {num3}");
}else{
    Console.WriteLine("Третьей цифры нет");
}


