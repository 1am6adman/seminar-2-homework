﻿// Функция принимает сообщение для отображения, и выводит результат .
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция принимает число от 1 до 7 и выводит сообщение.
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 && a == 6)
        {
            Console.Write("Под цифрой " + a + " Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7");
    }
    return " день";
}
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));