﻿// Функция принимает сообщение для отображения, и выводит результат.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Функция вывода цифры стоящей в середине.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
int number = ReadInt("Введите трехзначное число");
int amount = number.ToString().Length;

if (amount < 3 && amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}