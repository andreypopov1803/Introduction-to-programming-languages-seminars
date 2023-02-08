/*Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел польз.*/
int count = 0;
for (int i = 0; i < 10; i++)
{
    Console.Write("Введите число N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        count = count +1;
    }
}
Console.Write(count);
