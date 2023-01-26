/*Напишите программу, которая принимает на вход число пятизначное число N и определяет является
ли оно палиндромом*/

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1, num2, num3, num4, num5;
Console.WriteLine(num);
num5 = num % 10;
num /= 10;
num4 = num % 10;
num /= 10;
num3 = num % 10;
num/=10;
num2 = num % 10;
num /= 10;
num1 = num % 10;
num /= 10;
if(num5 == num1 & num4 == num2 )
{
    Console.WriteLine("Число является палиндромом");
}else{
    Console.WriteLine("Число не является палиндромом");
}